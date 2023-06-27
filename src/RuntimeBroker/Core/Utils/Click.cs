using autoclicker.Properties;
using System;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoclicker.Core.Utils
{
    internal class Click
    {
        private static Clicker clicker = UI.clicker;

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public static void _PreClick()
        {
            if (clicker.settings.clickSoundsEnabled)
            {
                Thread thread = new Thread(new ThreadStart(ClickSound));
                thread.Start();
            }

            if (clicker.settings.randomizerEnabled)
                Wait();
        }

        public static void _Click()
        {
            if (clicker.settings.lmbEnabled)
                Left();
            if (clicker.settings.rmbEnabled)
                Right();
            if (clicker.settings.mmbEnabled)
                Middle();
        }

        #region Utilities

        #region Click

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        public static void Left()
        {
            if ((clicker.settings.whitelistedSlotsEnabled && clicker.settings.whitelistedSlots[clicker.settings.currentSlot]) || (clicker.settings.dimEnabled && Cursor.IsCursorVisible()))
            {
                clicker.multiclicking = false;
                clicker.blockhitting = false;
                return;
            }
            _PreClick();
            if (!clicker.settings.oimEnabled)
            {
                mouse_event(2, 0, 0, 0, 0);
                if (clicker.settings.randomizerEnabled)
                    Wait();
                mouse_event(4, 0, 0, 0, 0);
            }
            else
            {
                if (!clicker.settings.breakblocksEnabled)
                {
                    SendMessage(FindWindow("LWJGL", null), 0x201, 0, 0);
                    if (clicker.settings.randomizerEnabled)
                        Wait();
                    SendMessage(FindWindow("LWJGL", null), 0x202, 0, 0);
                }
                else
                {
                    SendMessage(FindWindow("LWJGL", null), 0x202, 0, 0);
                    SendMessage(FindWindow("LWJGL", null), 0x201, 0, 0);
                }
            }
            clicker.multiclicking = false;
        }

        public static void Right()
        {
            if ((clicker.settings.whitelistedSlotsEnabled && clicker.settings.whitelistedSlots[clicker.settings.currentSlot]) || (clicker.settings.dimEnabled && Cursor.IsCursorVisible()))
            {
                clicker.multiclicking = false;
                clicker.blockhitting = false;
                return;
            }
            _PreClick();
            if (!clicker.settings.oimEnabled)
            {
                mouse_event(8, 0, 0, 0, 0);
                if (clicker.settings.randomizerEnabled)
                    Wait();
                mouse_event(16, 0, 0, 0, 0);
            }
            else
            {
                SendMessage(FindWindow("LWJGL", null), 0x0204, 0, 0);
                if (clicker.settings.randomizerEnabled)
                    Wait();
                SendMessage(FindWindow("LWJGL", null), 0x0205, 0, 0);
            }
            clicker.multiclicking = false;
            clicker.blockhitting = false;
        }

        public static void Middle()
        {
            if ((clicker.settings.whitelistedSlotsEnabled && clicker.settings.whitelistedSlots[clicker.settings.currentSlot]) || (clicker.settings.dimEnabled && Cursor.IsCursorVisible()))
            {
                clicker.multiclicking = false;
                clicker.blockhitting = false;
                return;
            }
            _PreClick();
            if (!clicker.settings.oimEnabled)
            {
                mouse_event(32, 0, 0, 0, 0);
                if (clicker.settings.randomizerEnabled)
                    Wait();
                mouse_event(64, 0, 0, 0, 0);
            }
            else
            {
                SendMessage(FindWindow("LWJGL", null), 0x0207, 0, 0);
                if (clicker.settings.randomizerEnabled)
                    Wait();
                SendMessage(FindWindow("LWJGL", null), 0x0208, 0, 0);
            }
            clicker.multiclicking = false;
        }

        #endregion

        #region Others

        public static void Wait()
        {
            int min = clicker.settings.minRandomizer, max = clicker.settings.maxRandomizer;
            if (min > max)
            {
                int _min = min;
                min = max;
                max = _min;
            }
            else if (min == max)
                max++;
            Thread.Sleep(new Random().Next(min, max));
        }

        private static void ClickSound()
        {
            if (File.Exists(clicker.settings.soundPath))
            {
                try
                {
                    using (var player = new SoundPlayer(clicker.settings.soundPath))
                    {
                        player.Play();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error occurred while playing the sound: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("The specified sound file does not exist.");
            }
        }

        #endregion

        #endregion
    }
}
