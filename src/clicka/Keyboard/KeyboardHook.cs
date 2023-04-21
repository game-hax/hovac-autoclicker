using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace clicka.Keyboard
{
	// Token: 0x02000005 RID: 5
	public class KeyboardHook
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002320 File Offset: 0x00000520
		public static KeyboardHook.VKeys ConvertToBindable(KeyEventArgs e)
		{
			bool flag = e.KeyCode.ToString().Length > 1 && e.KeyCode.ToString().StartsWith("F");
			KeyboardHook.VKeys result;
			if (flag)
			{
				result = (KeyboardHook.VKeys)e.KeyCode;
			}
			else
			{
				bool flag2 = e.KeyCode == Keys.ShiftKey;
				if (flag2)
				{
					result = KeyboardHook.VKeys.RSHIFT;
				}
				else
				{
					bool flag3 = (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z) || (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9);
					if (flag3)
					{
						result = (KeyboardHook.VKeys)e.KeyCode;
					}
					else
					{
						result = KeyboardHook.VKeys.UNKNOWN_KEY;
					}
				}
			}
			return result;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600000B RID: 11 RVA: 0x000023E4 File Offset: 0x000005E4
		// (remove) Token: 0x0600000C RID: 12 RVA: 0x0000241C File Offset: 0x0000061C
		//[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event KeyboardHook.KeyboardHookCallback KeyDown;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600000D RID: 13 RVA: 0x00002454 File Offset: 0x00000654
		// (remove) Token: 0x0600000E RID: 14 RVA: 0x0000248C File Offset: 0x0000068C
		//[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event KeyboardHook.KeyboardHookCallback KeyUp;

		// Token: 0x0600000F RID: 15 RVA: 0x0000208B File Offset: 0x0000028B
		public void Install()
		{
			this.hookHandler = new KeyboardHook.KeyboardHookHandler(this.HookFunc);
			this.hookID = this.SetHook(this.hookHandler);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020B2 File Offset: 0x000002B2
		public void Uninstall()
		{
			KeyboardHook.UnhookWindowsHookEx(this.hookID);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000024C4 File Offset: 0x000006C4
		private IntPtr SetHook(KeyboardHook.KeyboardHookHandler proc)
		{
			IntPtr result;
			using (ProcessModule mainModule = Process.GetCurrentProcess().MainModule)
			{
				result = KeyboardHook.SetWindowsHookEx(13, proc, KeyboardHook.GetModuleHandle(mainModule.ModuleName), 0U);
			}
			return result;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002518 File Offset: 0x00000718
		private IntPtr HookFunc(int nCode, IntPtr wParam, IntPtr lParam)
		{
			bool flag = nCode >= 0;
			if (flag)
			{
				int num = wParam.ToInt32();
				bool flag2 = (num == 256 || num == 260) && this.KeyDown != null;
				if (flag2)
				{
					this.KeyDown((KeyboardHook.VKeys)Marshal.ReadInt32(lParam));
				}
				bool flag3 = (num == 257 || num == 261) && this.KeyUp != null;
				if (flag3)
				{
					this.KeyUp((KeyboardHook.VKeys)Marshal.ReadInt32(lParam));
				}
			}
			return KeyboardHook.CallNextHookEx(this.hookID, nCode, wParam, lParam);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000025B8 File Offset: 0x000007B8
		~KeyboardHook()
		{
			this.Uninstall();
		}

		// Token: 0x06000014 RID: 20
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr SetWindowsHookEx(int idHook, KeyboardHook.KeyboardHookHandler lpfn, IntPtr hMod, uint dwThreadId);

		// Token: 0x06000015 RID: 21
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool UnhookWindowsHookEx(IntPtr hhk);

		// Token: 0x06000016 RID: 22
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

		// Token: 0x06000017 RID: 23
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string lpModuleName);

		// Token: 0x04000011 RID: 17
		private KeyboardHook.KeyboardHookHandler hookHandler;

		// Token: 0x04000012 RID: 18
		private IntPtr hookID = IntPtr.Zero;

		// Token: 0x04000013 RID: 19
		private const int WM_KEYDOWN = 256;

		// Token: 0x04000014 RID: 20
		private const int WM_SYSKEYDOWN = 260;

		// Token: 0x04000015 RID: 21
		private const int WM_KEYUP = 257;

		// Token: 0x04000016 RID: 22
		private const int WM_SYSKEYUP = 261;

		// Token: 0x02000006 RID: 6
		public enum VKeys
		{
			// Token: 0x04000018 RID: 24
			UNKNOWN_KEY,
			// Token: 0x04000019 RID: 25
			LBUTTON,
			// Token: 0x0400001A RID: 26
			RBUTTON,
			// Token: 0x0400001B RID: 27
			CANCEL,
			// Token: 0x0400001C RID: 28
			MBUTTON,
			// Token: 0x0400001D RID: 29
			XBUTTON1,
			// Token: 0x0400001E RID: 30
			XBUTTON2,
			// Token: 0x0400001F RID: 31
			BACK = 8,
			// Token: 0x04000020 RID: 32
			TAB,
			// Token: 0x04000021 RID: 33
			CLEAR = 12,
			// Token: 0x04000022 RID: 34
			RETURN,
			// Token: 0x04000023 RID: 35
			SHIFT = 16,
			// Token: 0x04000024 RID: 36
			CONTROL,
			// Token: 0x04000025 RID: 37
			MENU,
			// Token: 0x04000026 RID: 38
			PAUSE,
			// Token: 0x04000027 RID: 39
			CAPITAL,
			// Token: 0x04000028 RID: 40
			KANA,
			// Token: 0x04000029 RID: 41
			HANGUL = 21,
			// Token: 0x0400002A RID: 42
			JUNJA = 23,
			// Token: 0x0400002B RID: 43
			FINAL,
			// Token: 0x0400002C RID: 44
			HANJA,
			// Token: 0x0400002D RID: 45
			KANJI = 25,
			// Token: 0x0400002E RID: 46
			ESCAPE = 27,
			// Token: 0x0400002F RID: 47
			CONVERT,
			// Token: 0x04000030 RID: 48
			NONCONVERT,
			// Token: 0x04000031 RID: 49
			ACCEPT,
			// Token: 0x04000032 RID: 50
			MODECHANGE,
			// Token: 0x04000033 RID: 51
			SPACE,
			// Token: 0x04000034 RID: 52
			PRIOR,
			// Token: 0x04000035 RID: 53
			NEXT,
			// Token: 0x04000036 RID: 54
			END,
			// Token: 0x04000037 RID: 55
			HOME,
			// Token: 0x04000038 RID: 56
			LEFT,
			// Token: 0x04000039 RID: 57
			UP,
			// Token: 0x0400003A RID: 58
			RIGHT,
			// Token: 0x0400003B RID: 59
			DOWN,
			// Token: 0x0400003C RID: 60
			SELECT,
			// Token: 0x0400003D RID: 61
			PRINT,
			// Token: 0x0400003E RID: 62
			EXECUTE,
			// Token: 0x0400003F RID: 63
			SNAPSHOT,
			// Token: 0x04000040 RID: 64
			INSERT,
			// Token: 0x04000041 RID: 65
			DELETE,
			// Token: 0x04000042 RID: 66
			HELP,
			// Token: 0x04000043 RID: 67
			KEY_0,
			// Token: 0x04000044 RID: 68
			KEY_1,
			// Token: 0x04000045 RID: 69
			KEY_2,
			// Token: 0x04000046 RID: 70
			KEY_3,
			// Token: 0x04000047 RID: 71
			KEY_4,
			// Token: 0x04000048 RID: 72
			KEY_5,
			// Token: 0x04000049 RID: 73
			KEY_6,
			// Token: 0x0400004A RID: 74
			KEY_7,
			// Token: 0x0400004B RID: 75
			KEY_8,
			// Token: 0x0400004C RID: 76
			KEY_9,
			// Token: 0x0400004D RID: 77
			KEY_A = 65,
			// Token: 0x0400004E RID: 78
			KEY_B,
			// Token: 0x0400004F RID: 79
			KEY_C,
			// Token: 0x04000050 RID: 80
			KEY_D,
			// Token: 0x04000051 RID: 81
			KEY_E,
			// Token: 0x04000052 RID: 82
			KEY_F,
			// Token: 0x04000053 RID: 83
			KEY_G,
			// Token: 0x04000054 RID: 84
			KEY_H,
			// Token: 0x04000055 RID: 85
			KEY_I,
			// Token: 0x04000056 RID: 86
			KEY_J,
			// Token: 0x04000057 RID: 87
			KEY_K,
			// Token: 0x04000058 RID: 88
			KEY_L,
			// Token: 0x04000059 RID: 89
			KEY_M,
			// Token: 0x0400005A RID: 90
			KEY_N,
			// Token: 0x0400005B RID: 91
			KEY_O,
			// Token: 0x0400005C RID: 92
			KEY_P,
			// Token: 0x0400005D RID: 93
			KEY_Q,
			// Token: 0x0400005E RID: 94
			KEY_R,
			// Token: 0x0400005F RID: 95
			KEY_S,
			// Token: 0x04000060 RID: 96
			KEY_T,
			// Token: 0x04000061 RID: 97
			KEY_U,
			// Token: 0x04000062 RID: 98
			KEY_V,
			// Token: 0x04000063 RID: 99
			KEY_W,
			// Token: 0x04000064 RID: 100
			KEY_X,
			// Token: 0x04000065 RID: 101
			KEY_Y,
			// Token: 0x04000066 RID: 102
			KEY_Z,
			// Token: 0x04000067 RID: 103
			LWIN,
			// Token: 0x04000068 RID: 104
			RWIN,
			// Token: 0x04000069 RID: 105
			APPS,
			// Token: 0x0400006A RID: 106
			SLEEP = 95,
			// Token: 0x0400006B RID: 107
			NUMPAD0,
			// Token: 0x0400006C RID: 108
			NUMPAD1,
			// Token: 0x0400006D RID: 109
			NUMPAD2,
			// Token: 0x0400006E RID: 110
			NUMPAD3,
			// Token: 0x0400006F RID: 111
			NUMPAD4,
			// Token: 0x04000070 RID: 112
			NUMPAD5,
			// Token: 0x04000071 RID: 113
			NUMPAD6,
			// Token: 0x04000072 RID: 114
			NUMPAD7,
			// Token: 0x04000073 RID: 115
			NUMPAD8,
			// Token: 0x04000074 RID: 116
			NUMPAD9,
			// Token: 0x04000075 RID: 117
			MULTIPLY,
			// Token: 0x04000076 RID: 118
			ADD,
			// Token: 0x04000077 RID: 119
			SEPARATOR,
			// Token: 0x04000078 RID: 120
			SUBTRACT,
			// Token: 0x04000079 RID: 121
			DECIMAL,
			// Token: 0x0400007A RID: 122
			DIVIDE,
			// Token: 0x0400007B RID: 123
			F1,
			// Token: 0x0400007C RID: 124
			F2,
			// Token: 0x0400007D RID: 125
			F3,
			// Token: 0x0400007E RID: 126
			F4,
			// Token: 0x0400007F RID: 127
			F5,
			// Token: 0x04000080 RID: 128
			F6,
			// Token: 0x04000081 RID: 129
			F7,
			// Token: 0x04000082 RID: 130
			F8,
			// Token: 0x04000083 RID: 131
			F9,
			// Token: 0x04000084 RID: 132
			F10,
			// Token: 0x04000085 RID: 133
			F11,
			// Token: 0x04000086 RID: 134
			F12,
			// Token: 0x04000087 RID: 135
			F13,
			// Token: 0x04000088 RID: 136
			F14,
			// Token: 0x04000089 RID: 137
			F15,
			// Token: 0x0400008A RID: 138
			F16,
			// Token: 0x0400008B RID: 139
			F17,
			// Token: 0x0400008C RID: 140
			F18,
			// Token: 0x0400008D RID: 141
			F19,
			// Token: 0x0400008E RID: 142
			F20,
			// Token: 0x0400008F RID: 143
			F21,
			// Token: 0x04000090 RID: 144
			F22,
			// Token: 0x04000091 RID: 145
			F23,
			// Token: 0x04000092 RID: 146
			F24,
			// Token: 0x04000093 RID: 147
			NUMLOCK = 144,
			// Token: 0x04000094 RID: 148
			SCROLL,
			// Token: 0x04000095 RID: 149
			LSHIFT = 160,
			// Token: 0x04000096 RID: 150
			RSHIFT,
			// Token: 0x04000097 RID: 151
			LCONTROL,
			// Token: 0x04000098 RID: 152
			RCONTROL,
			// Token: 0x04000099 RID: 153
			LMENU,
			// Token: 0x0400009A RID: 154
			RMENU,
			// Token: 0x0400009B RID: 155
			BROWSER_BACK,
			// Token: 0x0400009C RID: 156
			BROWSER_FORWARD,
			// Token: 0x0400009D RID: 157
			BROWSER_REFRESH,
			// Token: 0x0400009E RID: 158
			BROWSER_STOP,
			// Token: 0x0400009F RID: 159
			BROWSER_SEARCH,
			// Token: 0x040000A0 RID: 160
			BROWSER_FAVORITES,
			// Token: 0x040000A1 RID: 161
			BROWSER_HOME,
			// Token: 0x040000A2 RID: 162
			VOLUME_MUTE,
			// Token: 0x040000A3 RID: 163
			VOLUME_DOWN,
			// Token: 0x040000A4 RID: 164
			VOLUME_UP,
			// Token: 0x040000A5 RID: 165
			MEDIA_NEXT_TRACK,
			// Token: 0x040000A6 RID: 166
			MEDIA_PREV_TRACK,
			// Token: 0x040000A7 RID: 167
			MEDIA_STOP,
			// Token: 0x040000A8 RID: 168
			MEDIA_PLAY_PAUSE,
			// Token: 0x040000A9 RID: 169
			LAUNCH_MAIL,
			// Token: 0x040000AA RID: 170
			LAUNCH_MEDIA_SELECT,
			// Token: 0x040000AB RID: 171
			LAUNCH_APP1,
			// Token: 0x040000AC RID: 172
			LAUNCH_APP2,
			// Token: 0x040000AD RID: 173
			OEM_1 = 186,
			// Token: 0x040000AE RID: 174
			OEM_PLUS,
			// Token: 0x040000AF RID: 175
			OEM_COMMA,
			// Token: 0x040000B0 RID: 176
			OEM_MINUS,
			// Token: 0x040000B1 RID: 177
			OEM_PERIOD,
			// Token: 0x040000B2 RID: 178
			OEM_2,
			// Token: 0x040000B3 RID: 179
			OEM_3,
			// Token: 0x040000B4 RID: 180
			OEM_4 = 219,
			// Token: 0x040000B5 RID: 181
			OEM_5,
			// Token: 0x040000B6 RID: 182
			OEM_6,
			// Token: 0x040000B7 RID: 183
			OEM_7,
			// Token: 0x040000B8 RID: 184
			OEM_8,
			// Token: 0x040000B9 RID: 185
			OEM_102 = 226,
			// Token: 0x040000BA RID: 186
			PROCESSKEY = 229,
			// Token: 0x040000BB RID: 187
			PACKET = 231,
			// Token: 0x040000BC RID: 188
			ATTN = 246,
			// Token: 0x040000BD RID: 189
			CRSEL,
			// Token: 0x040000BE RID: 190
			EXSEL,
			// Token: 0x040000BF RID: 191
			EREOF,
			// Token: 0x040000C0 RID: 192
			PLAY,
			// Token: 0x040000C1 RID: 193
			ZOOM,
			// Token: 0x040000C2 RID: 194
			NONAME,
			// Token: 0x040000C3 RID: 195
			PA1,
			// Token: 0x040000C4 RID: 196
			OEM_CLEAR
		}

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x0600001A RID: 26
		private delegate IntPtr KeyboardHookHandler(int nCode, IntPtr wParam, IntPtr lParam);

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x0600001E RID: 30
		public delegate void KeyboardHookCallback(KeyboardHook.VKeys key);
	}
}
