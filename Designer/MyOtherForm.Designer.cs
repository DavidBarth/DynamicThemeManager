namespace Designer
{
    partial class MyOtherForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PopulateThemeDropDownButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ChangeThemeButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PopulateThemeDropDownButton
            // 
            this.PopulateThemeDropDownButton.Location = new System.Drawing.Point(12, 86);
            this.PopulateThemeDropDownButton.Name = "PopulateThemeDropDownButton";
            this.PopulateThemeDropDownButton.Size = new System.Drawing.Size(176, 23);
            this.PopulateThemeDropDownButton.TabIndex = 10;
            this.PopulateThemeDropDownButton.Text = "Populate Theme List\r\n";
            this.PopulateThemeDropDownButton.UseVisualStyleBackColor = true;
            this.PopulateThemeDropDownButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowMessageButton_MouseClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // ChangeThemeButton
            // 
            this.ChangeThemeButton.Location = new System.Drawing.Point(12, 115);
            this.ChangeThemeButton.Name = "ChangeThemeButton";
            this.ChangeThemeButton.Size = new System.Drawing.Size(176, 23);
            this.ChangeThemeButton.TabIndex = 15;
            this.ChangeThemeButton.Text = "ChangeTheme";
            this.ChangeThemeButton.UseVisualStyleBackColor = true;
            this.ChangeThemeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(412, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(25, 22);
            this.toolStripLabel1.Text = "File";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel2.Text = "Help";
            // 
            // MyOtherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 348);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ChangeThemeButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PopulateThemeDropDownButton);
            this.Name = "MyOtherForm";
            this.Text = "David\'s new window";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button PopulateThemeDropDownButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ChangeThemeButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}