using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoclicker {
    public partial class ui : MaterialForm
    {

        private string name = "HC";
        private List<string> motd = new List<string> {
            "written in c#!",
            "created by hovac",
            "wouldnt exist without getasynckeystate",
            "tip: use a vm for ss, use this in real pc!",
            "tip: use anticheat bypass presets (op)",
            "ugly free ui, premium clicker",
            "undetectable?"
        }; // topbar messages


        /// really boring code just pretend it doesnt exist
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);

        [DllImport("user32.dll")]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        public const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        public Boolean announce = true;
        public const int MOUSEEVENTF_LEFTUP = 0x0004;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        public const int MOUSEEVENTF_RIGHTUP = 0x0010;
        public const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private scroll scroll = new scroll();
        public const int MOUSEEVENTF_MIDDLEUP = 0x0040;

        private KeyboardHook.VKeys b = KeyboardHook.VKeys.F6;
        private KeyboardHook.VKeys b2;
        private KeyboardHook.VKeys b3;
        private KeyboardHook.VKeys b4;
        private KeyboardHook.VKeys b5;
        private KeyboardHook.VKeys b6;

        public bool clickin = false;
        public bool ovrwrit = false;

        public bool rnd = false;
        public bool rnd2 = false;
        public bool cds = false;

        public bool milsc = false;

        public bool hcs = false;
        public bool xbx = false;

        public bool blockin = false;
        public bool blockhitt = false;
        public bool holdclicc = false;

        public bool scrollclock = false;
        public bool scrollclicc = false;

        public decimal spd = 10;

        public MaterialSkinManager msm = MaterialSkinManager.Instance;

        private Random _random = new Random();

        private string motdc()
        {
            int index = _random.Next(motd.Count);
            var name = motd[index];
            return name;
        }

        public ui()
        {
            InitializeComponent();
            keyboardHook.KeyUp += KeyboardHook_KeyUp;
            keyboardHook.Install();
            this.Text = $"{name} | {motdc()}";
            CheckForIllegalCrossThreadCalls = false;

            // clickers
            Thread t = new Thread(DoubleClickF);
            Thread t2 = new Thread(CustomClickF);
            Thread t3 = new Thread(AutoClickF);
            Thread t4 = new Thread(HoldClickF);
            Thread t5 = new Thread(BlockHitF);
            Thread t6 = new Thread(ScrollClickF);
            t.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            t6.Start();
            // macros

            msm.AddFormToManage(this);
            msm.Theme = MaterialSkinManager.Themes.DARK;
            msm.ColorScheme = new ColorScheme(
                Primary.DeepPurple900,
                Primary.DeepPurple800,
                Primary.DeepPurple400,
                Accent.DeepPurple200,
                TextShade.WHITE
            );
        }

        public int rndmc(int sa)
        {
            if (rnd)
            {
                int minv = int.Parse(min.Value.ToString());
                int maxv = int.Parse(max.Value.ToString());
                if (minv == maxv)
                {
                    minv = minv - 1;
                    maxv = maxv + 1;
                }
                int sa2 = sa;
                if (minv > maxv)
                {
                    sa2 = _random.Next(maxv, minv);
                }
                else
                {
                    sa2 = _random.Next(minv, maxv);
                }
                string xas = $"{sa + sa2}";
                return int.Parse(xas);
            }
            return sa;
        }

        public int rndmc2(int sa)
        {
            if (rnd2)
            {
                int minv = int.Parse(min.Value.ToString()); // set to min2
                int maxv = int.Parse(max.Value.ToString()); // set to max2
                if (minv == maxv)
                {
                    minv = minv - 1;
                    maxv = maxv + 1;
                }
                int sa2 = sa;
                if (minv > maxv)
                {
                    sa2 = _random.Next(maxv, minv);
                }
                else
                {
                    sa2 = _random.Next(minv, maxv);
                }
                string xas = $"{sa + sa2}";
                return int.Parse(xas);
            }
            return sa;
        }

        public void left()
        {
            clickin = false;
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            Thread.Sleep(rndmc(0));
            clickin = false;
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        public void left2()
        {
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            clickin = false;
        }
        public void mid()
        {
            clickin = false;
            mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0);
            Thread.Sleep(rndmc(0));
            clickin = false;
            mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0);
        }
        public void mid2()
        {
            mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0);
            clickin = false;
        }
        public void right()
        {
            clickin = false;
            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
            Thread.Sleep(rndmc(0));
            clickin = false;
            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
        }
        public void right2()
        {
            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
            clickin = false;
        }
        public void right3()
        {
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            blockin = false;
            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
            Thread.Sleep(rndmc(0));
            blockin = false;
            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
        }

        public void ScrollClickF()
        {

        }

        public void HoldClickF()
        {
            while (true)
            {
                Thread.Sleep(rndmc(0005));
                if (holdclicc)
                {
                    if ((MouseButtons == MouseButtons.Left) && (m1.Checked))
                    {
                        clickin = true;
                        Thread.Sleep(rndmc(0005));
                        while (MouseButtons == MouseButtons.Left)
                        {
                            if ((clickin == true) && (ovrwrit == false))
                            {
                                left2();
                                Thread.Sleep(rndmc(0002));
                                clickin = true;
                            }
                        }
                    }
                    if ((MouseButtons == MouseButtons.Right) && (m2.Checked))
                    {
                        clickin = true;
                        Thread.Sleep(rndmc(0005));
                        while (MouseButtons == MouseButtons.Right)
                        {
                            if ((clickin == true) && (ovrwrit == false))
                            {
                                right2();
                                Thread.Sleep(rndmc(0002));
                                clickin = true;
                            }
                        }
                    }
                    if ((MouseButtons == MouseButtons.Middle) && (m3.Checked))
                    {
                        clickin = true;
                        Thread.Sleep(rndmc(0005));
                        while (MouseButtons == MouseButtons.Middle)
                        {
                            if ((clickin == true) && (ovrwrit == false))
                            {
                                mid2();
                                Thread.Sleep(rndmc(0002));
                                clickin = true;
                            }
                        }
                    }
                }
            }
        }

        public void DoubleClickF()
        {
            clickin = false;
            while (true)
            {
                Thread.Sleep(rndmc(0005));
                if (cds)
                {
                    clickin = false;
                    if ((MouseButtons == MouseButtons.Left) && (m1.Checked))
                    {
                        clickin = true;
                        if ((clickin == true) && (ovrwrit == false))
                        {
                            clickin = false;
                            Thread t = new Thread(left);
                            t.Start();
                            clickin = false;
                        }
                    }
                    if ((MouseButtons == MouseButtons.Right) && (m2.Checked))
                    {
                        clickin = true;
                        if ((clickin == true) && (ovrwrit == false))
                        {
                            clickin = false;
                            Thread t = new Thread(right);
                            t.Start();
                            clickin = false;
                        }
                    }
                    if ((MouseButtons == MouseButtons.Middle) && (m3.Checked))
                    {
                        clickin = true;
                        if ((clickin == true) && (ovrwrit == false))
                        {
                            clickin = false;
                            Thread t = new Thread(mid);
                            t.Start();
                            clickin = false;
                        }
                    }
                    clickin = false;
                }
            }
        }

        public void AutoClickF()
        {
            while (true)
            {
                if ((m1.Checked) && (ovrwrit == false) && (milsc))
                {
                    Thread t = new Thread(left);
                    t.Start();
                }
                if ((m2.Checked) && (ovrwrit == false) && (milsc))
                {
                    Thread t = new Thread(right);
                    t.Start();
                }
                if ((m3.Checked) && (ovrwrit == false) && (milsc))
                {
                    Thread t = new Thread(mid);
                    t.Start();
                }
                Thread.Sleep(rndmc(int.Parse(milx.Value.ToString())));
            }
        }

        public void BlockHitF()
        {
            blockin = false;
            while (true)
            {
                Thread.Sleep(rndmc(0005));
                if (blockhitt)
                {
                    blockin = false;
                    if ((MouseButtons == MouseButtons.Left) && (m1.Checked))
                    {
                        blockin = true;
                        if ((blockin == true) && (ovrwrit == false))
                        {
                            blockin = false;
                            right3();
                            blockin = false;
                        }
                    }
                }
            }
        }

        public void CustomClickF()
        {
            xbx = false;
            while (true)
            {
                Thread.Sleep(rndmc(0005));
                if (hcs)
                {
                    xbx = false;
                    if ((MouseButtons == MouseButtons.Left) && (m1.Checked))
                    {
                        xbx = true;
                        if ((xbx == true) && (ovrwrit == false))
                        {
                            xbx = false;
                            for (int i = 0; i < spd; i++)
                            {
                                Thread t = new Thread(left);
                                t.Start();
                            }
                            xbx = false;
                        }
                    }
                    if ((MouseButtons == MouseButtons.Middle) && (m3.Checked))
                    {
                        xbx = true;
                        if ((xbx == true) && (ovrwrit == false))
                        {
                            xbx = false;
                            for (int i = 0; i < spd; i++)
                            {
                                Thread t = new Thread(mid);
                                t.Start();
                            }
                            xbx = false;
                        }
                    }
                    if ((MouseButtons == MouseButtons.Right) && (m2.Checked))
                    {
                        xbx = true;
                        if ((xbx == true) && (ovrwrit == false))
                        {
                            xbx = false;
                            for (int i = 0; i < spd; i++)
                            {
                                Thread t = new Thread(right);
                                t.Start();
                            }
                            xbx = false;
                        }
                    }
                    xbx = false;
                }
            }
        }

        public void random_CheckedChanged(object sender, EventArgs e)
        {
            rnd = !rnd;
            MessageBox.Show("Random set to " + rnd.ToString() + ", test: " + rndmc(0050));
        }

        public void X_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        public void hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void ui_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void overwrite_CheckedChanged(object sender, EventArgs e)
        {
            ovrwrit = !ovrwrit;
            if (announce == true)
            {
                MessageBox.Show("Program set to " + ovrwrit.ToString());
            }
            else
            {
                announce = true;
            }
        }

        public void tm_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = tm.Checked;
        }

        public void dc_CheckedChanged(object sender, EventArgs e)
        {
            cds = !cds;
            MessageBox.Show("Double click set to " + cds.ToString());
            dc.Checked = cds;
        }

        public void hd_CheckedChanged(object sender, EventArgs e)
        {
            hcs = !hcs;
            MessageBox.Show("Super click set to " + hcs.ToString());
            hd.Checked = hcs;
        }

        public void sped_ValueChanged(object sender, EventArgs e)
        {
            spd = sped.Value;
        }

        public void autoclick_Click(object sender, EventArgs e)
        {
            milsc = !milsc;
            if (milsc)
            {
                autoclick.Text = "stop";
            }
            else
            {
                autoclick.Text = "start";
            }
            MessageBox.Show("Autoclicking set to " + milsc.ToString());
        }

        public void blockhit_CheckedChanged(object sender, EventArgs e)
        {
            blockhitt = !blockhitt;
        }

        public void holdclick_CheckedChanged(object sender, EventArgs e)
        {
            holdclicc = !holdclicc;
        }

        public void ui_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        public void changeColour(String colour)
        {
            TextShade tc = TextShade.WHITE;
            if (materialRadioButton1.Checked == true)
            {
                tc = TextShade.BLACK;
            }

            if (colour == "Red")
            {
                msm.ColorScheme = new ColorScheme(
                       Primary.Red900,
                       Primary.Red800,
                       Primary.Red400,
                       Accent.Red200,
                       tc
                   );
                materialRaisedButton1.Text = colour;
            }
            else if (colour == "Orange")
            {
                msm.ColorScheme = new ColorScheme(
                       Primary.Orange900,
                       Primary.Orange800,
                       Primary.Orange400,
                       Accent.Orange200,
                       tc
                   );
                materialRaisedButton1.Text = colour;
            }
            else if (colour == "Yellow")
            {
                msm.ColorScheme = new ColorScheme(
                       Primary.Yellow900,
                       Primary.Yellow800,
                       Primary.Yellow400,
                       Accent.Yellow200,
                       tc
                   );
                materialRaisedButton1.Text = colour;
            }
            else if (colour == "Green")
            {
                msm.ColorScheme = new ColorScheme(
                       Primary.Green900,
                       Primary.Green800,
                       Primary.Green400,
                       Accent.Green200,
                       tc
                   );
                materialRaisedButton1.Text = colour;
            }
            else if (colour == "Blue")
            {
                msm.ColorScheme = new ColorScheme(
                       Primary.Blue900,
                       Primary.Blue800,
                       Primary.Blue400,
                       Accent.Blue200,
                       tc
                   );
                materialRaisedButton1.Text = colour;
            }
            else if (colour == "Purple")
            {
                msm.ColorScheme = new ColorScheme(
                       Primary.DeepPurple900,
                       Primary.DeepPurple800,
                       Primary.DeepPurple400,
                       Accent.DeepPurple200,
                       tc
                   );
                materialRaisedButton1.Text = colour;
            }
            else if (colour == "Pink")
            {
                msm.ColorScheme = new ColorScheme(
                       Primary.Pink900,
                       Primary.Pink800,
                       Primary.Pink400,
                       Accent.Pink200,
                       tc
                   );
                materialRaisedButton1.Text = colour;
            }
            this.Update();
            this.Refresh();
        }

        public void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (materialRadioButton2.Checked == true)
            {
                msm.Theme = MaterialSkinManager.Themes.DARK;
                milx.BackColor = Color.FromArgb(40, 40, 40);
                milx.ForeColor = Color.FromArgb(255, 255, 255);
                sped.BackColor = Color.FromArgb(40, 40, 40);
                label3.ForeColor = Color.FromArgb(255, 255, 255);
                label4.ForeColor = Color.FromArgb(255, 255, 255);
                label5.ForeColor = Color.FromArgb(255, 255, 255);
                sped.ForeColor = Color.FromArgb(255, 255, 255);
                min.BackColor = Color.FromArgb(40, 40, 40);
                min.ForeColor = Color.FromArgb(255, 255, 255);
                max.BackColor = Color.FromArgb(40, 40, 40);
                max.ForeColor = Color.FromArgb(255, 255, 255);
                numericUpDown2.BackColor = Color.FromArgb(40, 40, 40);
                numericUpDown2.ForeColor = Color.FromArgb(255, 255, 255);
                numericUpDown3.BackColor = Color.FromArgb(40, 40, 40);
                numericUpDown3.ForeColor = Color.FromArgb(255, 255, 255);
                numericUpDown4.BackColor = Color.FromArgb(40, 40, 40);
                numericUpDown4.ForeColor = Color.FromArgb(255, 255, 255);
                clic.BackColor = Color.FromArgb(51, 51, 51);
                bypass1.ForeColor = Color.FromArgb(255, 255, 255);
                bypass1.BackColor = Color.FromArgb(40, 40, 40);
                mice.Image = global::autoclicker.Properties.Resources.mice;
                this.Update();
                this.Refresh();
                if (materialRaisedButton1.Text == "Blue")
                {
                    changeColour("Purple");
                }
                else
                {
                    changeColour(materialRaisedButton1.Text);
                }
            }
        }

        public void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialRadioButton1.Checked == true)
            {
                msm.Theme = MaterialSkinManager.Themes.LIGHT;
                milx.BackColor = Color.FromArgb(230, 230, 230);
                milx.ForeColor = Color.FromArgb(0, 0, 0);
                sped.BackColor = Color.FromArgb(230, 230, 230);
                sped.ForeColor = Color.FromArgb(0, 0, 0);
                min.BackColor = Color.FromArgb(230, 230, 230);
                min.ForeColor = Color.FromArgb(0, 0, 0);
                max.BackColor = Color.FromArgb(230, 230, 230);
                max.ForeColor = Color.FromArgb(0, 0, 0);
                numericUpDown2.BackColor = Color.FromArgb(230, 230, 230);
                numericUpDown2.ForeColor = Color.FromArgb(0, 0, 0);
                numericUpDown3.BackColor = Color.FromArgb(230, 230, 230);
                numericUpDown3.ForeColor = Color.FromArgb(0, 0, 0);
                numericUpDown4.BackColor = Color.FromArgb(230, 230, 230);
                numericUpDown4.ForeColor = Color.FromArgb(0, 0, 0);
                label3.ForeColor = Color.FromArgb(0, 0, 0);
                label4.ForeColor = Color.FromArgb(0, 0, 0);
                label5.ForeColor = Color.FromArgb(0, 0, 0);
                clic.BackColor = Color.FromArgb(255, 255, 255);
                bypass1.ForeColor = Color.FromArgb(0, 0, 0);
                bypass1.BackColor = Color.FromArgb(255, 255, 255);
                mice.Image = global::autoclicker.Properties.Resources.mice21;
                this.Update();
                this.Refresh();
                if (materialRaisedButton1.Text == "Purple")
                {
                    changeColour("Blue");
                }
                else
                {
                    changeColour(materialRaisedButton1.Text);
                }
            }
        }

        public void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(numericUpDown1.Value.ToString());
            if (numericUpDown1.Value == 1)
            {
                changeColour("Red");
            }
            else if (numericUpDown1.Value == 2)
            {
                changeColour("Orange");
            }
            else if (numericUpDown1.Value == 3)
            {
                changeColour("Yellow");
            }
            else if (numericUpDown1.Value == 4)
            {
                changeColour("Green");
            }
            else if (numericUpDown1.Value == 5)
            {
                changeColour("Blue");
            }
            else if (numericUpDown1.Value == 6)
            {
                changeColour("Purple");
            }
            else if (numericUpDown1.Value == 7)
            {
                changeColour("Pink");
            }
        }

        public void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 7)
            {
                numericUpDown1.Value = 1;
            }
            else
            {
                numericUpDown1.Value = numericUpDown1.Value + 1;
            }
        }

        public void funnypenis_CheckedChanged(object sender, EventArgs e)
        {
            scrollclicc = !scrollclicc;
            if (scrollclicc)
            {
                scroll.Show();
            }
            else if (!scrollclicc)
            {
                scroll.Hide();
            }
        }

        public void ui_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(Macro1F);
            t.Start();
            Thread t2 = new Thread(Macro2F);
            t2.Start();
            Thread t3 = new Thread(Macro3F);
            t3.Start();
            Thread t4 = new Thread(Macro4F);
            t4.Start();
            Thread t5 = new Thread(Macro5F);
            t5.Start();
        }

        private void bypass1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bypass1.Text == "Hypixel Holdclick")
            {
                min.Value = 10;
                max.Value = 40;
                random.Checked = true;
            }
            else if (bypass1.Text == "Hypixel Doubleclick")
            {
                min.Value = 200;
                max.Value = 250;
                random.Checked = true;
            }
            else if (bypass1.Text == "Safest Holdclick")
            {
                min.Value = 30;
                max.Value = 120;
                random.Checked = true;
            }
            else if (bypass1.Text == "Safest Doubleclick")
            {
                min.Value = 245;
                max.Value = 250;
                random.Checked = true;
            }
        }

        private void random2_CheckedChanged(object sender, EventArgs e)
        {
            rnd2 = !rnd2;
            MessageBox.Show("Random set to " + rnd2.ToString() + ", test: " + rndmc2(0050));
        }

        private void materialTabSelector2_Click(object sender, EventArgs e)
        {

        }

        private void materialTabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void max2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void min2_ValueChanged(object sender, EventArgs e)
        {

        }

        private bool listening = false;
        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (listening == false)
            {
                materialRaisedButton2.Text = "Listening...\nClick again to cancel";
                listening = true;
            }
            else
            {
                materialRaisedButton2.Text = "Click to change disable key";
                listening = false;
            }
        }

        private void min_ValueChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            this.Text = $"{name} | {motdc()}";
            this.Refresh();
        }


        private KeyboardHook keyboardHook = new KeyboardHook();
        public bool IsToggled = true;
        public KeyboardHook.VKeys KeyBind;

        private void KeyboardHook_KeyUp(KeyboardHook.VKeys key)
        {
           
            
            if (listening)
            {
                materialRaisedButton2.Text = "Click to change disable key";
                listening = false;
                materialRaisedButton2.Text = $"{key.ToString()}\nClick to change disable key";
                b = key;
            }
            else if (listening2)
            {
                listening2 = false;
                materialRaisedButton4.Text = $"Disable key: {key.ToString()}";
                b2 = key;
            }
            else if (listening3)
            {
                listening3 = false;
                materialRaisedButton5.Text = $"Disable key: {key.ToString()}";
                b3 = key;
            }
            else if (listening4)
            {
                listening4 = false;
                materialRaisedButton6.Text = $"Disable key: {key.ToString()}";
                b4 = key;
            }
            else if (listening5)
            {
                listening5 = false;
                materialRaisedButton7.Text = $"Disable key: {key.ToString()}";
                b5 = key;
            }
            else if (listening6)
            {
                listening6 = false;
                materialRaisedButton8.Text = $"Disable key: {key.ToString()}";
                b6 = key;
            }
            else
            {
                if (key == KeyBind || key == b)
                {
                    announce = false;
                    overwrite.Checked = !overwrite.Checked;
                }
                else if (key == KeyBind || key == b2)
                {
                    announce = false;
                    macroDisable1.Checked = !macroDisable1.Checked;
                }
                else if (key == KeyBind || key == b3)
                {
                    announce = false;
                    macroDisable2.Checked = !macroDisable2.Checked;
                }
                else if (key == KeyBind || key == b4)
                {
                    announce = false;
                    macroDisable3.Checked = !macroDisable3.Checked;
                }
                else if (key == KeyBind || key == b5)
                {
                    announce = false;
                    materialCheckBox1.Checked = !materialCheckBox1.Checked;
                }
                else if (key == KeyBind || key == b6)
                {
                    announce = false;
                    macroDisable5.Checked = !macroDisable5.Checked;
                }
            }

        }

        private void overwrite_Click(object sender, EventArgs e)
        {
            announce = true;
        }


        // MACRO1 START
        private bool listening2 = false;
        public bool macro1 = false;
        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            if (listening2 == false)
            {
                materialRaisedButton4.Text = "Listening...";
                listening2 = true;
            }
            else
            {
                materialRaisedButton4.Text = "Disable key: NONE";
                listening2 = false;
            }
        }
        private void macroDisable1_CheckedChanged(object sender, EventArgs e)
        {
            macro1 = !macro1;
            if (announce == true)
            {
                MessageBox.Show("Macro has been set to " + macro1.ToString());
            }
            else
            {
                announce = true;
            }
        }
        public bool macroing1 = false;
        public void right4()
        {
            macroing1 = false;
            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
            Thread.Sleep(rndmc(0));
            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
            macroing1 = false;
            return;
        }
        public void Macro1M()
        {
            SendKeys.SendWait(numericUpDown2.Value.ToString());
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            right4();
            SendKeys.SendWait(numericUpDown3.Value.ToString());
            right4();
            Thread.Sleep(rndmc(0005));
            SendKeys.SendWait(numericUpDown2.Value.ToString());
        }
        public void Macro1F()
        {
            macroing1 = false;
            while (true)
            {
                Thread.Sleep((0005));
                if (macro1 == true)
                {
                    macroing1 = false;
                    if ((MouseButtons == MouseButtons.Left) && (m1.Checked))
                    {
                        macroing1 = false;
                        macroing1 = true;
                        if ((macroing1 == true) && (ovrwrit == false))
                        {
                            macroing1 = false;
                            Macro1M();
                            macroing1 = false;
                        }
                        macroing1 = false;
                    }
                    macroing1 = false;
                }
            }
        }

        // MACRO1 END, MACRO 2 START
        private bool listening3 = false;
        public bool macro2 = false;
        public bool macroing2 = false;
        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            if (listening3 == false)
            {
                materialRaisedButton5.Text = "Listening...";
                listening3 = true;
            }
            else
            {
                materialRaisedButton5.Text = "Disable key: NONE";
                listening3 = false;
            }

        }

        private void macroDisable2_CheckedChanged(object sender, EventArgs e)
        {
            macro2 = !macro2;
            if (announce == true)
            {
                MessageBox.Show("Macro has been set to " + macro2.ToString());
            }
            else
            {
                announce = true;
            }
        }

        public void right5()
        {
            macroing2 = false;
            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
            Thread.Sleep(rndmc(0));
            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
            macroing2 = false;
            return;
        }

        public void left5()
        {
            macroing2 = false;
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            Thread.Sleep(rndmc(0));
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            macroing2 = false;
            return;
        }

        public void Macro2M()
        {
            SendKeys.SendWait("/");
            Thread.Sleep(rndmc(0005));
            SendKeys.SendWait("warpforge");
            SendKeys.SendWait("{ENTER}");
            Thread.Sleep(rndmc(1200));
            SendKeys.SendWait("9");
            Thread.Sleep(rndmc(0055));
            right5();
            Thread.Sleep(rndmc(0155));
            Cursor.Position = new Point(1069, 393);
            Thread.Sleep(rndmc(0155));
            left5();
            Cursor.Position = new Point(886, 450);
            Thread.Sleep(rndmc(0255));
            left5();
        }

        public void Macro2F()
        {
            macroing2 = false;
            while (true)
            {
                Thread.Sleep((0005));
                if (macro2 == true)
                {
                    macroing2 = false;
                    if ((MouseButtons == MouseButtons.Left) && (m1.Checked))
                    {
                        macroing2 = false;
                        macroing2 = true;
                        if ((macroing2 == true) && (ovrwrit == false))
                        {
                            macroing2 = false;
                            Macro2M();
                            macroing2 = false;
                        }
                        macroing2 = false;
                    }
                    macroing2 = false;
                }
            }
        }

        // MACRO 2 END, MACRO 3 START
        private bool listening4 = false;
        public bool macro3 = false;
        public bool macroing3 = false;

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            if (listening4 == false)
            {
                materialRaisedButton6.Text = "Listening...";
                listening4 = true;
            }
            else
            {
                materialRaisedButton6.Text = "Disable key: NONE";
                listening4 = false;
            }
        }

        public void left6()
        {
            macroing3 = false;
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            Thread.Sleep(rndmc(0));
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            macroing3 = false;
            return;
        }
        
        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            macro3 = !macro3;
            if (announce == true)
            {
                MessageBox.Show("Macro has been set to " + macro3.ToString());
            }
            else
            {
                announce = true;
            }
        }

        public void Macro3M()
        {
            Thread.Sleep(rndmc(0005));
            Cursor.Position = new Point(964, 462);
            Thread.Sleep(rndmc(0155));
            left6();
            Thread.Sleep(rndmc(0155));
            Cursor.Position = new Point(960, 175);
            Thread.Sleep(rndmc(0155));
            left6(); 
            SendKeys.SendWait(numericUpDown4.Value.ToString());
            Thread.Sleep(rndmc(1500));
            Cursor.Position = new Point(960, 531);
            Thread.Sleep(rndmc(0155));
            left6();
            Thread.Sleep(rndmc(0155));
            Cursor.Position = new Point(887, 468);
            Thread.Sleep(rndmc(0155));
            left6();
            Thread.Sleep(rndmc(0155));
            Cursor.Position = new Point(889, 449);
            Thread.Sleep(rndmc(0155));
            left6();
            Thread.Sleep(rndmc(0155));
            Cursor.Position = new Point(960, 540);
            Thread.Sleep(rndmc(0155));
            left6();
        }

        public void Macro3F()
        {
            macroing3 = false;
            while (true)
            {
                Thread.Sleep((0005));
                if (macro3 == true)
                {
                    macroing3 = false;
                    if ((MouseButtons == MouseButtons.Left) && (m1.Checked))
                    {
                        macroing3 = false;
                        macroing3 = true;
                        if ((macroing3 == true) && (ovrwrit == false))
                        {
                            macroing3 = false;
                            Macro3M();
                            macroing3 = false;
                        }
                        macroing3 = false;
                    }
                    macroing3 = false;
                }
            }
        }

        // MACRO 3 END, MACRO 4 START
        private bool listening5 = false;
        public bool macro4 = false;
        public bool macroing4 = false;

        public void left7()
        {
            macroing4 = false;
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            Thread.Sleep(rndmc(0));
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            macroing4 = false;
            return;
        }
        public void right7()
        {
            macroing4 = false;
            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
            Thread.Sleep(rndmc(0));
            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
            macroing4 = false;
            return;
        }

        private void materialCheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            macro4 = !macro4;
            if (announce == true)
            {
                MessageBox.Show("Macro has been set to " + macro4.ToString());
            }
            else
            {
                announce = true;
            }
        }

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {
            if (listening5 == false)
            {
                materialRaisedButton7.Text = "Listening...";
                listening5 = true;
            }
            else
            {
                materialRaisedButton7.Text = "Disable key: NONE";
                listening5 = false;
            }
        }

        public void Macro4M()
        {
            int sticksXcoords = 820;
            SendKeys.SendWait("Q");
            Thread.Sleep(rndmc(0005));
            Cursor.Position = new Point(726, 404);
            Thread.Sleep(rndmc(0155));
            left7();
            Thread.Sleep(rndmc(0005));
            SendKeys.SendWait("stick");
            Thread.Sleep(rndmc(0005));
            Cursor.Position = new Point(sticksXcoords, 450);
            Thread.Sleep(rndmc(0155));
            left7();
            Cursor.Position = new Point(971, 664);
            Thread.Sleep(rndmc(0155));
            left7();
            Cursor.Position = new Point(971, 745);
            Thread.Sleep(rndmc(0155));
            left7();
            Thread.Sleep(rndmc(0005));
            Cursor.Position = new Point(sticksXcoords, 450);
            Thread.Sleep(rndmc(0155));
            right7();
            Thread.Sleep(rndmc(500));
            for (int lol = 1; lol < 450; lol++) { 
                Thread.Sleep(rndmc(0005));
                Cursor.Position = new Point(sticksXcoords, 450);
                Thread.Sleep(rndmc(0005));
                left7();
            }
        }

        public void Macro4F()
        {
            macroing4 = false;
            while (true)
            {
                Thread.Sleep((0005));
                if (macro4 == true)
                {
                    macroing4 = false;
                    if ((MouseButtons == MouseButtons.Left) && (m1.Checked))
                    {
                        macroing4 = false;
                        macroing4 = true;
                        if ((macroing4 == true) && (ovrwrit == false))
                        {
                            macroing4 = false;
                            Macro4M();
                            macroing4 = false;
                        }
                        macroing4 = false;
                    }
                    macroing4 = false;
                }
            }
        }

        // MACRO 4 END, MACRO 5 START

        private bool listening6 = false;
        public bool macro5 = false;
        public bool macroing5 = false;

        public void left8()
        {
            macroing5 = false;
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            Thread.Sleep(rndmc(0));
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            macroing5 = false;
            return;
        }
        public void right8()
        {
            macroing5 = false;
            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
            Thread.Sleep(rndmc(0));
            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
            macroing5 = false;
            return;
        }

        private void macroDisable5_CheckedChanged(object sender, EventArgs e)
        {
            macro5 = !macro5;
            if (announce == true)
            {
                MessageBox.Show("Macro has been set to " + macro5.ToString());
            }
            else
            {
                announce = true;
            }
        }

        private void materialRaisedButton8_Click(object sender, EventArgs e)
        {
            if (listening6 == false)
            {
                materialRaisedButton8.Text = "Listening...";
                listening6 = true;
            }
            else
            {
                materialRaisedButton8.Text = "Disable key: NONE";
                listening6 = false;
            }
        }

        public void Macro5M()
        {
            SendKeys.SendWait("^({RS}+)");
            Thread.Sleep(rndmc(0010));
            SendKeys.SendWait("{ESC}");
        }

        public void Macro5F()
        {
            macroing5 = false;
            while (true)
            {
                Thread.Sleep((0005));
                if (macro5 == true)
                {
                    macroing5 = false;
                    if ((MouseButtons == MouseButtons.Left) && (m1.Checked))
                    {
                        macroing5 = false;
                        macroing5 = true;
                        if ((macroing5 == true) && (ovrwrit == false))
                        {
                            macroing5 = false;
                            Macro5M();
                            macroing5 = false;
                        }
                        macroing5 = false;
                    }
                    macroing5 = false;
                }
            }
        }

        // MACRO 5 END
    }
}
