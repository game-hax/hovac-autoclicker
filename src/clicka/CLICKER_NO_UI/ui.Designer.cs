namespace CLICKER_NO_UI
{
	// Token: 0x02000009 RID: 9
	public partial class ui : global::MaterialSkin.Controls.MaterialForm
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00003454 File Offset: 0x00001654
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000348C File Offset: 0x0000168C
		private void InitializeComponent()
		{
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.Clicker = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.clickerTab = new MaterialSkin.Controls.MaterialTabControl();
            this.clickTab = new System.Windows.Forms.TabPage();
            this.oppositeToggle = new MaterialSkin.Controls.MaterialCheckbox();
            this.holdToggle = new MaterialSkin.Controls.MaterialCheckbox();
            this.text = new MaterialSkin.Controls.MaterialLabel();
            this.multiCount = new MaterialSkin.Controls.MaterialSlider();
            this.scrollToggle = new MaterialSkin.Controls.MaterialCheckbox();
            this.multiToggle = new MaterialSkin.Controls.MaterialCheckbox();
            this.leftToggle = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.midToggle = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.rightToggle = new MaterialSkin.Controls.MaterialCheckbox();
            this.clickSettingsTab = new System.Windows.Forms.TabPage();
            this.bypass1 = new MaterialSkin.Controls.MaterialComboBox();
            this.maxSlider = new MaterialSkin.Controls.MaterialSlider();
            this.minSlider = new MaterialSkin.Controls.MaterialSlider();
            this.randomizedToggle = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.overwrite = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.listener = new MaterialSkin.Controls.MaterialButton();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.colourSwitcher = new MaterialSkin.Controls.MaterialButton();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialTabControl1.SuspendLayout();
            this.Home.SuspendLayout();
            this.Clicker.SuspendLayout();
            this.clickerTab.SuspendLayout();
            this.clickTab.SuspendLayout();
            this.clickSettingsTab.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialDrawer1
            // 
            this.materialDrawer1.AutoHide = false;
            this.materialDrawer1.AutoShow = false;
            this.materialDrawer1.BackgroundWithAccent = false;
            this.materialDrawer1.BaseTabControl = null;
            this.materialDrawer1.Depth = 0;
            this.materialDrawer1.HighlightWithAccent = true;
            this.materialDrawer1.IndicatorWidth = 0;
            this.materialDrawer1.IsOpen = false;
            this.materialDrawer1.Location = new System.Drawing.Point(-90, 106);
            this.materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.Size = new System.Drawing.Size(90, 125);
            this.materialDrawer1.TabIndex = 0;
            this.materialDrawer1.Text = "materialDrawer1";
            this.materialDrawer1.UseColors = false;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Home);
            this.materialTabControl1.Controls.Add(this.Clicker);
            this.materialTabControl1.Controls.Add(this.SettingsTab);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-2, 85);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(389, 253);
            this.materialTabControl1.TabIndex = 2;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.White;
            this.Home.Controls.Add(this.materialLabel4);
            this.Home.Location = new System.Drawing.Point(4, 22);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(381, 227);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(24, 12);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(240, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "click the tab icon (≡) to get started";
            // 
            // Clicker
            // 
            this.Clicker.BackColor = System.Drawing.Color.White;
            this.Clicker.Controls.Add(this.materialTabSelector1);
            this.Clicker.Controls.Add(this.clickerTab);
            this.Clicker.Location = new System.Drawing.Point(4, 22);
            this.Clicker.Name = "Clicker";
            this.Clicker.Padding = new System.Windows.Forms.Padding(3);
            this.Clicker.Size = new System.Drawing.Size(381, 227);
            this.Clicker.TabIndex = 1;
            this.Clicker.Text = "Clicker";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.clickerTab;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(389, 28);
            this.materialTabSelector1.TabIndex = 10;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // clickerTab
            // 
            this.clickerTab.Controls.Add(this.clickTab);
            this.clickerTab.Controls.Add(this.clickSettingsTab);
            this.clickerTab.Depth = 0;
            this.clickerTab.Location = new System.Drawing.Point(0, 25);
            this.clickerTab.MouseState = MaterialSkin.MouseState.HOVER;
            this.clickerTab.Multiline = true;
            this.clickerTab.Name = "clickerTab";
            this.clickerTab.SelectedIndex = 0;
            this.clickerTab.Size = new System.Drawing.Size(389, 196);
            this.clickerTab.TabIndex = 9;
            // 
            // clickTab
            // 
            this.clickTab.BackColor = System.Drawing.Color.White;
            this.clickTab.Controls.Add(this.oppositeToggle);
            this.clickTab.Controls.Add(this.holdToggle);
            this.clickTab.Controls.Add(this.text);
            this.clickTab.Controls.Add(this.multiCount);
            this.clickTab.Controls.Add(this.scrollToggle);
            this.clickTab.Controls.Add(this.multiToggle);
            this.clickTab.Controls.Add(this.leftToggle);
            this.clickTab.Controls.Add(this.materialDivider1);
            this.clickTab.Controls.Add(this.midToggle);
            this.clickTab.Controls.Add(this.materialLabel1);
            this.clickTab.Controls.Add(this.rightToggle);
            this.clickTab.Location = new System.Drawing.Point(4, 22);
            this.clickTab.Name = "clickTab";
            this.clickTab.Padding = new System.Windows.Forms.Padding(3);
            this.clickTab.Size = new System.Drawing.Size(381, 170);
            this.clickTab.TabIndex = 0;
            this.clickTab.Text = "Clicker";
            // 
            // oppositeToggle
            // 
            this.oppositeToggle.AutoSize = true;
            this.oppositeToggle.BackColor = System.Drawing.Color.Transparent;
            this.oppositeToggle.Depth = 0;
            this.oppositeToggle.Location = new System.Drawing.Point(148, 140);
            this.oppositeToggle.Margin = new System.Windows.Forms.Padding(0);
            this.oppositeToggle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.oppositeToggle.MouseState = MaterialSkin.MouseState.HOVER;
            this.oppositeToggle.Name = "oppositeToggle";
            this.oppositeToggle.ReadOnly = false;
            this.oppositeToggle.Ripple = true;
            this.oppositeToggle.Size = new System.Drawing.Size(149, 37);
            this.oppositeToggle.TabIndex = 11;
            this.oppositeToggle.Text = "Opposite Clicker";
            this.oppositeToggle.UseVisualStyleBackColor = false;
            this.oppositeToggle.CheckedChanged += new System.EventHandler(this.oppositeToggle_CheckedChanged);
            this.oppositeToggle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.oppositeToggle_MouseClick);
            // 
            // holdToggle
            // 
            this.holdToggle.AutoSize = true;
            this.holdToggle.BackColor = System.Drawing.Color.Transparent;
            this.holdToggle.Depth = 0;
            this.holdToggle.Location = new System.Drawing.Point(148, 103);
            this.holdToggle.Margin = new System.Windows.Forms.Padding(0);
            this.holdToggle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.holdToggle.MouseState = MaterialSkin.MouseState.HOVER;
            this.holdToggle.Name = "holdToggle";
            this.holdToggle.ReadOnly = false;
            this.holdToggle.Ripple = true;
            this.holdToggle.Size = new System.Drawing.Size(119, 37);
            this.holdToggle.TabIndex = 10;
            this.holdToggle.Text = "Hold Clicker";
            this.holdToggle.UseVisualStyleBackColor = false;
            this.holdToggle.CheckedChanged += new System.EventHandler(this.holdToggle_CheckedChanged);
            this.holdToggle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.holdToggle_MouseClick);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Depth = 0;
            this.text.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.text.Location = new System.Drawing.Point(18, 10);
            this.text.MouseState = MaterialSkin.MouseState.HOVER;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(111, 19);
            this.text.TabIndex = 2;
            this.text.Text = "Mouse buttons:";
            // 
            // multiCount
            // 
            this.multiCount.Depth = 0;
            this.multiCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.multiCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.multiCount.Location = new System.Drawing.Point(273, 29);
            this.multiCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.multiCount.Name = "multiCount";
            this.multiCount.RangeMax = 5;
            this.multiCount.RangeMin = 1;
            this.multiCount.ShowText = false;
            this.multiCount.ShowValue = false;
            this.multiCount.Size = new System.Drawing.Size(111, 40);
            this.multiCount.TabIndex = 8;
            this.multiCount.Text = "";
            this.multiCount.UseAccentColor = true;
            this.multiCount.Value = 1;
            this.multiCount.ValueMax = 5;
            // 
            // scrollToggle
            // 
            this.scrollToggle.AutoSize = true;
            this.scrollToggle.BackColor = System.Drawing.Color.Transparent;
            this.scrollToggle.Depth = 0;
            this.scrollToggle.Location = new System.Drawing.Point(148, 66);
            this.scrollToggle.Margin = new System.Windows.Forms.Padding(0);
            this.scrollToggle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.scrollToggle.MouseState = MaterialSkin.MouseState.HOVER;
            this.scrollToggle.Name = "scrollToggle";
            this.scrollToggle.ReadOnly = false;
            this.scrollToggle.Ripple = true;
            this.scrollToggle.Size = new System.Drawing.Size(126, 37);
            this.scrollToggle.TabIndex = 0;
            this.scrollToggle.Text = "Scroll Clicker";
            this.scrollToggle.UseVisualStyleBackColor = false;
            this.scrollToggle.CheckedChanged += new System.EventHandler(this.scrollToggle_CheckedChanged);
            this.scrollToggle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.scrollToggle_MouseClick);
            // 
            // multiToggle
            // 
            this.multiToggle.AutoSize = true;
            this.multiToggle.BackColor = System.Drawing.Color.Transparent;
            this.multiToggle.Depth = 0;
            this.multiToggle.Location = new System.Drawing.Point(148, 29);
            this.multiToggle.Margin = new System.Windows.Forms.Padding(0);
            this.multiToggle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.multiToggle.MouseState = MaterialSkin.MouseState.HOVER;
            this.multiToggle.Name = "multiToggle";
            this.multiToggle.ReadOnly = false;
            this.multiToggle.Ripple = true;
            this.multiToggle.Size = new System.Drawing.Size(122, 37);
            this.multiToggle.TabIndex = 7;
            this.multiToggle.Text = "Multi Clicker";
            this.multiToggle.UseVisualStyleBackColor = false;
            this.multiToggle.CheckedChanged += new System.EventHandler(this.multiToggle_CheckedChanged);
            this.multiToggle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.multiToggle_MouseClick);
            // 
            // leftToggle
            // 
            this.leftToggle.AutoSize = true;
            this.leftToggle.Checked = true;
            this.leftToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.leftToggle.Depth = 0;
            this.leftToggle.Location = new System.Drawing.Point(3, 29);
            this.leftToggle.Margin = new System.Windows.Forms.Padding(0);
            this.leftToggle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.leftToggle.MouseState = MaterialSkin.MouseState.HOVER;
            this.leftToggle.Name = "leftToggle";
            this.leftToggle.ReadOnly = false;
            this.leftToggle.Ripple = true;
            this.leftToggle.Size = new System.Drawing.Size(101, 37);
            this.leftToggle.TabIndex = 1;
            this.leftToggle.Text = "Left Click";
            this.leftToggle.UseVisualStyleBackColor = true;
            this.leftToggle.CheckedChanged += new System.EventHandler(this.leftToggle_CheckedChanged);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(135, 0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(10, 409);
            this.materialDivider1.TabIndex = 6;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // midToggle
            // 
            this.midToggle.AutoSize = true;
            this.midToggle.Depth = 0;
            this.midToggle.Location = new System.Drawing.Point(3, 66);
            this.midToggle.Margin = new System.Windows.Forms.Padding(0);
            this.midToggle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.midToggle.MouseState = MaterialSkin.MouseState.HOVER;
            this.midToggle.Name = "midToggle";
            this.midToggle.ReadOnly = false;
            this.midToggle.Ripple = true;
            this.midToggle.Size = new System.Drawing.Size(100, 37);
            this.midToggle.TabIndex = 3;
            this.midToggle.Text = "Mid Click";
            this.midToggle.UseVisualStyleBackColor = true;
            this.midToggle.CheckedChanged += new System.EventHandler(this.midToggle_CheckedChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(162, 10);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(56, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Clickers";
            // 
            // rightToggle
            // 
            this.rightToggle.AutoSize = true;
            this.rightToggle.Depth = 0;
            this.rightToggle.Location = new System.Drawing.Point(3, 103);
            this.rightToggle.Margin = new System.Windows.Forms.Padding(0);
            this.rightToggle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rightToggle.MouseState = MaterialSkin.MouseState.HOVER;
            this.rightToggle.Name = "rightToggle";
            this.rightToggle.ReadOnly = false;
            this.rightToggle.Ripple = true;
            this.rightToggle.Size = new System.Drawing.Size(110, 37);
            this.rightToggle.TabIndex = 4;
            this.rightToggle.Text = "Right Click";
            this.rightToggle.UseVisualStyleBackColor = true;
            this.rightToggle.CheckedChanged += new System.EventHandler(this.rightToggle_CheckedChanged);
            // 
            // clickSettingsTab
            // 
            this.clickSettingsTab.BackColor = System.Drawing.Color.White;
            this.clickSettingsTab.Controls.Add(this.bypass1);
            this.clickSettingsTab.Controls.Add(this.maxSlider);
            this.clickSettingsTab.Controls.Add(this.minSlider);
            this.clickSettingsTab.Controls.Add(this.randomizedToggle);
            this.clickSettingsTab.Controls.Add(this.materialLabel3);
            this.clickSettingsTab.Controls.Add(this.overwrite);
            this.clickSettingsTab.Controls.Add(this.materialLabel2);
            this.clickSettingsTab.Controls.Add(this.listener);
            this.clickSettingsTab.Location = new System.Drawing.Point(4, 22);
            this.clickSettingsTab.Name = "clickSettingsTab";
            this.clickSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.clickSettingsTab.Size = new System.Drawing.Size(381, 170);
            this.clickSettingsTab.TabIndex = 1;
            this.clickSettingsTab.Text = "Settings";
            // 
            // bypass1
            // 
            this.bypass1.AutoResize = false;
            this.bypass1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bypass1.Depth = 0;
            this.bypass1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.bypass1.DropDownHeight = 118;
            this.bypass1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bypass1.DropDownWidth = 121;
            this.bypass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bypass1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bypass1.FormattingEnabled = true;
            this.bypass1.IntegralHeight = false;
            this.bypass1.ItemHeight = 29;
            this.bypass1.Items.AddRange(new object[] {
            "Select presets",
            "",
            "Hypixel Holdclick",
            "Hypixel Doubleclick",
            "",
            "Safest Holdclick",
            "Safest Doubleclick"});
            this.bypass1.Location = new System.Drawing.Point(9, 129);
            this.bypass1.MaxDropDownItems = 4;
            this.bypass1.MouseState = MaterialSkin.MouseState.OUT;
            this.bypass1.Name = "bypass1";
            this.bypass1.Size = new System.Drawing.Size(190, 35);
            this.bypass1.StartIndex = 0;
            this.bypass1.TabIndex = 8;
            this.bypass1.UseTallSize = false;
            this.bypass1.SelectedIndexChanged += new System.EventHandler(this.presets_SelectedIndexChanged);
            // 
            // maxSlider
            // 
            this.maxSlider.Depth = 0;
            this.maxSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.maxSlider.Location = new System.Drawing.Point(210, 124);
            this.maxSlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.maxSlider.Name = "maxSlider";
            this.maxSlider.RangeMax = 500;
            this.maxSlider.Size = new System.Drawing.Size(156, 40);
            this.maxSlider.TabIndex = 7;
            this.maxSlider.Text = "Max";
            this.maxSlider.Value = 200;
            this.maxSlider.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.timeSlider_OnValueChanged);
            // 
            // minSlider
            // 
            this.minSlider.Depth = 0;
            this.minSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.minSlider.Location = new System.Drawing.Point(210, 91);
            this.minSlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.minSlider.Name = "minSlider";
            this.minSlider.RangeMax = 500;
            this.minSlider.Size = new System.Drawing.Size(156, 40);
            this.minSlider.TabIndex = 6;
            this.minSlider.Text = "Min ";
            this.minSlider.Value = 150;
            this.minSlider.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.timeSlider_OnValueChanged);
            // 
            // randomizedToggle
            // 
            this.randomizedToggle.AutoSize = true;
            this.randomizedToggle.Depth = 0;
            this.randomizedToggle.Location = new System.Drawing.Point(9, 94);
            this.randomizedToggle.Margin = new System.Windows.Forms.Padding(0);
            this.randomizedToggle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.randomizedToggle.MouseState = MaterialSkin.MouseState.HOVER;
            this.randomizedToggle.Name = "randomizedToggle";
            this.randomizedToggle.ReadOnly = false;
            this.randomizedToggle.Ripple = true;
            this.randomizedToggle.Size = new System.Drawing.Size(172, 37);
            this.randomizedToggle.TabIndex = 5;
            this.randomizedToggle.Text = "Randomized Speed";
            this.randomizedToggle.UseVisualStyleBackColor = true;
            this.randomizedToggle.CheckedChanged += new System.EventHandler(this.randomizedToggle_CheckedChanged);
            this.randomizedToggle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.randomizedToggle_MouseClick);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.White;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(19, 75);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(142, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Randomized Speed:";
            // 
            // overwrite
            // 
            this.overwrite.AutoSize = true;
            this.overwrite.Depth = 0;
            this.overwrite.Location = new System.Drawing.Point(9, 29);
            this.overwrite.Margin = new System.Windows.Forms.Padding(0);
            this.overwrite.MouseLocation = new System.Drawing.Point(-1, -1);
            this.overwrite.MouseState = MaterialSkin.MouseState.HOVER;
            this.overwrite.Name = "overwrite";
            this.overwrite.ReadOnly = false;
            this.overwrite.Ripple = true;
            this.overwrite.Size = new System.Drawing.Size(97, 37);
            this.overwrite.TabIndex = 4;
            this.overwrite.Text = "Disabled";
            this.overwrite.UseVisualStyleBackColor = true;
            this.overwrite.CheckedChanged += new System.EventHandler(this.overwrite_CheckedChanged);
            this.overwrite.MouseClick += new System.Windows.Forms.MouseEventHandler(this.overwrite_MouseClick);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.White;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(18, 10);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(63, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Disabler:";
            // 
            // listener
            // 
            this.listener.AutoSize = false;
            this.listener.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.listener.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.listener.Depth = 0;
            this.listener.HighEmphasis = true;
            this.listener.Icon = null;
            this.listener.Location = new System.Drawing.Point(131, 28);
            this.listener.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.listener.MouseState = MaterialSkin.MouseState.HOVER;
            this.listener.Name = "listener";
            this.listener.NoAccentTextColor = System.Drawing.Color.Empty;
            this.listener.Size = new System.Drawing.Size(239, 36);
            this.listener.TabIndex = 0;
            this.listener.Text = "F6\r\nClick to change disable key";
            this.listener.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.listener.UseAccentColor = false;
            this.listener.UseVisualStyleBackColor = true;
            this.listener.Click += new System.EventHandler(this.listener_Click);
            // 
            // SettingsTab
            // 
            this.SettingsTab.BackColor = System.Drawing.Color.White;
            this.SettingsTab.Controls.Add(this.colourSwitcher);
            this.SettingsTab.Controls.Add(this.materialSwitch1);
            this.SettingsTab.Location = new System.Drawing.Point(4, 22);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(381, 227);
            this.SettingsTab.TabIndex = 2;
            this.SettingsTab.Text = "Settings";
            // 
            // colourSwitcher
            // 
            this.colourSwitcher.AutoSize = false;
            this.colourSwitcher.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colourSwitcher.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.colourSwitcher.Depth = 0;
            this.colourSwitcher.HighEmphasis = true;
            this.colourSwitcher.Icon = null;
            this.colourSwitcher.Location = new System.Drawing.Point(152, 9);
            this.colourSwitcher.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.colourSwitcher.MouseState = MaterialSkin.MouseState.HOVER;
            this.colourSwitcher.Name = "colourSwitcher";
            this.colourSwitcher.NoAccentTextColor = System.Drawing.Color.Empty;
            this.colourSwitcher.Size = new System.Drawing.Size(140, 32);
            this.colourSwitcher.TabIndex = 2;
            this.colourSwitcher.Text = "Colour: Purple";
            this.colourSwitcher.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.colourSwitcher.UseAccentColor = false;
            this.colourSwitcher.UseVisualStyleBackColor = true;
            this.colourSwitcher.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colourSwitcher_MouseClick);
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.Checked = true;
            this.materialSwitch1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(3, 6);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(135, 37);
            this.materialSwitch1.TabIndex = 1;
            this.materialSwitch1.Text = "Dark mode";
            this.materialSwitch1.UseVisualStyleBackColor = true;
            this.materialSwitch1.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox1.TabIndex = 0;
            this.materialCheckbox1.Text = "Left click";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // ui
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(385, 290);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialDrawer1);
            this.DrawerAutoShow = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.MaximizeBox = false;
            this.Name = "ui";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hovac clicker v3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ui_FormClosed);
            this.Load += new System.EventHandler(this.ui_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.Clicker.ResumeLayout(false);
            this.clickerTab.ResumeLayout(false);
            this.clickTab.ResumeLayout(false);
            this.clickTab.PerformLayout();
            this.clickSettingsTab.ResumeLayout(false);
            this.clickSettingsTab.PerformLayout();
            this.SettingsTab.ResumeLayout(false);
            this.SettingsTab.PerformLayout();
            this.ResumeLayout(false);

		}

		// Token: 0x040000D4 RID: 212
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000D5 RID: 213
		private global::MaterialSkin.Controls.MaterialDrawer materialDrawer1;

		// Token: 0x040000D6 RID: 214
		private global::MaterialSkin.Controls.MaterialTabControl materialTabControl1;

		// Token: 0x040000D7 RID: 215
		private global::System.Windows.Forms.TabPage Home;

		// Token: 0x040000D8 RID: 216
		private global::System.Windows.Forms.TabPage Clicker;

		// Token: 0x040000D9 RID: 217
		private global::MaterialSkin.Controls.MaterialCheckbox scrollToggle;

		// Token: 0x040000DA RID: 218
		private global::MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;

		// Token: 0x040000DB RID: 219
		private global::MaterialSkin.Controls.MaterialCheckbox rightToggle;

		// Token: 0x040000DC RID: 220
		private global::MaterialSkin.Controls.MaterialCheckbox midToggle;

		// Token: 0x040000DD RID: 221
		private global::MaterialSkin.Controls.MaterialLabel text;

		// Token: 0x040000DE RID: 222
		private global::MaterialSkin.Controls.MaterialCheckbox leftToggle;

		// Token: 0x040000DF RID: 223
		private global::MaterialSkin.Controls.MaterialDivider materialDivider1;

		// Token: 0x040000E0 RID: 224
		private global::MaterialSkin.Controls.MaterialLabel materialLabel1;

		// Token: 0x040000E1 RID: 225
		private global::MaterialSkin.Controls.MaterialCheckbox multiToggle;

		// Token: 0x040000E2 RID: 226
		private global::MaterialSkin.Controls.MaterialSlider multiCount;

		// Token: 0x040000E3 RID: 227
		private global::MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;

		// Token: 0x040000E4 RID: 228
		private global::MaterialSkin.Controls.MaterialTabControl clickerTab;

		// Token: 0x040000E5 RID: 229
		private global::System.Windows.Forms.TabPage clickTab;

		// Token: 0x040000E6 RID: 230
		private global::System.Windows.Forms.TabPage clickSettingsTab;

		// Token: 0x040000E7 RID: 231
		private global::MaterialSkin.Controls.MaterialLabel materialLabel2;

		// Token: 0x040000E8 RID: 232
		private global::MaterialSkin.Controls.MaterialButton listener;

		// Token: 0x040000E9 RID: 233
		private global::MaterialSkin.Controls.MaterialCheckbox overwrite;

		// Token: 0x040000EA RID: 234
		private global::MaterialSkin.Controls.MaterialCheckbox holdToggle;

		// Token: 0x040000EB RID: 235
		private global::MaterialSkin.Controls.MaterialCheckbox oppositeToggle;

		// Token: 0x040000EC RID: 236
		private global::MaterialSkin.Controls.MaterialCheckbox randomizedToggle;

		// Token: 0x040000ED RID: 237
		private global::MaterialSkin.Controls.MaterialSlider minSlider;

		// Token: 0x040000EE RID: 238
		private global::MaterialSkin.Controls.MaterialSlider maxSlider;

		// Token: 0x040000EF RID: 239
		private global::MaterialSkin.Controls.MaterialLabel materialLabel3;

		// Token: 0x040000F0 RID: 240
		private global::MaterialSkin.Controls.MaterialComboBox bypass1;

		// Token: 0x040000F1 RID: 241
		private global::System.Windows.Forms.TabPage SettingsTab;

		// Token: 0x040000F2 RID: 242
		private global::MaterialSkin.Controls.MaterialSwitch materialSwitch1;

		// Token: 0x040000F3 RID: 243
		private global::MaterialSkin.Controls.MaterialButton colourSwitcher;

		// Token: 0x040000F4 RID: 244
		private global::MaterialSkin.Controls.MaterialLabel materialLabel4;
	}
}
