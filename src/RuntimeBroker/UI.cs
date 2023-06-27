using autoclicker.Core;
using autoclicker.Core.Hooks;
using autoclicker.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace autoclicker
{
    public partial class UI : Form
    {
        public static Clicker clicker = new Clicker();

        public UI()
        {
            InitializeComponent();
        }

        #region Sidebar Handler

        private bool Sidebar_Grow = true;

        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            int factor = 10;
            if (Sidebar_Grow)
            {
                Sidebar.Width += factor;
                if (Sidebar.Width >= 170)
                    SidebarTimer.Stop();
            }
            else
            {
                Sidebar.Width -= factor;
                if (Sidebar.Width == 51)
                    SidebarTimer.Stop();
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            if (!SidebarTimer.Enabled)
            {
                Sidebar_Grow = (Sidebar.Width == 51) ? true : false;
                SidebarTimer.Start();
            }
        }

        #endregion

        private void UI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill(); // just to be sure, you never know
        }

        #region Tabs handler

        public static Color colour = Color.Plum;

        public static Image recolour(Image image)
        {
            Bitmap coloredImage = new Bitmap(image.Width, image.Height);
            using (Graphics graphics = Graphics.FromImage(coloredImage))
            {
                ColorMatrix colorMatrix = new ColorMatrix(new float[][] { new float[] { colour.R / 255.0f, 0, 0, 0, 0 }, new float[] { 0, colour.G / 255.0f, 0, 0, 0 }, new float[] { 0, 0, colour.B / 255.0f, 0, 0 }, new float[] { 0, 0, 0, 1, 0 }, new float[] { 0, 0, 0, 0, 1 } });
                ImageAttributes imageAttributes = new ImageAttributes();
                imageAttributes.SetColorMatrix(colorMatrix);
                graphics.DrawImage(image, new Rectangle(0, 0, coloredImage.Width, coloredImage.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            }
            return coloredImage;
        }

        private Button selected;
        private void AutoclickerOpen_Click(object sender, EventArgs e)
        {
            selected = AutoclickerOpen;
        }

        private void SettingsOpen_Click(object sender, EventArgs e)
        {
            selected = SettingsOpen;
        }

        private void UI_Load(object sender, EventArgs e)
        {
            selected = AutoclickerOpen;
        }

        private void ColourUpdate_Tick(object sender, EventArgs e)
        {
            if (selected != null)
            {
                Version.ForeColor = colour;
                AutoclickerOpen.ForeColor = Color.White;
                AutoclickerOpen.Image = Resources.mouse;
                SettingsOpen.ForeColor = Color.White;
                SettingsOpen.Image = Resources.cog;
                selected.ForeColor = colour;
                switch (selected.Name)
                {
                    case "AutoclickerOpen":
                        selected.Image = recolour(Resources.mouse);
                        SettingsTab.SendToBack();
                        break;
                    case "SettingsOpen":
                        selected.Image = recolour(Resources.cog);
                        AutoclickerTab.SendToBack();
                        break;
                }
            }
        }

        #endregion
    }
}