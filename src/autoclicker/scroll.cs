using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoclicker
{
    public partial class scroll : Form
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public static implicit operator Point(POINT point)
            {
                return new Point(point.X, point.Y);
            }
        }

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);

        public static Point GetCursorPosition()
        {
            POINT lpPoint;
            GetCursorPos(out lpPoint);
            return lpPoint;
        }

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);

        [DllImport("user32.dll")]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        public scroll()
        {
            InitializeComponent();
            uint initialStyle = (uint)GetWindowLong(this.Handle, -20);
            //SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);
        }

        private void scroll_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        public void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point position = GetCursorPosition();
            int pX = position.X;
            int pY = position.Y;

            this.Location = new Point(pX-8, pY-20);
        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            //MessageBox.Show("ez");
            ///*
            this.Hide();
            int ez = 0;
            if ((MouseButtons == MouseButtons.Left) && (ez == 0))
            {
                ez = 1;
                Program.ez.left2();
                ez = 0;
            }
            if ((MouseButtons == MouseButtons.Right) && (ez == 0))
            {
                ez = 1;
                Program.ez.right2();
                ez = 0;
            }
            if ((MouseButtons == MouseButtons.Middle) && (ez == 0))
            {
                ez = 1;
                Program.ez.mid2();
                ez = 0;
            }
            Thread.Sleep(Program.ez.rndmc(1));
            if (Program.ez.scrollclicc)
            {
                if ((MouseButtons == MouseButtons.Left) && (Program.ez.m1.Checked))
                {
                    Program.ez.clickin = true;
                    Thread.Sleep(Program.ez.rndmc(0005));
                    while (MouseButtons == MouseButtons.Left)
                    {
                        if ((Program.ez.clickin == true) && (Program.ez.ovrwrit == false))
                        {
                            Program.ez.left2();
                            this.Hide();
                            Thread.Sleep(Program.ez.rndmc(0002));
                            Program.ez.clickin = true;
                        }
                    }
                }
                if ((MouseButtons == MouseButtons.Right) && (Program.ez.m2.Checked))
                {
                    Program.ez.clickin = true;
                    Thread.Sleep(Program.ez.rndmc(0005));
                    while (MouseButtons == MouseButtons.Right)
                    {
                        if ((Program.ez.clickin == true) && (Program.ez.ovrwrit == false))
                        {
                            Program.ez.right2();
                            this.Hide();
                            Thread.Sleep(Program.ez.rndmc(0002));
                            Program.ez.clickin = true;
                        }
                    }
                }
                if ((MouseButtons == MouseButtons.Middle) && (Program.ez.m3.Checked))
                {
                    Program.ez.clickin = true;
                    Thread.Sleep(Program.ez.rndmc(0005));
                    while (MouseButtons == MouseButtons.Middle)
                    {
                        if ((Program.ez.clickin == true) && (Program.ez.ovrwrit == false))
                        {
                            Program.ez.mid2();
                            this.Hide();
                            Thread.Sleep(Program.ez.rndmc(0002));
                            Program.ez.clickin = true;
                        }
                    }
                }
            }//*/
            this.Hide();
            Thread.Sleep(Program.ez.rndmc(100));
            this.Show();
        }
    }
}
