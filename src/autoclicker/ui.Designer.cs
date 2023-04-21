namespace autoclicker
{
    partial class ui
    {

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ui));
            this.random = new MaterialSkin.Controls.MaterialCheckBox();
            this.tm = new MaterialSkin.Controls.MaterialCheckBox();
            this.credits = new MaterialSkin.Controls.MaterialLabel();
            this.overwrite = new MaterialSkin.Controls.MaterialCheckBox();
            this.dc = new MaterialSkin.Controls.MaterialCheckBox();
            this.hd = new MaterialSkin.Controls.MaterialCheckBox();
            this.sped = new System.Windows.Forms.NumericUpDown();
            this.m1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.m2 = new MaterialSkin.Controls.MaterialCheckBox();
            this.autoclick = new MaterialSkin.Controls.MaterialRaisedButton();
            this.intv = new MaterialSkin.Controls.MaterialLabel();
            this.milx = new System.Windows.Forms.NumericUpDown();
            this.m3 = new MaterialSkin.Controls.MaterialCheckBox();
            this.min = new System.Windows.Forms.NumericUpDown();
            this.max = new System.Windows.Forms.NumericUpDown();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.blockhit = new MaterialSkin.Controls.MaterialCheckBox();
            this.pages = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bypass1 = new System.Windows.Forms.ComboBox();
            this.clic = new System.Windows.Forms.Panel();
            this.mice = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.experimental = new MaterialSkin.Controls.MaterialLabel();
            this.holdclick = new MaterialSkin.Controls.MaterialCheckBox();
            this.selector = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton7 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.materialRaisedButton6 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.macroDisable3 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialRaisedButton5 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.macroDisable2 = new MaterialSkin.Controls.MaterialCheckBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.macroDisable1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.Settings = new System.Windows.Forms.TabPage();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton8 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.macroDisable5 = new MaterialSkin.Controls.MaterialCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.sped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max)).BeginInit();
            this.pages.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.clic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mice)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // random
            // 
            this.random.AutoSize = true;
            this.random.Depth = 0;
            this.random.Font = new System.Drawing.Font("Roboto", 10F);
            this.random.Location = new System.Drawing.Point(143, 25);
            this.random.Margin = new System.Windows.Forms.Padding(0);
            this.random.MouseLocation = new System.Drawing.Point(-1, -1);
            this.random.MouseState = MaterialSkin.MouseState.HOVER;
            this.random.Name = "random";
            this.random.Ripple = true;
            this.random.Size = new System.Drawing.Size(150, 30);
            this.random.TabIndex = 0;
            this.random.Text = "random click speed";
            this.random.UseVisualStyleBackColor = true;
            this.random.CheckedChanged += new System.EventHandler(this.random_CheckedChanged);
            // 
            // tm
            // 
            this.tm.AutoSize = true;
            this.tm.Checked = true;
            this.tm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tm.Depth = 0;
            this.tm.Font = new System.Drawing.Font("Roboto", 10F);
            this.tm.Location = new System.Drawing.Point(163, 31);
            this.tm.Margin = new System.Windows.Forms.Padding(0);
            this.tm.MouseLocation = new System.Drawing.Point(-1, -1);
            this.tm.MouseState = MaterialSkin.MouseState.HOVER;
            this.tm.Name = "tm";
            this.tm.Ripple = true;
            this.tm.Size = new System.Drawing.Size(85, 30);
            this.tm.TabIndex = 6;
            this.tm.Text = "Topmost";
            this.tm.UseVisualStyleBackColor = true;
            this.tm.CheckedChanged += new System.EventHandler(this.tm_CheckedChanged);
            this.tm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ui_MouseMove);
            // 
            // credits
            // 
            this.credits.AutoSize = true;
            this.credits.Depth = 0;
            this.credits.Font = new System.Drawing.Font("Roboto", 11F);
            this.credits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.credits.Location = new System.Drawing.Point(28, 135);
            this.credits.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.credits.MouseState = MaterialSkin.MouseState.HOVER;
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(0, 19);
            this.credits.TabIndex = 1;
            this.credits.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ui_MouseMove);
            // 
            // overwrite
            // 
            this.overwrite.AutoSize = true;
            this.overwrite.Depth = 0;
            this.overwrite.Font = new System.Drawing.Font("Roboto", 10F);
            this.overwrite.Location = new System.Drawing.Point(143, 2);
            this.overwrite.Margin = new System.Windows.Forms.Padding(0);
            this.overwrite.MouseLocation = new System.Drawing.Point(-1, -1);
            this.overwrite.MouseState = MaterialSkin.MouseState.HOVER;
            this.overwrite.Name = "overwrite";
            this.overwrite.Ripple = true;
            this.overwrite.Size = new System.Drawing.Size(119, 30);
            this.overwrite.TabIndex = 5;
            this.overwrite.Text = "disable clicker";
            this.overwrite.UseVisualStyleBackColor = true;
            this.overwrite.CheckedChanged += new System.EventHandler(this.overwrite_CheckedChanged);
            this.overwrite.Click += new System.EventHandler(this.overwrite_Click);
            // 
            // dc
            // 
            this.dc.AutoSize = true;
            this.dc.Depth = 0;
            this.dc.Font = new System.Drawing.Font("Roboto", 10F);
            this.dc.Location = new System.Drawing.Point(7, 0);
            this.dc.Margin = new System.Windows.Forms.Padding(0);
            this.dc.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dc.MouseState = MaterialSkin.MouseState.HOVER;
            this.dc.Name = "dc";
            this.dc.Ripple = true;
            this.dc.Size = new System.Drawing.Size(104, 30);
            this.dc.TabIndex = 6;
            this.dc.Text = "double click";
            this.dc.UseVisualStyleBackColor = true;
            this.dc.CheckedChanged += new System.EventHandler(this.dc_CheckedChanged);
            // 
            // hd
            // 
            this.hd.AutoSize = true;
            this.hd.Depth = 0;
            this.hd.Font = new System.Drawing.Font("Roboto", 10F);
            this.hd.Location = new System.Drawing.Point(7, 29);
            this.hd.Margin = new System.Windows.Forms.Padding(0);
            this.hd.MouseLocation = new System.Drawing.Point(-1, -1);
            this.hd.MouseState = MaterialSkin.MouseState.HOVER;
            this.hd.Name = "hd";
            this.hd.Ripple = true;
            this.hd.Size = new System.Drawing.Size(108, 30);
            this.hd.TabIndex = 7;
            this.hd.Text = "custom click";
            this.hd.UseVisualStyleBackColor = true;
            this.hd.CheckedChanged += new System.EventHandler(this.hd_CheckedChanged);
            // 
            // sped
            // 
            this.sped.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.sped.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sped.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sped.ForeColor = System.Drawing.Color.White;
            this.sped.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sped.Location = new System.Drawing.Point(120, 34);
            this.sped.Name = "sped";
            this.sped.Size = new System.Drawing.Size(87, 19);
            this.sped.TabIndex = 8;
            this.sped.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sped.ValueChanged += new System.EventHandler(this.sped_ValueChanged);
            // 
            // m1
            // 
            this.m1.AutoSize = true;
            this.m1.Checked = true;
            this.m1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m1.Depth = 0;
            this.m1.Font = new System.Drawing.Font("Roboto", 10F);
            this.m1.Location = new System.Drawing.Point(0, 0);
            this.m1.Margin = new System.Windows.Forms.Padding(0);
            this.m1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.m1.MouseState = MaterialSkin.MouseState.HOVER;
            this.m1.Name = "m1";
            this.m1.Ripple = true;
            this.m1.Size = new System.Drawing.Size(26, 30);
            this.m1.TabIndex = 10;
            this.m1.UseVisualStyleBackColor = true;
            // 
            // m2
            // 
            this.m2.AutoSize = true;
            this.m2.Depth = 0;
            this.m2.Font = new System.Drawing.Font("Roboto", 10F);
            this.m2.Location = new System.Drawing.Point(66, 0);
            this.m2.Margin = new System.Windows.Forms.Padding(0);
            this.m2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.m2.MouseState = MaterialSkin.MouseState.HOVER;
            this.m2.Name = "m2";
            this.m2.Ripple = true;
            this.m2.Size = new System.Drawing.Size(26, 30);
            this.m2.TabIndex = 11;
            this.m2.UseVisualStyleBackColor = true;
            // 
            // autoclick
            // 
            this.autoclick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.autoclick.Depth = 0;
            this.autoclick.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.autoclick.FlatAppearance.BorderSize = 0;
            this.autoclick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoclick.Font = new System.Drawing.Font("Arial", 10.2F);
            this.autoclick.Location = new System.Drawing.Point(212, 173);
            this.autoclick.MouseState = MaterialSkin.MouseState.HOVER;
            this.autoclick.Name = "autoclick";
            this.autoclick.Primary = true;
            this.autoclick.Size = new System.Drawing.Size(138, 20);
            this.autoclick.TabIndex = 12;
            this.autoclick.Text = "start";
            this.autoclick.UseVisualStyleBackColor = false;
            this.autoclick.Click += new System.EventHandler(this.autoclick_Click);
            // 
            // intv
            // 
            this.intv.AutoSize = true;
            this.intv.Depth = 0;
            this.intv.Font = new System.Drawing.Font("Roboto", 11F);
            this.intv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.intv.Location = new System.Drawing.Point(6, 173);
            this.intv.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.intv.MouseState = MaterialSkin.MouseState.HOVER;
            this.intv.Name = "intv";
            this.intv.Size = new System.Drawing.Size(62, 19);
            this.intv.TabIndex = 13;
            this.intv.Text = "interval:";
            this.intv.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ui_MouseMove);
            // 
            // milx
            // 
            this.milx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.milx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.milx.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milx.ForeColor = System.Drawing.Color.White;
            this.milx.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.milx.Location = new System.Drawing.Point(67, 174);
            this.milx.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.milx.Name = "milx";
            this.milx.Size = new System.Drawing.Size(140, 19);
            this.milx.TabIndex = 18;
            this.milx.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // m3
            // 
            this.m3.AutoSize = true;
            this.m3.Depth = 0;
            this.m3.Font = new System.Drawing.Font("Roboto", 10F);
            this.m3.Location = new System.Drawing.Point(33, 0);
            this.m3.Margin = new System.Windows.Forms.Padding(0);
            this.m3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.m3.MouseState = MaterialSkin.MouseState.HOVER;
            this.m3.Name = "m3";
            this.m3.Ripple = true;
            this.m3.Size = new System.Drawing.Size(26, 30);
            this.m3.TabIndex = 20;
            this.m3.UseVisualStyleBackColor = true;
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.min.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.min.ForeColor = System.Drawing.Color.White;
            this.min.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.min.Location = new System.Drawing.Point(173, 57);
            this.min.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.min.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(59, 19);
            this.min.TabIndex = 21;
            this.min.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.min.ValueChanged += new System.EventHandler(this.min_ValueChanged);
            // 
            // max
            // 
            this.max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.max.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.max.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.max.ForeColor = System.Drawing.Color.White;
            this.max.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.max.Location = new System.Drawing.Point(278, 57);
            this.max.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.max.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(55, 19);
            this.max.TabIndex = 22;
            this.max.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(135, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(236, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "max";
            // 
            // blockhit
            // 
            this.blockhit.AutoSize = true;
            this.blockhit.Depth = 0;
            this.blockhit.Font = new System.Drawing.Font("Roboto", 10F);
            this.blockhit.Location = new System.Drawing.Point(7, 107);
            this.blockhit.Margin = new System.Windows.Forms.Padding(0);
            this.blockhit.MouseLocation = new System.Drawing.Point(-1, -1);
            this.blockhit.MouseState = MaterialSkin.MouseState.HOVER;
            this.blockhit.Name = "blockhit";
            this.blockhit.Ripple = true;
            this.blockhit.Size = new System.Drawing.Size(82, 30);
            this.blockhit.TabIndex = 25;
            this.blockhit.Text = "block hit";
            this.blockhit.UseVisualStyleBackColor = true;
            this.blockhit.CheckedChanged += new System.EventHandler(this.blockhit_CheckedChanged);
            // 
            // pages
            // 
            this.pages.Controls.Add(this.tabPage1);
            this.pages.Controls.Add(this.tabPage2);
            this.pages.Depth = 0;
            this.pages.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pages.Location = new System.Drawing.Point(0, 23);
            this.pages.MouseState = MaterialSkin.MouseState.HOVER;
            this.pages.Name = "pages";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(354, 149);
            this.pages.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage1.Controls.Add(this.materialRaisedButton2);
            this.tabPage1.Controls.Add(this.bypass1);
            this.tabPage1.Controls.Add(this.clic);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.random);
            this.tabPage1.Controls.Add(this.max);
            this.tabPage1.Controls.Add(this.overwrite);
            this.tabPage1.Controls.Add(this.min);
            this.tabPage1.Controls.Add(this.mice);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(346, 121);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(112, 115);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(239, 33);
            this.materialRaisedButton2.TabIndex = 30;
            this.materialRaisedButton2.Text = "F6\r\nClick to change disable key";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // bypass1
            // 
            this.bypass1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bypass1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bypass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bypass1.ForeColor = System.Drawing.Color.White;
            this.bypass1.FormatString = "Select preset (None)";
            this.bypass1.FormattingEnabled = true;
            this.bypass1.Items.AddRange(new object[] {
            "Hypixel Holdclick",
            "Hypixel Doubleclick",
            "",
            "Safest Holdclick",
            "Safest Doubleclick"});
            this.bypass1.Location = new System.Drawing.Point(141, 82);
            this.bypass1.Name = "bypass1";
            this.bypass1.Size = new System.Drawing.Size(194, 24);
            this.bypass1.TabIndex = 26;
            this.bypass1.Text = "Select preset (None)";
            this.bypass1.SelectedIndexChanged += new System.EventHandler(this.bypass1_SelectedIndexChanged);
            // 
            // clic
            // 
            this.clic.Controls.Add(this.m1);
            this.clic.Controls.Add(this.m3);
            this.clic.Controls.Add(this.m2);
            this.clic.Location = new System.Drawing.Point(8, 29);
            this.clic.Name = "clic";
            this.clic.Size = new System.Drawing.Size(98, 30);
            this.clic.TabIndex = 25;
            // 
            // mice
            // 
            this.mice.Image = global::autoclicker.Properties.Resources.mice;
            this.mice.Location = new System.Drawing.Point(6, 0);
            this.mice.Name = "mice";
            this.mice.Size = new System.Drawing.Size(100, 144);
            this.mice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mice.TabIndex = 9;
            this.mice.TabStop = false;
            this.mice.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ui_MouseMove);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage2.Controls.Add(this.experimental);
            this.tabPage2.Controls.Add(this.holdclick);
            this.tabPage2.Controls.Add(this.hd);
            this.tabPage2.Controls.Add(this.dc);
            this.tabPage2.Controls.Add(this.sped);
            this.tabPage2.Controls.Add(this.blockhit);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(346, 121);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Custom Click";
            // 
            // experimental
            // 
            this.experimental.AutoSize = true;
            this.experimental.Depth = 0;
            this.experimental.Font = new System.Drawing.Font("Roboto", 11F);
            this.experimental.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.experimental.Location = new System.Drawing.Point(2, 59);
            this.experimental.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.experimental.MouseState = MaterialSkin.MouseState.HOVER;
            this.experimental.Name = "experimental";
            this.experimental.Size = new System.Drawing.Size(99, 19);
            this.experimental.TabIndex = 26;
            this.experimental.Text = "experimental:";
            // 
            // holdclick
            // 
            this.holdclick.AutoSize = true;
            this.holdclick.Depth = 0;
            this.holdclick.Font = new System.Drawing.Font("Roboto", 10F);
            this.holdclick.Location = new System.Drawing.Point(7, 78);
            this.holdclick.Margin = new System.Windows.Forms.Padding(0);
            this.holdclick.MouseLocation = new System.Drawing.Point(-1, -1);
            this.holdclick.MouseState = MaterialSkin.MouseState.HOVER;
            this.holdclick.Name = "holdclick";
            this.holdclick.Ripple = true;
            this.holdclick.Size = new System.Drawing.Size(89, 30);
            this.holdclick.TabIndex = 9;
            this.holdclick.Text = "hold click";
            this.holdclick.UseVisualStyleBackColor = true;
            this.holdclick.CheckedChanged += new System.EventHandler(this.holdclick_CheckedChanged);
            // 
            // selector
            // 
            this.selector.BaseTabControl = this.pages;
            this.selector.Depth = 0;
            this.selector.Location = new System.Drawing.Point(0, 0);
            this.selector.MouseState = MaterialSkin.MouseState.HOVER;
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(355, 23);
            this.selector.TabIndex = 27;
            this.selector.Text = "materialTabSelector1";
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton1.Location = new System.Drawing.Point(2, 3);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(98, 30);
            this.materialRadioButton1.TabIndex = 11;
            this.materialRadioButton1.Text = "Light mode";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            this.materialRadioButton1.CheckedChanged += new System.EventHandler(this.materialRadioButton1_CheckedChanged);
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Checked = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton2.Location = new System.Drawing.Point(134, 3);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(96, 30);
            this.materialRadioButton2.TabIndex = 12;
            this.materialRadioButton2.TabStop = true;
            this.materialRadioButton2.Text = "Dark mode";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            this.materialRadioButton2.CheckedChanged += new System.EventHandler(this.materialRadioButton2_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(4, 37);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(140, 19);
            this.numericUpDown1.TabIndex = 28;
            this.numericUpDown1.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(4, 35);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(124, 23);
            this.materialRaisedButton1.TabIndex = 29;
            this.materialRaisedButton1.Text = "Purple";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Controls.Add(this.Settings);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Font = new System.Drawing.Font("Arial", 9F);
            this.materialTabControl1.Location = new System.Drawing.Point(0, 75);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(355, 218);
            this.materialTabControl1.TabIndex = 28;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.selector);
            this.tabPage4.Controls.Add(this.credits);
            this.tabPage4.Controls.Add(this.milx);
            this.tabPage4.Controls.Add(this.intv);
            this.tabPage4.Controls.Add(this.pages);
            this.tabPage4.Controls.Add(this.autoclick);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(351, 190);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Clicker";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.AutoScroll = true;
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage5.Controls.Add(this.materialRaisedButton8);
            this.tabPage5.Controls.Add(this.materialLabel6);
            this.tabPage5.Controls.Add(this.macroDisable5);
            this.tabPage5.Controls.Add(this.materialLabel5);
            this.tabPage5.Controls.Add(this.materialRaisedButton7);
            this.tabPage5.Controls.Add(this.materialLabel4);
            this.tabPage5.Controls.Add(this.materialCheckBox1);
            this.tabPage5.Controls.Add(this.numericUpDown4);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.materialRaisedButton6);
            this.tabPage5.Controls.Add(this.materialLabel3);
            this.tabPage5.Controls.Add(this.macroDisable3);
            this.tabPage5.Controls.Add(this.materialRaisedButton5);
            this.tabPage5.Controls.Add(this.materialLabel2);
            this.tabPage5.Controls.Add(this.macroDisable2);
            this.tabPage5.Controls.Add(this.numericUpDown3);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.numericUpDown2);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.materialRaisedButton4);
            this.tabPage5.Controls.Add(this.materialLabel1);
            this.tabPage5.Controls.Add(this.macroDisable1);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(347, 190);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Macros";
            // 
            // materialRaisedButton7
            // 
            this.materialRaisedButton7.Depth = 0;
            this.materialRaisedButton7.Location = new System.Drawing.Point(185, 148);
            this.materialRaisedButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton7.Name = "materialRaisedButton7";
            this.materialRaisedButton7.Primary = true;
            this.materialRaisedButton7.Size = new System.Drawing.Size(143, 23);
            this.materialRaisedButton7.TabIndex = 17;
            this.materialRaisedButton7.Text = "Disable key: NONE";
            this.materialRaisedButton7.UseVisualStyleBackColor = true;
            this.materialRaisedButton7.Click += new System.EventHandler(this.materialRaisedButton7_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(38, 149);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(83, 19);
            this.materialLabel4.TabIndex = 16;
            this.materialLabel4.Text = "dupe slot 1";
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(9, 145);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(26, 30);
            this.materialCheckBox1.TabIndex = 15;
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            this.materialCheckBox1.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged_1);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numericUpDown4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown4.Font = new System.Drawing.Font("Arial", 10F);
            this.numericUpDown4.ForeColor = System.Drawing.Color.White;
            this.numericUpDown4.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown4.Location = new System.Drawing.Point(78, 117);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(104, 23);
            this.numericUpDown4.TabIndex = 14;
            this.numericUpDown4.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.Location = new System.Drawing.Point(6, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sell Price:";
            // 
            // materialRaisedButton6
            // 
            this.materialRaisedButton6.Depth = 0;
            this.materialRaisedButton6.Location = new System.Drawing.Point(185, 93);
            this.materialRaisedButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton6.Name = "materialRaisedButton6";
            this.materialRaisedButton6.Primary = true;
            this.materialRaisedButton6.Size = new System.Drawing.Size(143, 23);
            this.materialRaisedButton6.TabIndex = 12;
            this.materialRaisedButton6.Text = "Disable key: NONE";
            this.materialRaisedButton6.UseVisualStyleBackColor = true;
            this.materialRaisedButton6.Click += new System.EventHandler(this.materialRaisedButton6_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(35, 93);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(94, 19);
            this.materialLabel3.TabIndex = 11;
            this.materialLabel3.Text = "quick sell ah";
            // 
            // macroDisable3
            // 
            this.macroDisable3.AutoSize = true;
            this.macroDisable3.Depth = 0;
            this.macroDisable3.Font = new System.Drawing.Font("Roboto", 10F);
            this.macroDisable3.Location = new System.Drawing.Point(6, 89);
            this.macroDisable3.Margin = new System.Windows.Forms.Padding(0);
            this.macroDisable3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.macroDisable3.MouseState = MaterialSkin.MouseState.HOVER;
            this.macroDisable3.Name = "macroDisable3";
            this.macroDisable3.Ripple = true;
            this.macroDisable3.Size = new System.Drawing.Size(26, 30);
            this.macroDisable3.TabIndex = 10;
            this.macroDisable3.UseVisualStyleBackColor = true;
            this.macroDisable3.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged);
            // 
            // materialRaisedButton5
            // 
            this.materialRaisedButton5.Depth = 0;
            this.materialRaisedButton5.Location = new System.Drawing.Point(185, 63);
            this.materialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton5.Name = "materialRaisedButton5";
            this.materialRaisedButton5.Primary = true;
            this.materialRaisedButton5.Size = new System.Drawing.Size(143, 23);
            this.materialRaisedButton5.TabIndex = 9;
            this.materialRaisedButton5.Text = "Disable key: NONE";
            this.materialRaisedButton5.UseVisualStyleBackColor = true;
            this.materialRaisedButton5.Click += new System.EventHandler(this.materialRaisedButton5_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(35, 64);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(147, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "warp crystal hollows";
            // 
            // macroDisable2
            // 
            this.macroDisable2.AutoSize = true;
            this.macroDisable2.Depth = 0;
            this.macroDisable2.Font = new System.Drawing.Font("Roboto", 10F);
            this.macroDisable2.Location = new System.Drawing.Point(6, 60);
            this.macroDisable2.Margin = new System.Windows.Forms.Padding(0);
            this.macroDisable2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.macroDisable2.MouseState = MaterialSkin.MouseState.HOVER;
            this.macroDisable2.Name = "macroDisable2";
            this.macroDisable2.Ripple = true;
            this.macroDisable2.Size = new System.Drawing.Size(26, 30);
            this.macroDisable2.TabIndex = 7;
            this.macroDisable2.UseVisualStyleBackColor = true;
            this.macroDisable2.CheckedChanged += new System.EventHandler(this.macroDisable2_CheckedChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numericUpDown3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown3.Font = new System.Drawing.Font("Arial", 10F);
            this.numericUpDown3.ForeColor = System.Drawing.Color.White;
            this.numericUpDown3.Location = new System.Drawing.Point(249, 34);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(51, 23);
            this.numericUpDown3.TabIndex = 6;
            this.numericUpDown3.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.Location = new System.Drawing.Point(156, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Exploder Slot:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown2.Font = new System.Drawing.Font("Arial", 10F);
            this.numericUpDown2.ForeColor = System.Drawing.Color.White;
            this.numericUpDown2.Location = new System.Drawing.Point(99, 34);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(51, 23);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Teleport Slot: ";
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Location = new System.Drawing.Point(185, 9);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(143, 23);
            this.materialRaisedButton4.TabIndex = 2;
            this.materialRaisedButton4.Text = "Disable key: NONE";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            this.materialRaisedButton4.Click += new System.EventHandler(this.materialRaisedButton4_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(35, 10);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(115, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "budget hyperion";
            // 
            // macroDisable1
            // 
            this.macroDisable1.AutoSize = true;
            this.macroDisable1.Depth = 0;
            this.macroDisable1.Font = new System.Drawing.Font("Roboto", 10F);
            this.macroDisable1.Location = new System.Drawing.Point(6, 6);
            this.macroDisable1.Margin = new System.Windows.Forms.Padding(0);
            this.macroDisable1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.macroDisable1.MouseState = MaterialSkin.MouseState.HOVER;
            this.macroDisable1.Name = "macroDisable1";
            this.macroDisable1.Ripple = true;
            this.macroDisable1.Size = new System.Drawing.Size(26, 30);
            this.macroDisable1.TabIndex = 0;
            this.macroDisable1.UseVisualStyleBackColor = true;
            this.macroDisable1.CheckedChanged += new System.EventHandler(this.macroDisable1_CheckedChanged);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Settings.Controls.Add(this.materialRaisedButton3);
            this.Settings.Controls.Add(this.materialRaisedButton1);
            this.Settings.Controls.Add(this.materialRadioButton2);
            this.Settings.Controls.Add(this.tm);
            this.Settings.Controls.Add(this.numericUpDown1);
            this.Settings.Controls.Add(this.materialRadioButton1);
            this.Settings.Location = new System.Drawing.Point(4, 24);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(351, 190);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "settings";
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(4, 64);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(141, 23);
            this.materialRaisedButton3.TabIndex = 30;
            this.materialRaisedButton3.Text = "get new MOTD";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 55);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(358, 23);
            this.materialTabSelector1.TabIndex = 29;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(119, 508);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(83, 19);
            this.materialLabel5.TabIndex = 18;
            this.materialLabel5.Text = "dupe slot 1";
            // 
            // materialRaisedButton8
            // 
            this.materialRaisedButton8.Depth = 0;
            this.materialRaisedButton8.Location = new System.Drawing.Point(185, 177);
            this.materialRaisedButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton8.Name = "materialRaisedButton8";
            this.materialRaisedButton8.Primary = true;
            this.materialRaisedButton8.Size = new System.Drawing.Size(143, 23);
            this.materialRaisedButton8.TabIndex = 21;
            this.materialRaisedButton8.Text = "Disable key: NONE";
            this.materialRaisedButton8.UseVisualStyleBackColor = true;
            this.materialRaisedButton8.Click += new System.EventHandler(this.materialRaisedButton8_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(38, 178);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(99, 19);
            this.materialLabel6.TabIndex = 20;
            this.materialLabel6.Text = "Lunar Combo";
            // 
            // macroDisable5
            // 
            this.macroDisable5.AutoSize = true;
            this.macroDisable5.Depth = 0;
            this.macroDisable5.Font = new System.Drawing.Font("Roboto", 10F);
            this.macroDisable5.Location = new System.Drawing.Point(9, 174);
            this.macroDisable5.Margin = new System.Windows.Forms.Padding(0);
            this.macroDisable5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.macroDisable5.MouseState = MaterialSkin.MouseState.HOVER;
            this.macroDisable5.Name = "macroDisable5";
            this.macroDisable5.Ripple = true;
            this.macroDisable5.Size = new System.Drawing.Size(26, 30);
            this.macroDisable5.TabIndex = 19;
            this.macroDisable5.UseVisualStyleBackColor = true;
            this.macroDisable5.CheckedChanged += new System.EventHandler(this.macroDisable5_CheckedChanged);
            // 
            // ui
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(355, 279);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "ui";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ui_FormClosing);
            this.Load += new System.EventHandler(this.ui_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ui_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.sped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max)).EndInit();
            this.pages.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.clic.ResumeLayout(false);
            this.clic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mice)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public MaterialSkin.Controls.MaterialCheckBox random;
        public MaterialSkin.Controls.MaterialLabel credits;
        public MaterialSkin.Controls.MaterialCheckBox overwrite;
        public MaterialSkin.Controls.MaterialCheckBox tm;
        public MaterialSkin.Controls.MaterialCheckBox dc;
        public MaterialSkin.Controls.MaterialCheckBox hd;
        public System.Windows.Forms.NumericUpDown sped;
        public MaterialSkin.Controls.MaterialCheckBox m1;
        public MaterialSkin.Controls.MaterialCheckBox m2;
        public MaterialSkin.Controls.MaterialRaisedButton autoclick;
        public MaterialSkin.Controls.MaterialLabel intv;
        public System.Windows.Forms.NumericUpDown milx;
        public MaterialSkin.Controls.MaterialCheckBox m3;
        public System.Windows.Forms.NumericUpDown min;
        public System.Windows.Forms.NumericUpDown max;
        public MaterialSkin.Controls.MaterialLabel label1;
        public MaterialSkin.Controls.MaterialLabel label2;
        public MaterialSkin.Controls.MaterialCheckBox blockhit;
        public MaterialSkin.Controls.MaterialTabControl pages;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.PictureBox mice;
        public MaterialSkin.Controls.MaterialCheckBox holdclick;
        public MaterialSkin.Controls.MaterialLabel experimental;
        public MaterialSkin.Controls.MaterialTabSelector selector;
        public System.Windows.Forms.Panel clic;
        public MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        public MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        public MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        public System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.TabPage tabPage5;
        public MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        public System.Windows.Forms.TabPage Settings;
        public MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        public MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ComboBox bypass1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckBox macroDisable1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton5;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCheckBox macroDisable2;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton6;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialCheckBox macroDisable3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton7;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton8;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialCheckBox macroDisable5;
    }
}

