using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoclicker.Tabs
{
    partial class Autoclicker
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.EnableLMB = new System.Windows.Forms.CheckBox();
            this.EnableMMB = new System.Windows.Forms.CheckBox();
            this.EnableRMB = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ScrollclickKeybind = new System.Windows.Forms.Label();
            this.MulticlickKeybind = new System.Windows.Forms.Label();
            this.AutoclickerKeybind = new System.Windows.Forms.Label();
            this.BlockhitKeybind = new System.Windows.Forms.Label();
            this.HoldclickKeybind = new System.Windows.Forms.Label();
            this.EnableScrollclick = new System.Windows.Forms.CheckBox();
            this.EnableMulticlick = new System.Windows.Forms.CheckBox();
            this.EnableHoldclick = new System.Windows.Forms.CheckBox();
            this.EnableBlockhit = new System.Windows.Forms.CheckBox();
            this.EnableAutoclicker = new System.Windows.Forms.CheckBox();
            this.MulticlickMultiplier = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MaximumValue = new System.Windows.Forms.Label();
            this.MinimumValue = new System.Windows.Forms.Label();
            this.EnableRandomizer = new System.Windows.Forms.CheckBox();
            this.Maximum = new System.Windows.Forms.TrackBar();
            this.Minimum = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SelectSound = new System.Windows.Forms.Button();
            this.EnableClicksounds = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Slot9 = new System.Windows.Forms.CheckBox();
            this.Slot8 = new System.Windows.Forms.CheckBox();
            this.Slot7 = new System.Windows.Forms.CheckBox();
            this.Slot6 = new System.Windows.Forms.CheckBox();
            this.Slot5 = new System.Windows.Forms.CheckBox();
            this.Slot4 = new System.Windows.Forms.CheckBox();
            this.Slot3 = new System.Windows.Forms.CheckBox();
            this.Slot2 = new System.Windows.Forms.CheckBox();
            this.Slot1 = new System.Windows.Forms.CheckBox();
            this.currentSlot = new System.Windows.Forms.Label();
            this.EnableWhitelistedSlots = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EnableDIM = new System.Windows.Forms.CheckBox();
            this.EnableBreakblocks = new System.Windows.Forms.CheckBox();
            this.EnableOIM = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SoundSelector = new System.Windows.Forms.OpenFileDialog();
            this.UpdateSettings = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MulticlickMultiplier)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Maximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimum)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mouse Buttons:";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // EnableLMB
            // 
            this.EnableLMB.AutoSize = true;
            this.EnableLMB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EnableLMB.Location = new System.Drawing.Point(7, 24);
            this.EnableLMB.Name = "EnableLMB";
            this.EnableLMB.Size = new System.Drawing.Size(47, 24);
            this.EnableLMB.TabIndex = 1;
            this.EnableLMB.Text = "Left";
            this.EnableLMB.UseCompatibleTextRendering = true;
            this.EnableLMB.UseVisualStyleBackColor = true;
            // 
            // EnableMMB
            // 
            this.EnableMMB.AutoSize = true;
            this.EnableMMB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EnableMMB.Location = new System.Drawing.Point(7, 49);
            this.EnableMMB.Name = "EnableMMB";
            this.EnableMMB.Size = new System.Drawing.Size(66, 24);
            this.EnableMMB.TabIndex = 2;
            this.EnableMMB.Text = "Middle";
            this.EnableMMB.UseCompatibleTextRendering = true;
            this.EnableMMB.UseVisualStyleBackColor = true;
            // 
            // EnableRMB
            // 
            this.EnableRMB.AutoSize = true;
            this.EnableRMB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EnableRMB.Location = new System.Drawing.Point(7, 75);
            this.EnableRMB.Name = "EnableRMB";
            this.EnableRMB.Size = new System.Drawing.Size(56, 24);
            this.EnableRMB.TabIndex = 3;
            this.EnableRMB.Text = "Right";
            this.EnableRMB.UseCompatibleTextRendering = true;
            this.EnableRMB.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EnableRMB);
            this.panel1.Controls.Add(this.EnableLMB);
            this.panel1.Controls.Add(this.EnableMMB);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(120, 149);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.ScrollclickKeybind);
            this.panel2.Controls.Add(this.MulticlickKeybind);
            this.panel2.Controls.Add(this.AutoclickerKeybind);
            this.panel2.Controls.Add(this.BlockhitKeybind);
            this.panel2.Controls.Add(this.HoldclickKeybind);
            this.panel2.Controls.Add(this.EnableScrollclick);
            this.panel2.Controls.Add(this.EnableMulticlick);
            this.panel2.Controls.Add(this.EnableHoldclick);
            this.panel2.Controls.Add(this.EnableBlockhit);
            this.panel2.Controls.Add(this.EnableAutoclicker);
            this.panel2.Controls.Add(this.MulticlickMultiplier);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(125, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4);
            this.panel2.Size = new System.Drawing.Size(273, 149);
            this.panel2.TabIndex = 5;
            // 
            // ScrollclickKeybind
            // 
            this.ScrollclickKeybind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScrollclickKeybind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ScrollclickKeybind.ForeColor = System.Drawing.Color.DarkGray;
            this.ScrollclickKeybind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ScrollclickKeybind.Location = new System.Drawing.Point(201, 126);
            this.ScrollclickKeybind.Name = "ScrollclickKeybind";
            this.ScrollclickKeybind.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScrollclickKeybind.Size = new System.Drawing.Size(65, 15);
            this.ScrollclickKeybind.TabIndex = 14;
            this.ScrollclickKeybind.Text = "[NONE]";
            this.ScrollclickKeybind.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ScrollclickKeybind.Click += new System.EventHandler(this.ScrollclickKeybind_Click);
            // 
            // MulticlickKeybind
            // 
            this.MulticlickKeybind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MulticlickKeybind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MulticlickKeybind.ForeColor = System.Drawing.Color.DarkGray;
            this.MulticlickKeybind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MulticlickKeybind.Location = new System.Drawing.Point(201, 101);
            this.MulticlickKeybind.Name = "MulticlickKeybind";
            this.MulticlickKeybind.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MulticlickKeybind.Size = new System.Drawing.Size(65, 15);
            this.MulticlickKeybind.TabIndex = 13;
            this.MulticlickKeybind.Text = "[NONE]";
            this.MulticlickKeybind.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.MulticlickKeybind.Click += new System.EventHandler(this.MulticlickKeybind_Click);
            // 
            // AutoclickerKeybind
            // 
            this.AutoclickerKeybind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoclickerKeybind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AutoclickerKeybind.ForeColor = System.Drawing.Color.DarkGray;
            this.AutoclickerKeybind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AutoclickerKeybind.Location = new System.Drawing.Point(201, 76);
            this.AutoclickerKeybind.Name = "AutoclickerKeybind";
            this.AutoclickerKeybind.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AutoclickerKeybind.Size = new System.Drawing.Size(65, 15);
            this.AutoclickerKeybind.TabIndex = 12;
            this.AutoclickerKeybind.Text = "[F6]";
            this.AutoclickerKeybind.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.AutoclickerKeybind.Click += new System.EventHandler(this.AutoclickerKeybind_Click);
            // 
            // BlockhitKeybind
            // 
            this.BlockhitKeybind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BlockhitKeybind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BlockhitKeybind.ForeColor = System.Drawing.Color.DarkGray;
            this.BlockhitKeybind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BlockhitKeybind.Location = new System.Drawing.Point(201, 51);
            this.BlockhitKeybind.Name = "BlockhitKeybind";
            this.BlockhitKeybind.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BlockhitKeybind.Size = new System.Drawing.Size(65, 15);
            this.BlockhitKeybind.TabIndex = 11;
            this.BlockhitKeybind.Text = "[NONE]";
            this.BlockhitKeybind.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BlockhitKeybind.Click += new System.EventHandler(this.BlockhitKeybind_Click);
            // 
            // HoldclickKeybind
            // 
            this.HoldclickKeybind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HoldclickKeybind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HoldclickKeybind.ForeColor = System.Drawing.Color.DarkGray;
            this.HoldclickKeybind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HoldclickKeybind.Location = new System.Drawing.Point(201, 26);
            this.HoldclickKeybind.Name = "HoldclickKeybind";
            this.HoldclickKeybind.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HoldclickKeybind.Size = new System.Drawing.Size(65, 15);
            this.HoldclickKeybind.TabIndex = 10;
            this.HoldclickKeybind.Text = "[NONE]";
            this.HoldclickKeybind.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.HoldclickKeybind.Click += new System.EventHandler(this.HoldclickKeybind_Click);
            // 
            // EnableScrollclick
            // 
            this.EnableScrollclick.AutoSize = true;
            this.EnableScrollclick.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EnableScrollclick.Location = new System.Drawing.Point(4, 124);
            this.EnableScrollclick.Name = "EnableScrollclick";
            this.EnableScrollclick.Size = new System.Drawing.Size(101, 24);
            this.EnableScrollclick.TabIndex = 5;
            this.EnableScrollclick.Text = "Scroll Clicker";
            this.EnableScrollclick.UseCompatibleTextRendering = true;
            this.EnableScrollclick.UseVisualStyleBackColor = true;
            // 
            // EnableMulticlick
            // 
            this.EnableMulticlick.AutoSize = true;
            this.EnableMulticlick.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EnableMulticlick.Location = new System.Drawing.Point(4, 99);
            this.EnableMulticlick.Name = "EnableMulticlick";
            this.EnableMulticlick.Size = new System.Drawing.Size(87, 24);
            this.EnableMulticlick.TabIndex = 4;
            this.EnableMulticlick.Text = "Multi Click";
            this.EnableMulticlick.UseCompatibleTextRendering = true;
            this.EnableMulticlick.UseVisualStyleBackColor = true;
            // 
            // EnableHoldclick
            // 
            this.EnableHoldclick.AutoSize = true;
            this.EnableHoldclick.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EnableHoldclick.Location = new System.Drawing.Point(4, 24);
            this.EnableHoldclick.Name = "EnableHoldclick";
            this.EnableHoldclick.Size = new System.Drawing.Size(97, 24);
            this.EnableHoldclick.TabIndex = 6;
            this.EnableHoldclick.Text = "Hold Clicker";
            this.EnableHoldclick.UseCompatibleTextRendering = true;
            this.EnableHoldclick.UseVisualStyleBackColor = true;
            // 
            // EnableBlockhit
            // 
            this.EnableBlockhit.AutoSize = true;
            this.EnableBlockhit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EnableBlockhit.Location = new System.Drawing.Point(4, 49);
            this.EnableBlockhit.Name = "EnableBlockhit";
            this.EnableBlockhit.Size = new System.Drawing.Size(72, 24);
            this.EnableBlockhit.TabIndex = 7;
            this.EnableBlockhit.Text = "Blockhit";
            this.EnableBlockhit.UseCompatibleTextRendering = true;
            this.EnableBlockhit.UseVisualStyleBackColor = true;
            // 
            // EnableAutoclicker
            // 
            this.EnableAutoclicker.AutoSize = true;
            this.EnableAutoclicker.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EnableAutoclicker.Location = new System.Drawing.Point(4, 74);
            this.EnableAutoclicker.Name = "EnableAutoclicker";
            this.EnableAutoclicker.Size = new System.Drawing.Size(91, 24);
            this.EnableAutoclicker.TabIndex = 9;
            this.EnableAutoclicker.Text = "Autoclicker";
            this.EnableAutoclicker.UseCompatibleTextRendering = true;
            this.EnableAutoclicker.UseVisualStyleBackColor = true;
            // 
            // MulticlickMultiplier
            // 
            this.MulticlickMultiplier.Location = new System.Drawing.Point(85, 99);
            this.MulticlickMultiplier.Minimum = 2;
            this.MulticlickMultiplier.Name = "MulticlickMultiplier";
            this.MulticlickMultiplier.Size = new System.Drawing.Size(89, 45);
            this.MulticlickMultiplier.TabIndex = 8;
            this.MulticlickMultiplier.TickStyle = System.Windows.Forms.TickStyle.None;
            this.MulticlickMultiplier.Value = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modes:";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.MaximumValue);
            this.panel4.Controls.Add(this.MinimumValue);
            this.panel4.Controls.Add(this.EnableRandomizer);
            this.panel4.Controls.Add(this.Maximum);
            this.panel4.Controls.Add(this.Minimum);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(0, 154);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 76);
            this.panel4.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.Location = new System.Drawing.Point(1, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Maximum:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(3, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Minimum:";
            // 
            // MaximumValue
            // 
            this.MaximumValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MaximumValue.Location = new System.Drawing.Point(72, 52);
            this.MaximumValue.Name = "MaximumValue";
            this.MaximumValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MaximumValue.Size = new System.Drawing.Size(33, 16);
            this.MaximumValue.TabIndex = 14;
            this.MaximumValue.Text = "0";
            // 
            // MinimumValue
            // 
            this.MinimumValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumValue.Location = new System.Drawing.Point(72, 25);
            this.MinimumValue.Name = "MinimumValue";
            this.MinimumValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MinimumValue.Size = new System.Drawing.Size(33, 16);
            this.MinimumValue.TabIndex = 13;
            this.MinimumValue.Text = "0";
            // 
            // EnableRandomizer
            // 
            this.EnableRandomizer.AutoSize = true;
            this.EnableRandomizer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EnableRandomizer.Location = new System.Drawing.Point(135, 4);
            this.EnableRandomizer.Name = "EnableRandomizer";
            this.EnableRandomizer.Size = new System.Drawing.Size(64, 24);
            this.EnableRandomizer.TabIndex = 10;
            this.EnableRandomizer.Text = "Enable";
            this.EnableRandomizer.UseCompatibleTextRendering = true;
            this.EnableRandomizer.UseVisualStyleBackColor = true;
            // 
            // Maximum
            // 
            this.Maximum.LargeChange = 50;
            this.Maximum.Location = new System.Drawing.Point(98, 52);
            this.Maximum.Maximum = 500;
            this.Maximum.Name = "Maximum";
            this.Maximum.Size = new System.Drawing.Size(101, 45);
            this.Maximum.SmallChange = 5;
            this.Maximum.TabIndex = 10;
            this.Maximum.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Maximum.ValueChanged += new System.EventHandler(this.Maximum_ValueChanged);
            // 
            // Minimum
            // 
            this.Minimum.LargeChange = 50;
            this.Minimum.Location = new System.Drawing.Point(98, 25);
            this.Minimum.Maximum = 500;
            this.Minimum.Name = "Minimum";
            this.Minimum.Size = new System.Drawing.Size(101, 45);
            this.Minimum.SmallChange = 5;
            this.Minimum.TabIndex = 9;
            this.Minimum.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Minimum.ValueChanged += new System.EventHandler(this.Minimum_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Randomizer (ms):";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel5.Controls.Add(this.SelectSound);
            this.panel5.Controls.Add(this.EnableClicksounds);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(0, 236);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 76);
            this.panel5.TabIndex = 7;
            // 
            // SelectSound
            // 
            this.SelectSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SelectSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectSound.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SelectSound.FlatAppearance.BorderSize = 0;
            this.SelectSound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SelectSound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SelectSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectSound.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.SelectSound.Image = global::autoclicker.Properties.Resources.music;
            this.SelectSound.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SelectSound.Location = new System.Drawing.Point(14, 29);
            this.SelectSound.Name = "SelectSound";
            this.SelectSound.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.SelectSound.Size = new System.Drawing.Size(169, 36);
            this.SelectSound.TabIndex = 12;
            this.SelectSound.TabStop = false;
            this.SelectSound.Text = " Nothing selected";
            this.SelectSound.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SelectSound.UseCompatibleTextRendering = true;
            this.SelectSound.UseVisualStyleBackColor = false;
            this.SelectSound.Click += new System.EventHandler(this.SelectSound_Click);
            // 
            // EnableClicksounds
            // 
            this.EnableClicksounds.AutoSize = true;
            this.EnableClicksounds.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EnableClicksounds.Location = new System.Drawing.Point(135, 4);
            this.EnableClicksounds.Name = "EnableClicksounds";
            this.EnableClicksounds.Size = new System.Drawing.Size(64, 24);
            this.EnableClicksounds.TabIndex = 11;
            this.EnableClicksounds.Text = "Enable";
            this.EnableClicksounds.UseCompatibleTextRendering = true;
            this.EnableClicksounds.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Click sounds:";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel6.Controls.Add(this.Slot9);
            this.panel6.Controls.Add(this.Slot8);
            this.panel6.Controls.Add(this.Slot7);
            this.panel6.Controls.Add(this.Slot6);
            this.panel6.Controls.Add(this.Slot5);
            this.panel6.Controls.Add(this.Slot4);
            this.panel6.Controls.Add(this.Slot3);
            this.panel6.Controls.Add(this.Slot2);
            this.panel6.Controls.Add(this.Slot1);
            this.panel6.Controls.Add(this.currentSlot);
            this.panel6.Controls.Add(this.EnableWhitelistedSlots);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.EnableDIM);
            this.panel6.Controls.Add(this.EnableBreakblocks);
            this.panel6.Controls.Add(this.EnableOIM);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(201, 154);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 158);
            this.panel6.TabIndex = 8;
            // 
            // Slot9
            // 
            this.Slot9.AutoSize = true;
            this.Slot9.Checked = true;
            this.Slot9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Slot9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Slot9.Location = new System.Drawing.Point(175, 122);
            this.Slot9.Name = "Slot9";
            this.Slot9.Size = new System.Drawing.Size(15, 14);
            this.Slot9.TabIndex = 23;
            this.Slot9.UseCompatibleTextRendering = true;
            this.Slot9.UseVisualStyleBackColor = true;
            // 
            // Slot8
            // 
            this.Slot8.AutoSize = true;
            this.Slot8.Checked = true;
            this.Slot8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Slot8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Slot8.Location = new System.Drawing.Point(154, 122);
            this.Slot8.Name = "Slot8";
            this.Slot8.Size = new System.Drawing.Size(15, 14);
            this.Slot8.TabIndex = 22;
            this.Slot8.UseCompatibleTextRendering = true;
            this.Slot8.UseVisualStyleBackColor = true;
            // 
            // Slot7
            // 
            this.Slot7.AutoSize = true;
            this.Slot7.Checked = true;
            this.Slot7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Slot7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Slot7.Location = new System.Drawing.Point(133, 122);
            this.Slot7.Name = "Slot7";
            this.Slot7.Size = new System.Drawing.Size(15, 14);
            this.Slot7.TabIndex = 21;
            this.Slot7.UseCompatibleTextRendering = true;
            this.Slot7.UseVisualStyleBackColor = true;
            // 
            // Slot6
            // 
            this.Slot6.AutoSize = true;
            this.Slot6.Checked = true;
            this.Slot6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Slot6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Slot6.Location = new System.Drawing.Point(112, 122);
            this.Slot6.Name = "Slot6";
            this.Slot6.Size = new System.Drawing.Size(15, 14);
            this.Slot6.TabIndex = 20;
            this.Slot6.UseCompatibleTextRendering = true;
            this.Slot6.UseVisualStyleBackColor = true;
            // 
            // Slot5
            // 
            this.Slot5.AutoSize = true;
            this.Slot5.Checked = true;
            this.Slot5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Slot5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Slot5.Location = new System.Drawing.Point(91, 122);
            this.Slot5.Name = "Slot5";
            this.Slot5.Size = new System.Drawing.Size(15, 14);
            this.Slot5.TabIndex = 19;
            this.Slot5.UseCompatibleTextRendering = true;
            this.Slot5.UseVisualStyleBackColor = true;
            // 
            // Slot4
            // 
            this.Slot4.AutoSize = true;
            this.Slot4.Checked = true;
            this.Slot4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Slot4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Slot4.Location = new System.Drawing.Point(70, 122);
            this.Slot4.Name = "Slot4";
            this.Slot4.Size = new System.Drawing.Size(15, 14);
            this.Slot4.TabIndex = 18;
            this.Slot4.UseCompatibleTextRendering = true;
            this.Slot4.UseVisualStyleBackColor = true;
            // 
            // Slot3
            // 
            this.Slot3.AutoSize = true;
            this.Slot3.Checked = true;
            this.Slot3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Slot3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Slot3.Location = new System.Drawing.Point(49, 122);
            this.Slot3.Name = "Slot3";
            this.Slot3.Size = new System.Drawing.Size(15, 14);
            this.Slot3.TabIndex = 17;
            this.Slot3.UseCompatibleTextRendering = true;
            this.Slot3.UseVisualStyleBackColor = true;
            // 
            // Slot2
            // 
            this.Slot2.AutoSize = true;
            this.Slot2.Checked = true;
            this.Slot2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Slot2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Slot2.Location = new System.Drawing.Point(28, 122);
            this.Slot2.Name = "Slot2";
            this.Slot2.Size = new System.Drawing.Size(15, 14);
            this.Slot2.TabIndex = 16;
            this.Slot2.UseCompatibleTextRendering = true;
            this.Slot2.UseVisualStyleBackColor = true;
            // 
            // Slot1
            // 
            this.Slot1.AutoSize = true;
            this.Slot1.Checked = true;
            this.Slot1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Slot1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Slot1.Location = new System.Drawing.Point(7, 122);
            this.Slot1.Name = "Slot1";
            this.Slot1.Size = new System.Drawing.Size(15, 14);
            this.Slot1.TabIndex = 15;
            this.Slot1.UseCompatibleTextRendering = true;
            this.Slot1.UseVisualStyleBackColor = true;
            // 
            // currentSlot
            // 
            this.currentSlot.AutoSize = true;
            this.currentSlot.ForeColor = System.Drawing.Color.DarkGray;
            this.currentSlot.Location = new System.Drawing.Point(6, 140);
            this.currentSlot.Name = "currentSlot";
            this.currentSlot.Size = new System.Drawing.Size(112, 13);
            this.currentSlot.TabIndex = 14;
            this.currentSlot.Text = "Current slot: Unknown";
            // 
            // EnableWhitelistedSlots
            // 
            this.EnableWhitelistedSlots.AutoSize = true;
            this.EnableWhitelistedSlots.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EnableWhitelistedSlots.Location = new System.Drawing.Point(135, 97);
            this.EnableWhitelistedSlots.Name = "EnableWhitelistedSlots";
            this.EnableWhitelistedSlots.Size = new System.Drawing.Size(64, 24);
            this.EnableWhitelistedSlots.TabIndex = 13;
            this.EnableWhitelistedSlots.Text = "Enable";
            this.EnableWhitelistedSlots.UseCompatibleTextRendering = true;
            this.EnableWhitelistedSlots.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label3.Location = new System.Drawing.Point(4, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Whitelist slots:";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // EnableDIM
            // 
            this.EnableDIM.AutoSize = true;
            this.EnableDIM.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EnableDIM.Location = new System.Drawing.Point(7, 73);
            this.EnableDIM.Name = "EnableDIM";
            this.EnableDIM.Size = new System.Drawing.Size(121, 24);
            this.EnableDIM.TabIndex = 8;
            this.EnableDIM.Text = "Disable in menu";
            this.EnableDIM.UseCompatibleTextRendering = true;
            this.EnableDIM.UseVisualStyleBackColor = true;
            // 
            // EnableBreakblocks
            // 
            this.EnableBreakblocks.AutoSize = true;
            this.EnableBreakblocks.Enabled = false;
            this.EnableBreakblocks.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EnableBreakblocks.Location = new System.Drawing.Point(7, 48);
            this.EnableBreakblocks.Name = "EnableBreakblocks";
            this.EnableBreakblocks.Size = new System.Drawing.Size(100, 24);
            this.EnableBreakblocks.TabIndex = 7;
            this.EnableBreakblocks.Text = "Break blocks";
            this.EnableBreakblocks.UseCompatibleTextRendering = true;
            this.EnableBreakblocks.UseVisualStyleBackColor = true;
            // 
            // EnableOIM
            // 
            this.EnableOIM.AutoSize = true;
            this.EnableOIM.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EnableOIM.Location = new System.Drawing.Point(7, 24);
            this.EnableOIM.Name = "EnableOIM";
            this.EnableOIM.Size = new System.Drawing.Size(128, 24);
            this.EnableOIM.TabIndex = 6;
            this.EnableOIM.Text = "Only in Minecraft";
            this.EnableOIM.UseCompatibleTextRendering = true;
            this.EnableOIM.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Other:";
            this.label6.UseCompatibleTextRendering = true;
            // 
            // SoundSelector
            // 
            this.SoundSelector.Filter = "Sound files|*.wav";
            // 
            // UpdateSettings
            // 
            this.UpdateSettings.Enabled = true;
            this.UpdateSettings.Tick += new System.EventHandler(this.UpdateSettings_Tick);
            // 
            // Autoclicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Autoclicker";
            this.Size = new System.Drawing.Size(399, 312);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MulticlickMultiplier)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Maximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimum)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private CheckBox EnableLMB;
        private CheckBox EnableMMB;
        private CheckBox EnableRMB;
        private Panel panel1;
        private Panel panel2;
        private CheckBox EnableBlockhit;
        private CheckBox EnableHoldclick;
        private CheckBox EnableScrollclick;
        private TrackBar MulticlickMultiplier;
        private Label label2;
        private CheckBox EnableMulticlick;
        private CheckBox EnableAutoclicker;
        private Panel panel4;
        private Label label4;
        private Panel panel5;
        private Label label5;
        private Panel panel6;
        private Label label6;
        private Label MaximumValue;
        private Label MinimumValue;
        private CheckBox EnableRandomizer;
        private Label label8;
        private Label label7;
        private TrackBar Maximum;
        private TrackBar Minimum;
        private CheckBox EnableClicksounds;
        private OpenFileDialog SoundSelector;
        private Button SelectSound;
        private Timer UpdateSettings;
        private CheckBox EnableBreakblocks;
        private CheckBox EnableOIM;
        private CheckBox EnableDIM;
        private Label ScrollclickKeybind;
        private Label MulticlickKeybind;
        private Label AutoclickerKeybind;
        private Label BlockhitKeybind;
        private Label HoldclickKeybind;
        private Label currentSlot;
        private CheckBox EnableWhitelistedSlots;
        private Label label3;
        private CheckBox Slot9;
        private CheckBox Slot8;
        private CheckBox Slot7;
        private CheckBox Slot6;
        private CheckBox Slot5;
        private CheckBox Slot4;
        private CheckBox Slot3;
        private CheckBox Slot2;
        private CheckBox Slot1;
    }
}
