using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoclicker
{
    public class KeyboardHook
    {
        public static VKeys ConvertToBindable(KeyEventArgs e)
        {
            VKeys result;
            if (e.KeyCode.ToString().Length > 1 && e.KeyCode.ToString().StartsWith("F"))
            {
                result = (VKeys)e.KeyCode;
            }
            else
            {
                if (e.KeyCode == Keys.ShiftKey)
                {
                    result = VKeys.RSHIFT;
                }
                else
                {
                    if ((e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z) || (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9))
                    {
                        result = (VKeys)e.KeyCode;
                    }
                    else
                    {
                        result = VKeys.UNKNOWN_KEY;
                    }
                }
            }

            return result;
        }

        public event KeyboardHookCallback KeyDown;
        public event KeyboardHookCallback KeyUp;

        public void Install()
        {
            hookHandler = new KeyboardHookHandler(HookFunc);
            hookID = SetHook(hookHandler);
        }

        public void Uninstall()
        {
            UnhookWindowsHookEx(hookID);
        }

        private IntPtr SetHook(KeyboardHookHandler proc)
        {
            IntPtr result;
            using (ProcessModule mainModule = Process.GetCurrentProcess().MainModule)
            {
                result = SetWindowsHookEx(13, proc, GetModuleHandle(mainModule.ModuleName),
                    0u);
            }

            return result;
        }

        private IntPtr HookFunc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                int num = wParam.ToInt32();

                if ((num == 256 || num == 260) && KeyDown != null)
                {
                    KeyDown((VKeys)Marshal.ReadInt32(lParam));
                }

                if ((num == 257 || num == 261) && KeyUp != null)
                {
                    KeyUp((VKeys)Marshal.ReadInt32(lParam));
                }
            }

            return CallNextHookEx(hookID, nCode, wParam, lParam);
        }

        ~KeyboardHook()
        {
            Uninstall();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, KeyboardHookHandler lpfn, IntPtr hMod,
            uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        private KeyboardHookHandler hookHandler;

        private IntPtr hookID = IntPtr.Zero;

        private const int WM_KEYDOWN = 256;

        private const int WM_SYSKEYDOWN = 260;

        private const int WM_KEYUP = 257;

        private const int WM_SYSKEYUP = 261;

        public enum VKeys
        {
            UNKNOWN_KEY,

            LBUTTON,

            RBUTTON,

            CANCEL,

            MBUTTON,

            XBUTTON1,

            XBUTTON2,

            BACK = 8,

            TAB,

            CLEAR = 12,

            RETURN,

            SHIFT = 16,

            CONTROL,

            MENU,

            PAUSE,

            CAPITAL,

            KANA,

            HANGUL = 21,

            JUNJA = 23,

            FINAL,

            HANJA,

            KANJI = 25,

            ESCAPE = 27,

            CONVERT,

            NONCONVERT,

            ACCEPT,

            MODECHANGE,

            SPACE,

            PRIOR,

            NEXT,

            END,

            HOME,

            LEFT,

            UP,

            RIGHT,

            DOWN,

            SELECT,

            PRINT,

            EXECUTE,

            SNAPSHOT,

            INSERT,

            DELETE,

            HELP,

            KEY_0,

            KEY_1,

            KEY_2,

            KEY_3,

            KEY_4,

            KEY_5,

            KEY_6,

            KEY_7,

            KEY_8,

            KEY_9,

            KEY_A = 65,

            KEY_B,

            KEY_C,

            KEY_D,

            KEY_E,

            KEY_F,

            KEY_G,

            KEY_H,

            KEY_I,

            KEY_J,

            KEY_K,

            KEY_L,

            KEY_M,

            KEY_N,

            KEY_O,

            KEY_P,

            KEY_Q,

            KEY_R,

            KEY_S,

            KEY_T,

            KEY_U,

            KEY_V,

            KEY_W,

            KEY_X,

            KEY_Y,

            KEY_Z,

            LWIN,

            RWIN,

            APPS,

            SLEEP = 95,

            NUMPAD0,

            NUMPAD1,

            NUMPAD2,

            NUMPAD3,

            NUMPAD4,

            NUMPAD5,

            NUMPAD6,

            NUMPAD7,

            NUMPAD8,

            NUMPAD9,

            MULTIPLY,

            ADD,

            SEPARATOR,

            SUBTRACT,

            DECIMAL,

            DIVIDE,

            F1,

            F2,

            F3,

            F4,

            F5,

            F6,

            F7,

            F8,

            F9,

            F10,

            F11,

            F12,

            F13,

            F14,

            F15,

            F16,

            F17,

            F18,

            F19,

            F20,

            F21,

            F22,

            F23,

            F24,

            NUMLOCK = 144,

            SCROLL,

            LSHIFT = 160,

            RSHIFT,

            LCONTROL,

            RCONTROL,

            LMENU,

            RMENU,

            BROWSER_BACK,

            BROWSER_FORWARD,

            BROWSER_REFRESH,

            BROWSER_STOP,

            BROWSER_SEARCH,

            BROWSER_FAVORITES,

            BROWSER_HOME,

            VOLUME_MUTE,

            VOLUME_DOWN,

            VOLUME_UP,

            MEDIA_NEXT_TRACK,

            MEDIA_PREV_TRACK,

            MEDIA_STOP,

            MEDIA_PLAY_PAUSE,

            LAUNCH_MAIL,

            LAUNCH_MEDIA_SELECT,

            LAUNCH_APP1,

            LAUNCH_APP2,

            OEM_1 = 186,

            OEM_PLUS,

            OEM_COMMA,

            OEM_MINUS,

            OEM_PERIOD,

            OEM_2,

            OEM_3,

            OEM_4 = 219,

            OEM_5,

            OEM_6,

            OEM_7,

            OEM_8,

            OEM_102 = 226,

            PROCESSKEY = 229,

            PACKET = 231,

            ATTN = 246,

            CRSEL,

            EXSEL,

            EREOF,

            PLAY,

            ZOOM,

            NONAME,

            PA1,

            OEM_CLEAR
        }

        private delegate IntPtr KeyboardHookHandler(int nCode, IntPtr wParam, IntPtr lParam);
        public delegate void KeyboardHookCallback(VKeys key);
    }
}
