using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using clicka;
using clicka.Keyboard;
using CLICKER_NO_UI.Clicker;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CLICKER_NO_UI
{
	// Token: 0x02000009 RID: 9
	public partial class ui : MaterialForm
	{
		// Token: 0x06000021 RID: 33 RVA: 0x000025E8 File Offset: 0x000007E8
		public ui()
		{
			Scrollclicker scrollclicker = new Scrollclicker();
			this.keyboardHook.KeyUp += this.KeyboardHook_KeyUp;
			Control.CheckForIllegalCrossThreadCalls = false;
			this.keyboardHook.Install();
			this.InitializeComponent();
			Thread thread = new Thread(new ThreadStart(this.doubleClicker));
			Thread thread2 = new Thread(new ThreadStart(this.holdClicker));
			Thread thread3 = new Thread(new ThreadStart(this.oppositeClicker));
			thread.Start();
			thread2.Start();
			thread3.Start();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000020D5 File Offset: 0x000002D5
		private void scrollToggle_CheckedChanged(object sender, EventArgs e)
		{
			Settings.scrollClicker = this.scrollToggle.Checked;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000020E8 File Offset: 0x000002E8
		private void leftToggle_CheckedChanged(object sender, EventArgs e)
		{
			Settings.left = this.leftToggle.Checked;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000020FB File Offset: 0x000002FB
		private void midToggle_CheckedChanged(object sender, EventArgs e)
		{
			Settings.mid = this.midToggle.Checked;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000210E File Offset: 0x0000030E
		private void rightToggle_CheckedChanged(object sender, EventArgs e)
		{
			Settings.right = this.rightToggle.Checked;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000274C File Offset: 0x0000094C
		private void doubleClicker()
		{
			this.doubleClicking = false;
			for (;;)
			{
				Thread.Sleep(CLICKER_NO_UI.Clicker.Click.Timing(5));
				bool flag = Settings.doubleClicker && !Settings.disabled;
				if (flag)
				{
					bool flag2 = Control.MouseButtons == MouseButtons.Left && Settings.left;
					if (flag2)
					{
						this.doubleClicking = true;
						bool flag3 = this.doubleClicking;
						if (flag3)
						{
							this.doubleClicking = false;
							for (int i = 0; i < this.multiCount.Value; i++)
							{
								this.doubleClicking = false;
								Click @object = new Click();
								Thread thread = new Thread(new ThreadStart(@object.Left));
								thread.Start();
							}
							this.doubleClicking = false;
						}
						this.doubleClicking = false;
					}
					bool flag4 = Control.MouseButtons == MouseButtons.Middle && Settings.mid;
					if (flag4)
					{
						this.doubleClicking = true;
						bool flag5 = this.doubleClicking;
						if (flag5)
						{
							this.doubleClicking = false;
							for (int j = 0; j < this.multiCount.Value; j++)
							{
								this.doubleClicking = false;
								Click object2 = new Click();
								Thread thread2 = new Thread(new ThreadStart(object2.Mid));
								thread2.Start();
							}
							this.doubleClicking = false;
						}
						this.doubleClicking = false;
					}
					bool flag6 = Control.MouseButtons == MouseButtons.Right && Settings.right;
					if (flag6)
					{
						this.doubleClicking = true;
						bool flag7 = this.doubleClicking;
						if (flag7)
						{
							this.doubleClicking = false;
							for (int k = 0; k < this.multiCount.Value; k++)
							{
								this.doubleClicking = false;
								Click object3 = new Click();
								Thread thread3 = new Thread(new ThreadStart(object3.Right));
								thread3.Start();
							}
							this.doubleClicking = false;
						}
						this.doubleClicking = false;
					}
				}
				this.doubleClicking = false;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000294C File Offset: 0x00000B4C
		private void holdClicker()
		{
			for (;;)
			{
				this.holdClicking = true;
				Thread.Sleep(CLICKER_NO_UI.Clicker.Click.Timing(5));
				bool flag = Settings.holdClicker && !Settings.disabled;
				if (flag)
				{
					bool flag2 = Control.MouseButtons == MouseButtons.Left && Settings.left;
					if (flag2)
					{
						Thread.Sleep(CLICKER_NO_UI.Clicker.Click.Timing(2));
						while (Control.MouseButtons == MouseButtons.Left)
						{
							this.holdClicking = true;
							bool flag3 = this.holdClicking;
							if (flag3)
							{
								this.holdClicking = false;
								Click @object = new Click();
								Thread thread = new Thread(new ThreadStart(@object.QuickLeft));
								thread.Start();
								Thread.Sleep(CLICKER_NO_UI.Clicker.Click.Timing(1));
								this.holdClicking = true;
							}
						}
					}
					bool flag4 = Control.MouseButtons == MouseButtons.Middle && Settings.mid;
					if (flag4)
					{
						Thread.Sleep(CLICKER_NO_UI.Clicker.Click.Timing(2));
						while (Control.MouseButtons == MouseButtons.Middle)
						{
							this.holdClicking = true;
							bool flag5 = this.holdClicking;
							if (flag5)
							{
								this.holdClicking = false;
								Click object2 = new Click();
								Thread thread2 = new Thread(new ThreadStart(object2.QuickMid));
								thread2.Start();
								Thread.Sleep(CLICKER_NO_UI.Clicker.Click.Timing(1));
								this.holdClicking = true;
							}
						}
					}
					bool flag6 = Control.MouseButtons == MouseButtons.Right && Settings.right;
					if (flag6)
					{
						Thread.Sleep(CLICKER_NO_UI.Clicker.Click.Timing(2));
						while (Control.MouseButtons == MouseButtons.Right)
						{
							this.holdClicking = true;
							bool flag7 = this.holdClicking;
							if (flag7)
							{
								this.holdClicking = false;
								Click object3 = new Click();
								Thread thread3 = new Thread(new ThreadStart(object3.QuickRight));
								thread3.Start();
								Thread.Sleep(CLICKER_NO_UI.Clicker.Click.Timing(1));
								this.holdClicking = true;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002B40 File Offset: 0x00000D40
		private void oppositeClicker()
		{
			this.oppositeClicking = false;
			for (;;)
			{
				Thread.Sleep(CLICKER_NO_UI.Clicker.Click.Timing(5));
				bool flag = Settings.oppositeClicker && !Settings.disabled;
				if (flag)
				{
					this.oppositeClicking = false;
					bool flag2 = Control.MouseButtons == MouseButtons.Left && Settings.left;
					if (flag2)
					{
						this.oppositeClicking = true;
						bool flag3 = this.oppositeClicking;
						if (flag3)
						{
							this.oppositeClicking = false;
							CLICKER_NO_UI.Clicker.Click.mouse_event(4, 0, 0, 0, 0);
							this.oppositeClicking = false;
							CLICKER_NO_UI.Clicker.Click.mouse_event(8, 0, 0, 0, 0);
							Thread.Sleep(CLICKER_NO_UI.Clicker.Click.Timing(0));
							this.oppositeClicking = false;
							CLICKER_NO_UI.Clicker.Click.mouse_event(16, 0, 0, 0, 0);
							this.oppositeClicking = false;
						}
						this.oppositeClicking = false;
					}
					bool flag4 = Control.MouseButtons == MouseButtons.Right && Settings.right;
					if (flag4)
					{
						this.oppositeClicking = true;
						bool flag5 = this.oppositeClicking;
						if (flag5)
						{
							this.oppositeClicking = false;
							CLICKER_NO_UI.Clicker.Click.mouse_event(16, 0, 0, 0, 0);
							this.oppositeClicking = false;
							CLICKER_NO_UI.Clicker.Click.mouse_event(2, 0, 0, 0, 0);
							Thread.Sleep(CLICKER_NO_UI.Clicker.Click.Timing(0));
							this.oppositeClicking = false;
							CLICKER_NO_UI.Clicker.Click.mouse_event(4, 0, 0, 0, 0);
							this.oppositeClicking = false;
						}
						this.oppositeClicking = false;
					}
				}
				this.oppositeClicking = false;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002121 File Offset: 0x00000321
		private void multiToggle_CheckedChanged(object sender, EventArgs e)
		{
			Settings.doubleClicker = this.multiToggle.Checked;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002134 File Offset: 0x00000334
		private void multiToggle_MouseClick(object sender, MouseEventArgs e)
		{
			MaterialMessageBox.Show("Multi-click toggled.", false, FlexibleMaterialForm.ButtonsPosition.Right);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002144 File Offset: 0x00000344
		private void scrollToggle_MouseClick(object sender, MouseEventArgs e)
		{
			MaterialMessageBox.Show("Scroll-click toggled.", false, FlexibleMaterialForm.ButtonsPosition.Right);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002C98 File Offset: 0x00000E98
		private void listener_Click(object sender, EventArgs e)
		{
			bool flag = !this.listening;
			if (flag)
			{
				this.listener.Text = "Listening...\nClick again to cancel";
				this.listening = true;
			}
			else
			{
				this.listener.Text = "Click to change disable key";
				this.listening = false;
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002CEC File Offset: 0x00000EEC
		private void KeyboardHook_KeyUp(KeyboardHook.VKeys key)
		{
			bool flag = this.listening;
			if (flag)
			{
				this.listener.Text = "Click to change disable key";
				this.listening = false;
				this.listener.Text = key.ToString() + "\nClick to change disable key";
				this.b = key;
			}
			else
			{
				bool flag2 = key == this.KeyBind || key == this.b;
				if (flag2)
				{
					this.overwrite.Checked = !this.overwrite.Checked;
				}
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002154 File Offset: 0x00000354
		private void overwrite_CheckedChanged(object sender, EventArgs e)
		{
			Settings.disabled = this.overwrite.Checked;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002D84 File Offset: 0x00000F84
		private void overwrite_MouseClick(object sender, MouseEventArgs e)
		{
			bool @checked = this.overwrite.Checked;
			if (@checked)
			{
				MaterialMessageBox.Show("Autoclicker is now disabled.", false, FlexibleMaterialForm.ButtonsPosition.Right);
			}
			else
			{
				MaterialMessageBox.Show("Autoclicker is now enabled.", false, FlexibleMaterialForm.ButtonsPosition.Right);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002167 File Offset: 0x00000367
		private void ui_FormClosed(object sender, FormClosedEventArgs e)
		{
			Process.GetCurrentProcess().Kill();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002175 File Offset: 0x00000375
		private void holdToggle_MouseClick(object sender, MouseEventArgs e)
		{
			MaterialMessageBox.Show("Hold-click toggled.", false, FlexibleMaterialForm.ButtonsPosition.Right);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002185 File Offset: 0x00000385
		private void holdToggle_CheckedChanged(object sender, EventArgs e)
		{
			Settings.holdClicker = this.holdToggle.Checked;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002198 File Offset: 0x00000398
		private void oppositeToggle_MouseClick(object sender, MouseEventArgs e)
		{
			MaterialMessageBox.Show("Opposite-click toggled.", false, FlexibleMaterialForm.ButtonsPosition.Right);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000021A8 File Offset: 0x000003A8
		private void oppositeToggle_CheckedChanged(object sender, EventArgs e)
		{
			Settings.oppositeClicker = this.oppositeToggle.Checked;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000021BB File Offset: 0x000003BB
		private void randomizedToggle_CheckedChanged(object sender, EventArgs e)
		{
			Settings.randomizedWait = this.randomizedToggle.Checked;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000021CE File Offset: 0x000003CE
		private void timeSlider_OnValueChanged(object sender, int newValue)
		{
			Settings.randomWaitMin = this.minSlider.Value;
			Settings.randomWaitMax = this.maxSlider.Value;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002DC4 File Offset: 0x00000FC4
		private void randomizedToggle_MouseClick(object sender, MouseEventArgs e)
		{
			bool @checked = this.randomizedToggle.Checked;
			if (@checked)
			{
				MaterialMessageBox.Show(string.Format("Randomized click speed enabled,\nrandomized test in ranges {0}-{1}: {2}", Settings.randomWaitMin, Settings.randomWaitMax, CLICKER_NO_UI.Clicker.Click.Timing(0)), true, FlexibleMaterialForm.ButtonsPosition.Right);
			}
			else
			{
				MaterialMessageBox.Show("Randomized click speed disabled.", false, FlexibleMaterialForm.ButtonsPosition.Right);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002E28 File Offset: 0x00001028
		private void presets_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.randomizedToggle.Checked = true;
			bool flag = this.bypass1.Text == "Hypixel Holdclick";
			if (flag)
			{
				this.minSlider.Value = 15;
				Settings.randomWaitMin = 15;
				this.maxSlider.Value = 40;
				Settings.randomWaitMax = 40;
			}
			else
			{
				bool flag2 = this.bypass1.Text == "Hypixel Doubleclick";
				if (flag2)
				{
					this.minSlider.Value = 200;
					Settings.randomWaitMin = 200;
					this.maxSlider.Value = 250;
					Settings.randomWaitMax = 250;
				}
				else
				{
					bool flag3 = this.bypass1.Text == "Safest Holdclick";
					if (flag3)
					{
						this.minSlider.Value = 40;
						Settings.randomWaitMin = 40;
						this.maxSlider.Value = 120;
						Settings.randomWaitMax = 120;
					}
					else
					{
						bool flag4 = this.bypass1.Text == "Safest Doubleclick";
						if (flag4)
						{
							this.minSlider.Value = 245;
							Settings.randomWaitMin = 245;
							this.maxSlider.Value = 250;
							Settings.randomWaitMax = 250;
						}
					}
				}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002F7C File Offset: 0x0000117C
		private void ui_Load(object sender, EventArgs e)
		{
			this.msm.AddFormToManage(this);
			this.msm.Theme = MaterialSkinManager.Themes.DARK;
			this.msm.ColorScheme = new ColorScheme(Primary.DeepPurple900, Primary.DeepPurple800, Primary.DeepPurple400, Accent.DeepPurple200, TextShade.WHITE);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002FCC File Offset: 0x000011CC
		private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.materialSwitch1.Checked;
			if (@checked)
			{
				this.msm.Theme = MaterialSkinManager.Themes.DARK;
				this.msm.ColorScheme = new ColorScheme(this.primary, this.darkPrimary, this.lightPrimary, this.accent, TextShade.WHITE);
			}
			else
			{
				this.msm.Theme = MaterialSkinManager.Themes.LIGHT;
				this.msm.ColorScheme = new ColorScheme(this.primary, this.darkPrimary, this.lightPrimary, this.accent, TextShade.BLACK);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003068 File Offset: 0x00001268
		private void colourSwitcher_MouseClick(object sender, MouseEventArgs e)
		{
			int num = 0;
			foreach (string a in this.colours)
			{
				num++;
				bool flag = a == this.colourSelected;
				if (flag)
				{
					bool flag2 = num == this.colours.Length;
					if (flag2)
					{
						num = 0;
					}
					this.colourSelected = this.colours[num];
					break;
				}
			}
			this.colourSwitcher.Text = "Colour: " + this.colourSelected;
			TextShade textShade = TextShade.BLACK;
			bool @checked = this.materialSwitch1.Checked;
			if (@checked)
			{
				textShade = TextShade.WHITE;
			}
			string text = this.colourSelected;
			string text2 = text;
			uint num2;
            num2 = 2166136261U;
            for (int i = 0; i < text2.Length; i++)
            {
                num2 = ((uint)text2[i] ^ num2) * 16777619U;
            }
            if (num2 <= 2743015548U)
			{
				if (num2 <= 1920678155U)
				{
					if (num2 != 606718655U)
					{
						if (num2 == 1920678155U)
						{
							if (text2 == "Orange")
							{
								this.primary = Primary.Orange900;
								this.darkPrimary = Primary.Orange800;
								this.lightPrimary = Primary.Orange400;
								this.accent = Accent.Orange200;
							}
						}
					}
					else if (text2 == "Teal")
					{
						this.primary = Primary.Teal900;
						this.darkPrimary = Primary.Teal800;
						this.lightPrimary = Primary.Teal400;
						this.accent = Accent.Teal200;
					}
				}
				else if (num2 != 2344092557U)
				{
					if (num2 == 2743015548U)
					{
						if (text2 == "Red")
						{
							this.primary = Primary.Red900;
							this.darkPrimary = Primary.Red800;
							this.lightPrimary = Primary.Red400;
							this.accent = Accent.Red200;
						}
					}
				}
				else if (text2 == "Pink")
				{
					this.primary = Primary.Pink900;
					this.darkPrimary = Primary.Pink800;
					this.lightPrimary = Primary.Pink400;
					this.accent = Accent.Pink200;
				}
			}
			else if (num2 <= 3062020639U)
			{
				if (num2 != 2840840028U)
				{
					if (num2 == 3062020639U)
					{
						if (text2 == "Purple")
						{
							this.primary = Primary.DeepPurple900;
							this.darkPrimary = Primary.DeepPurple800;
							this.lightPrimary = Primary.DeepPurple400;
							this.accent = Accent.DeepPurple200;
						}
					}
				}
				else if (text2 == "Green")
				{
					this.primary = Primary.Green900;
					this.darkPrimary = Primary.Green800;
					this.lightPrimary = Primary.Green400;
					this.accent = Accent.Green200;
				}
			}
			else if (num2 != 3654151273U)
			{
				if (num2 == 3923582957U)
				{
					if (text2 == "Blue")
					{
						this.primary = Primary.Blue900;
						this.darkPrimary = Primary.Blue800;
						this.lightPrimary = Primary.Blue400;
						this.accent = Accent.Blue200;
					}
				}
			}
			else if (text2 == "Yellow")
			{
				this.primary = Primary.Yellow900;
				this.darkPrimary = Primary.Yellow800;
				this.lightPrimary = Primary.Yellow400;
				this.accent = Accent.Yellow200;
			}
			this.msm.ColorScheme = new ColorScheme(this.primary, this.darkPrimary, this.lightPrimary, this.accent, textShade);
			bool flag3 = this.msm.Theme == MaterialSkinManager.Themes.DARK;
			if (flag3)
			{
				this.msm.Theme = MaterialSkinManager.Themes.LIGHT;
				this.msm.Theme = MaterialSkinManager.Themes.DARK;
			}
			else
			{
				this.msm.Theme = MaterialSkinManager.Themes.DARK;
				this.msm.Theme = MaterialSkinManager.Themes.LIGHT;
			}
		}

		// Token: 0x040000C5 RID: 197
		private bool doubleClicking = false;

		// Token: 0x040000C6 RID: 198
		private bool holdClicking = false;

		// Token: 0x040000C7 RID: 199
		private bool oppositeClicking = false;

		// Token: 0x040000C8 RID: 200
		private bool listening = false;

		// Token: 0x040000C9 RID: 201
		private KeyboardHook keyboardHook = new KeyboardHook();

		// Token: 0x040000CA RID: 202
		public bool IsToggled = true;

		// Token: 0x040000CB RID: 203
		public KeyboardHook.VKeys KeyBind;

		// Token: 0x040000CC RID: 204
		private KeyboardHook.VKeys b = KeyboardHook.VKeys.F6;

		// Token: 0x040000CD RID: 205
		public MaterialSkinManager msm = MaterialSkinManager.Instance;

		// Token: 0x040000CE RID: 206
		private Primary primary = Primary.DeepPurple900;

		// Token: 0x040000CF RID: 207
		private Primary darkPrimary = Primary.DeepPurple800;

		// Token: 0x040000D0 RID: 208
		private Primary lightPrimary = Primary.DeepPurple400;

		// Token: 0x040000D1 RID: 209
		private Accent accent = Accent.DeepPurple200;

		// Token: 0x040000D2 RID: 210
		private string[] colours = new string[]
		{
			"Red",
			"Orange",
			"Yellow",
			"Green",
			"Blue",
			"Teal",
			"Purple",
			"Pink"
		};

		// Token: 0x040000D3 RID: 211
		private string colourSelected = "Purple";
	}
}
