using System;
using System.Runtime.InteropServices;
using System.Threading;
using clicka;

namespace CLICKER_NO_UI.Clicker
{
	// Token: 0x0200000B RID: 11
	public class Click
	{
		// Token: 0x0600003F RID: 63
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

		// Token: 0x06000040 RID: 64 RVA: 0x00005548 File Offset: 0x00003748
		public static int Timing(int sa)
		{
			bool randomizedWait = Settings.randomizedWait;
			int result;
			if (randomizedWait)
			{
				bool flag = Settings.randomWaitMin == Settings.randomWaitMax;
				if (flag)
				{
					Settings.randomWaitMin--;
					Settings.randomWaitMax++;
				}
				bool flag2 = Settings.randomWaitMin > Settings.randomWaitMax;
				int num;
				if (flag2)
				{
					num = Click._random.Next(Settings.randomWaitMax, Settings.randomWaitMin);
				}
				else
				{
					num = Click._random.Next(Settings.randomWaitMin, Settings.randomWaitMax);
				}
				result = int.Parse(string.Format("{0}", sa + num));
			}
			else
			{
				result = sa;
			}
			return result;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000055F0 File Offset: 0x000037F0
		public void click()
		{
			bool disabled = Settings.disabled;
			if (!disabled)
			{
				bool left = Settings.left;
				if (left)
				{
					this.Left();
				}
				else
				{
					bool right = Settings.right;
					if (right)
					{
						this.Right();
					}
					else
					{
						bool mid = Settings.mid;
						if (mid)
						{
							this.Mid();
						}
					}
				}
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00005644 File Offset: 0x00003844
		public void Left()
		{
			bool disabled = Settings.disabled;
			if (!disabled)
			{
				Click.mouse_event(4, 0, 0, 0, 0);
				Click.mouse_event(2, 0, 0, 0, 0);
				Thread.Sleep(Click.Timing(0));
				Click.mouse_event(4, 0, 0, 0, 0);
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000568C File Offset: 0x0000388C
		public void Mid()
		{
			bool disabled = Settings.disabled;
			if (!disabled)
			{
				Click.mouse_event(64, 0, 0, 0, 0);
				Click.mouse_event(32, 0, 0, 0, 0);
				Thread.Sleep(Click.Timing(0));
				Click.mouse_event(64, 0, 0, 0, 0);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000056D8 File Offset: 0x000038D8
		public void Right()
		{
			bool disabled = Settings.disabled;
			if (!disabled)
			{
				Click.mouse_event(16, 0, 0, 0, 0);
				Click.mouse_event(8, 0, 0, 0, 0);
				Thread.Sleep(Click.Timing(0));
				Click.mouse_event(16, 0, 0, 0, 0);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00005720 File Offset: 0x00003920
		public void QuickLeft()
		{
			bool disabled = Settings.disabled;
			if (!disabled)
			{
				Click.mouse_event(4, 0, 0, 0, 0);
				Click.mouse_event(2, 0, 0, 0, 0);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00005750 File Offset: 0x00003950
		public void QuickMid()
		{
			bool disabled = Settings.disabled;
			if (!disabled)
			{
				Click.mouse_event(64, 0, 0, 0, 0);
				Click.mouse_event(32, 0, 0, 0, 0);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00005784 File Offset: 0x00003984
		public void QuickRight()
		{
			bool disabled = Settings.disabled;
			if (!disabled)
			{
				Click.mouse_event(16, 0, 0, 0, 0);
				Click.mouse_event(8, 0, 0, 0, 0);
			}
		}

		// Token: 0x040000F6 RID: 246
		public const int MOUSEEVENTF_LEFTDOWN = 2;

		// Token: 0x040000F7 RID: 247
		public const int MOUSEEVENTF_LEFTUP = 4;

		// Token: 0x040000F8 RID: 248
		public const int MOUSEEVENTF_RIGHTDOWN = 8;

		// Token: 0x040000F9 RID: 249
		public const int MOUSEEVENTF_RIGHTUP = 16;

		// Token: 0x040000FA RID: 250
		public const int MOUSEEVENTF_MIDDLEDOWN = 32;

		// Token: 0x040000FB RID: 251
		public const int MOUSEEVENTF_MIDDLEUP = 64;

		// Token: 0x040000FC RID: 252
		private static readonly Random _random = new Random();
	}
}
