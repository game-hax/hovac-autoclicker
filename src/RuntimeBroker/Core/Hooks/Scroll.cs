using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace autoclicker.Core.Hooks
{
    internal class Scroll
    {
        private static IntPtr SetHook(Scroll.LowLevelMouseProc proc) => Scroll.SetWindowsHookEx(14, proc, Scroll.GetModuleHandle(lpModuleName: Process.GetCurrentProcess().MainModule.ModuleName), 0U);

        public delegate void ScrollEventHandler();
        public static event ScrollEventHandler ScrollEvent;

        public static void Install()
        {
            Scroll._hookID = Scroll.SetHook(Scroll._proc);
        }

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && 522 == (int)wParam)
                ScrollEvent?.Invoke();
            return Scroll.CallNextHookEx(Scroll._hookID, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, Scroll.LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        private static readonly Scroll.LowLevelMouseProc _proc = new Scroll.LowLevelMouseProc(Scroll.HookCallback);

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
            WM_RBUTTONUP
        }

        private struct POINT
        {
            public int x;

            public int y;
        }

        private struct MSLLHOOKSTRUCT
        {
            public Scroll.POINT pt;

            public uint mouseData;

            public uint flags;

            public uint time;

            public IntPtr dwExtraInfo;
        }
    }
}
