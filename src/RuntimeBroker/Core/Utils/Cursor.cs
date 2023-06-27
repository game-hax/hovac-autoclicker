using System;
using System.Runtime.InteropServices;

namespace autoclicker.Core.Utils
{
    public struct PointStruct
    {
        public int x;
        public int y;
    }

    public struct CursorInfoStruct
    {
        public int cbSize;
        public int flags;
        public IntPtr hCursor;
        public PointStruct pt;
    }

    public static class Cursor
    {
        [DllImport("user32.dll")]
        public static extern bool GetCursorInfo(ref CursorInfoStruct pci);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpWindowClass, string lpWindowCaption);

        public static bool InMenu()
        {
            return IsCursorVisible();
        }

        public static bool IsCursorVisible()
        {
            CursorInfoStruct pci = new CursorInfoStruct { cbSize = Marshal.SizeOf(typeof(CursorInfoStruct)) };

            GetCursorInfo(ref pci);
            if (pci.hCursor.ToInt32() > 100000)
            {
                return false;
            }

            return true;
        }
    }
}
