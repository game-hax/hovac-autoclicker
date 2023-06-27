namespace autoclicker.Tabs
{
    partial class Settings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SelectColour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Credit = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.ColourSelector = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.SelectColour);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(399, 76);
            this.panel1.TabIndex = 5;
            // 
            // SelectColour
            // 
            this.SelectColour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SelectColour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectColour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SelectColour.FlatAppearance.BorderSize = 0;
            this.SelectColour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SelectColour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SelectColour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectColour.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.SelectColour.ForeColor = System.Drawing.Color.Plum;
            this.SelectColour.Image = global::autoclicker.Properties.Resources.palette;
            this.SelectColour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SelectColour.Location = new System.Drawing.Point(17, 29);
            this.SelectColour.Name = "SelectColour";
            this.SelectColour.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.SelectColour.Size = new System.Drawing.Size(366, 36);
            this.SelectColour.TabIndex = 13;
            this.SelectColour.TabStop = false;
            this.SelectColour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SelectColour.UseCompatibleTextRendering = true;
            this.SelectColour.UseVisualStyleBackColor = false;
            this.SelectColour.Click += new System.EventHandler(this.SelectColour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Colour:";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.Credit);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4);
            this.panel2.Size = new System.Drawing.Size(399, 40);
            this.panel2.TabIndex = 6;
            // 
            // Credit
            // 
            this.Credit.ActiveLinkColor = System.Drawing.Color.Plum;
            this.Credit.AutoSize = true;
            this.Credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Credit.LinkColor = System.Drawing.Color.Plum;
            this.Credit.Location = new System.Drawing.Point(49, 19);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(301, 17);
            this.Credit.TabIndex = 0;
            this.Credit.TabStop = true;
            this.Credit.Text = "https://github.com/game-hax/hovac-autoclicker";
            this.Credit.VisitedLinkColor = System.Drawing.Color.Plum;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label2.Location = new System.Drawing.Point(139, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "hovac clicker, v4";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(399, 312);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel Credit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectColour;
        private System.Windows.Forms.ColorDialog ColourSelector;
    }
}
