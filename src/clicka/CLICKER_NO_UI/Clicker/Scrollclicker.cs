using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using clicka;

namespace CLICKER_NO_UI.Clicker
{
	// Token: 0x0200000C RID: 12
	internal class Scrollclicker
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00002218 File Offset: 0x00000418
		public Scrollclicker()
		{
			Scrollclicker._hookID = Scrollclicker.SetHook(Scrollclicker._proc);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000057B4 File Offset: 0x000039B4
		private static IntPtr SetHook(Scrollclicker.LowLevelMouseProc proc)
		{
			IntPtr result;
			using (Process currentProcess = Process.GetCurrentProcess())
			{
				using (ProcessModule mainModule = currentProcess.MainModule)
				{
					result = Scrollclicker.SetWindowsHookEx(14, proc, Scrollclicker.GetModuleHandle(mainModule.ModuleName), 0U);
				}
			}
			return result;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000581C File Offset: 0x00003A1C
		private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
		{
			bool flag = Settings.scrollClicker && !Settings.disabled;
			if (flag)
			{
				bool flag2 = nCode >= 0 && 522 == (int)wParam;
				if (flag2)
				{
					Scrollclicker.MSLLHOOKSTRUCT msllhookstruct = (Scrollclicker.MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(Scrollclicker.MSLLHOOKSTRUCT));
					Console.WriteLine(msllhookstruct.pt.x.ToString() + ", " + msllhookstruct.pt.y.ToString());
					Click @object = new Click();
					Thread thread = new Thread(new ThreadStart(@object.click));
					thread.Start();
				}
			}
			return Scrollclicker.CallNextHookEx(Scrollclicker._hookID, nCode, wParam, lParam);
		}

		// Token: 0x0600004D RID: 77
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr SetWindowsHookEx(int idHook, Scrollclicker.LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

		// Token: 0x0600004E RID: 78
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool UnhookWindowsHookEx(IntPtr hhk);

		// Token: 0x0600004F RID: 79
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

		// Token: 0x06000050 RID: 80
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string lpModuleName);

		// Token: 0x040000FD RID: 253
		private static readonly Scrollclicker.LowLevelMouseProc _proc = new Scrollclicker.LowLevelMouseProc(Scrollclicker.HookCallback);

		// Token: 0x040000FE RID: 254
		private static IntPtr _hookID = IntPtr.Zero;

		// Token: 0x040000FF RID: 255
		private const int WH_MOUSE_LL = 14;

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x06000053 RID: 83
		private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

		// Token: 0x0200000E RID: 14
		private enum MouseMessages
		{
			// Token: 0x04000101 RID: 257
			WM_LBUTTONDOWN = 513,
			// Token: 0x04000102 RID: 258
			WM_LBUTTONUP,
			// Token: 0x04000103 RID: 259
			WM_MOUSEMOVE = 512,
			// Token: 0x04000104 RID: 260
			WM_MOUSEWHEEL = 522,
			// Token: 0x04000105 RID: 261
			WM_RBUTTONDOWN = 516,
			// Token: 0x04000106 RID: 262
			WM_RBUTTONUP
		}

		// Token: 0x0200000F RID: 15
		private struct POINT
		{
			// Token: 0x04000107 RID: 263
			public int x;

			// Token: 0x04000108 RID: 264
			public int y;
		}

		// Token: 0x02000010 RID: 16
		private struct MSLLHOOKSTRUCT
		{
			// Token: 0x04000109 RID: 265
			public Scrollclicker.POINT pt;

			// Token: 0x0400010A RID: 266
			public uint mouseData;

			// Token: 0x0400010B RID: 267
			public uint flags;

			// Token: 0x0400010C RID: 268
			public uint time;

			// Token: 0x0400010D RID: 269
			public IntPtr dwExtraInfo;
		}
	}
}
