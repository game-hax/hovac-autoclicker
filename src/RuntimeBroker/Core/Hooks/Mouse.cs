using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace autoclicker.Core.Hooks
{
    internal class Mouse
    {
        private static IntPtr SetHook(Mouse.LowLevelMouseProc proc) => Mouse.SetWindowsHookEx(14, proc, Mouse.GetModuleHandle(lpModuleName: Process.GetCurrentProcess().MainModule.ModuleName), 0U);

        public delegate void MouseEventHandler(MouseButton button);
        public static event MouseEventHandler MouseEvent;

        public static void Install()
        {
            Mouse._hookID = Mouse.SetHook(Mouse._proc);
        }

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                int mouseMessage = wParam.ToInt32();
                if (mouseMessage == (int)Mouse.MouseMessages.WM_LBUTTONDOWN)
                    MouseEvent?.Invoke(MouseButton.Left);
                else if (mouseMessage == (int)Mouse.MouseMessages.WM_RBUTTONDOWN)
                    MouseEvent?.Invoke(MouseButton.Right);
                else if (mouseMessage == (int)Mouse.MouseMessages.WM_MBUTTONDOWN)
                    MouseEvent?.Invoke(MouseButton.Middle);
            }
            return Mouse.CallNextHookEx(Mouse._hookID, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, Mouse.LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        private static readonly Mouse.LowLevelMouseProc _proc = new Mouse.LowLevelMouseProc(Mouse.HookCallback);

        private static IntPtr _hookID = IntPtr.Zero;

        private const int WH_MOUSE_LL = 14;

        public delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

        private enum MouseMessages
        {
            WM_LBUTTONDOWN = 513,
            WM_LBUTTONUP,
            WM_MOUSEMOVE = 512,
            WM_MOUSEWHEEL = 522,
            WM_RBUTTONDOWN = 516,
            WM_RBUTTONUP,
            WM_MBUTTONDOWN = 519,
            WM_MBUTTONUP
        }

        public enum MouseButton
        {
            Left,
            Right,
            Middle
        }

        private struct POINT
        {
            public int x;
            public int y;
        }

        private struct MSLLHOOKSTRUCT
        {
            public Mouse.POINT pt;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }
    }
}
