using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoclicker
{
    partial class UI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Sidebar = new System.Windows.Forms.Panel();
            this.Version = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SettingsOpen = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AutoclickerOpen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.Button();
            this.SidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.AutoclickerTab = new autoclicker.Tabs.Autoclicker();
            this.SettingsTab = new autoclicker.Tabs.Settings();
            this.ColourUpdate = new System.Windows.Forms.Timer(this.components);
            this.Sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Sidebar.Controls.Add(this.Version);
            this.Sidebar.Controls.Add(this.panel1);
            this.Sidebar.Controls.Add(this.flowLayoutPanel1);
            this.Sidebar.Controls.Add(this.panel2);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Padding = new System.Windows.Forms.Padding(3);
            this.Sidebar.Size = new System.Drawing.Size(51, 313);
            this.Sidebar.TabIndex = 0;
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Version.ForeColor = System.Drawing.Color.Plum;
            this.Version.Location = new System.Drawing.Point(15, 290);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(21, 25);
            this.Version.TabIndex = 3;
            this.Version.Text = "v4";
            this.Version.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.SettingsOpen);
            this.panel1.Location = new System.Drawing.Point(-1, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 35);
            this.panel1.TabIndex = 3;
            // 
            // SettingsOpen
            // 
            this.SettingsOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SettingsOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SettingsOpen.FlatAppearance.BorderSize = 0;
            this.SettingsOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SettingsOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SettingsOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsOpen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SettingsOpen.ForeColor = System.Drawing.Color.White;
            this.SettingsOpen.Image = global::autoclicker.Properties.Resources.cog;
            this.SettingsOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsOpen.Location = new System.Drawing.Point(-9, -9);
            this.SettingsOpen.Name = "SettingsOpen";
            this.SettingsOpen.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.SettingsOpen.Size = new System.Drawing.Size(189, 52);
            this.SettingsOpen.TabIndex = 0;
            this.SettingsOpen.TabStop = false;
            this.SettingsOpen.Text = "     Settings";
            this.SettingsOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingsOpen.UseCompatibleTextRendering = true;
            this.SettingsOpen.UseVisualStyleBackColor = false;
            this.SettingsOpen.Click += new System.EventHandler(this.SettingsOpen_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-4, 65);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(174, 223);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel3.Controls.Add(this.AutoclickerOpen);
            this.panel3.Location = new System.Drawing.Point(3, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 35);
            this.panel3.TabIndex = 2;
            // 
            // AutoclickerOpen
            // 
            this.AutoclickerOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.AutoclickerOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoclickerOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.AutoclickerOpen.FlatAppearance.BorderSize = 0;
            this.AutoclickerOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.AutoclickerOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.AutoclickerOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoclickerOpen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AutoclickerOpen.ForeColor = System.Drawing.Color.Plum;
            this.AutoclickerOpen.Image = global::autoclicker.Properties.Resources.mouse;
            this.AutoclickerOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AutoclickerOpen.Location = new System.Drawing.Point(-9, -9);
            this.AutoclickerOpen.Name = "AutoclickerOpen";
            this.AutoclickerOpen.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.AutoclickerOpen.Size = new System.Drawing.Size(189, 52);
            this.AutoclickerOpen.TabIndex = 0;
            this.AutoclickerOpen.TabStop = false;
            this.AutoclickerOpen.Text = "     Clicker";
            this.AutoclickerOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AutoclickerOpen.UseCompatibleTextRendering = true;
            this.AutoclickerOpen.UseVisualStyleBackColor = false;
            this.AutoclickerOpen.Click += new System.EventHandler(this.AutoclickerOpen_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel2.Controls.Add(this.Menu);
            this.panel2.Location = new System.Drawing.Point(-1, 13);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(171, 35);
            this.panel2.TabIndex = 1;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Menu.FlatAppearance.BorderSize = 0;
            this.Menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Menu.Image = global::autoclicker.Properties.Resources.bars;
            this.Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu.Location = new System.Drawing.Point(-9, -9);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.Menu.Size = new System.Drawing.Size(189, 52);
            this.Menu.TabIndex = 0;
            this.Menu.TabStop = false;
            this.Menu.Text = "     Menu";
            this.Menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Menu.UseCompatibleTextRendering = true;
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // SidebarTimer
            // 
            this.SidebarTimer.Interval = 1;
            this.SidebarTimer.Tick += new System.EventHandler(this.SidebarTimer_Tick);
            // 
            // AutoclickerTab
            // 
            this.AutoclickerTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.AutoclickerTab.ForeColor = System.Drawing.Color.White;
            this.AutoclickerTab.Location = new System.Drawing.Point(55, 1);
            this.AutoclickerTab.Name = "AutoclickerTab";
            this.AutoclickerTab.Size = new System.Drawing.Size(399, 312);
            this.AutoclickerTab.TabIndex = 1;
            // 
            // SettingsTab
            // 
            this.SettingsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SettingsTab.ForeColor = System.Drawing.Color.White;
            this.SettingsTab.Location = new System.Drawing.Point(55, 1);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Size = new System.Drawing.Size(399, 312);
            this.SettingsTab.TabIndex = 2;
            // 
            // ColourUpdate
            // 
            this.ColourUpdate.Enabled = true;
            this.ColourUpdate.Interval = 1;
            this.ColourUpdate.Tick += new System.EventHandler(this.ColourUpdate_Tick);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(458, 313);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.AutoclickerTab);
            this.Controls.Add(this.SettingsTab);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UI_FormClosed);
            this.Load += new System.EventHandler(this.UI_Load);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Sidebar;
        private Button Menu;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private Button AutoclickerOpen;
        private System.Windows.Forms.Timer SidebarTimer;
        private Label Version;
        private Tabs.Autoclicker AutoclickerTab;
        private Panel panel1;
        private Button SettingsOpen;
        private Tabs.Settings SettingsTab;
        private Timer ColourUpdate;
    }
}