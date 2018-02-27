namespace StarshipTroopers_FOVChanger
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TB_ResX = new System.Windows.Forms.TextBox();
            this.TB_ResY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.B_WriteToAFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CB_HorizontalPlusFOV = new System.Windows.Forms.CheckBox();
            this.LL_PCGW_link = new System.Windows.Forms.LinkLabel();
            this.L_Byte3 = new System.Windows.Forms.Label();
            this.L_Byte2 = new System.Windows.Forms.Label();
            this.L_Byte1 = new System.Windows.Forms.Label();
            this.L_Byte0 = new System.Windows.Forms.Label();
            this.TB_FOV = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.donateLink = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.HorPlus_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-4, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resolution:";
            // 
            // TB_ResX
            // 
            this.TB_ResX.Enabled = false;
            this.TB_ResX.Location = new System.Drawing.Point(-1, 95);
            this.TB_ResX.Name = "TB_ResX";
            this.TB_ResX.Size = new System.Drawing.Size(84, 20);
            this.TB_ResX.TabIndex = 1;
            this.TB_ResX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_ResX.TextChanged += new System.EventHandler(this.TB_ResX_TextChanged);
            // 
            // TB_ResY
            // 
            this.TB_ResY.Enabled = false;
            this.TB_ResY.Location = new System.Drawing.Point(102, 95);
            this.TB_ResY.Name = "TB_ResY";
            this.TB_ResY.Size = new System.Drawing.Size(84, 20);
            this.TB_ResY.TabIndex = 2;
            this.TB_ResY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_ResY.TextChanged += new System.EventHandler(this.TB_ResY_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "FOV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "x";
            // 
            // B_WriteToAFile
            // 
            this.B_WriteToAFile.Location = new System.Drawing.Point(101, 123);
            this.B_WriteToAFile.Name = "B_WriteToAFile";
            this.B_WriteToAFile.Size = new System.Drawing.Size(90, 23);
            this.B_WriteToAFile.TabIndex = 7;
            this.B_WriteToAFile.Text = "Write to a file";
            this.B_WriteToAFile.UseVisualStyleBackColor = true;
            this.B_WriteToAFile.Click += new System.EventHandler(this.B_WriteToAFile_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CB_HorizontalPlusFOV);
            this.panel1.Controls.Add(this.LL_PCGW_link);
            this.panel1.Controls.Add(this.L_Byte3);
            this.panel1.Controls.Add(this.L_Byte2);
            this.panel1.Controls.Add(this.L_Byte1);
            this.panel1.Controls.Add(this.L_Byte0);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.B_WriteToAFile);
            this.panel1.Controls.Add(this.TB_ResX);
            this.panel1.Controls.Add(this.TB_ResY);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TB_FOV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 155);
            this.panel1.TabIndex = 8;
            // 
            // CB_HorizontalPlusFOV
            // 
            this.CB_HorizontalPlusFOV.AutoSize = true;
            this.CB_HorizontalPlusFOV.Checked = true;
            this.CB_HorizontalPlusFOV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_HorizontalPlusFOV.Location = new System.Drawing.Point(-1, 59);
            this.CB_HorizontalPlusFOV.Name = "CB_HorizontalPlusFOV";
            this.CB_HorizontalPlusFOV.Size = new System.Drawing.Size(73, 17);
            this.CB_HorizontalPlusFOV.TabIndex = 13;
            this.CB_HorizontalPlusFOV.Text = "Hor+ FOV";
            this.HorPlus_Tooltip.SetToolTip(this.CB_HorizontalPlusFOV, resources.GetString("CB_HorizontalPlusFOV.ToolTip"));
            this.CB_HorizontalPlusFOV.UseVisualStyleBackColor = true;
            this.CB_HorizontalPlusFOV.CheckedChanged += new System.EventHandler(this.CB_HorizontalPlusFOV_CheckedChanged);
            // 
            // LL_PCGW_link
            // 
            this.LL_PCGW_link.AutoSize = true;
            this.LL_PCGW_link.Location = new System.Drawing.Point(1, 128);
            this.LL_PCGW_link.Name = "LL_PCGW_link";
            this.LL_PCGW_link.Size = new System.Drawing.Size(78, 13);
            this.LL_PCGW_link.TabIndex = 12;
            this.LL_PCGW_link.TabStop = true;
            this.LL_PCGW_link.Text = "PCGamingWiki";
            this.LL_PCGW_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_PCGW_link_LinkClicked);
            // 
            // L_Byte3
            // 
            this.L_Byte3.AutoSize = true;
            this.L_Byte3.Location = new System.Drawing.Point(165, 42);
            this.L_Byte3.Name = "L_Byte3";
            this.L_Byte3.Size = new System.Drawing.Size(19, 13);
            this.L_Byte3.TabIndex = 11;
            this.L_Byte3.Text = "00";
            // 
            // L_Byte2
            // 
            this.L_Byte2.AutoSize = true;
            this.L_Byte2.Location = new System.Drawing.Point(111, 42);
            this.L_Byte2.Name = "L_Byte2";
            this.L_Byte2.Size = new System.Drawing.Size(19, 13);
            this.L_Byte2.TabIndex = 10;
            this.L_Byte2.Text = "00";
            // 
            // L_Byte1
            // 
            this.L_Byte1.AutoSize = true;
            this.L_Byte1.Location = new System.Drawing.Point(53, 42);
            this.L_Byte1.Name = "L_Byte1";
            this.L_Byte1.Size = new System.Drawing.Size(19, 13);
            this.L_Byte1.TabIndex = 9;
            this.L_Byte1.Text = "00";
            // 
            // L_Byte0
            // 
            this.L_Byte0.AutoSize = true;
            this.L_Byte0.Location = new System.Drawing.Point(2, 42);
            this.L_Byte0.Name = "L_Byte0";
            this.L_Byte0.Size = new System.Drawing.Size(19, 13);
            this.L_Byte0.TabIndex = 8;
            this.L_Byte0.Text = "00";
            // 
            // TB_FOV
            // 
            this.TB_FOV.Location = new System.Drawing.Point(-4, 16);
            this.TB_FOV.Name = "TB_FOV";
            this.TB_FOV.Size = new System.Drawing.Size(196, 20);
            this.TB_FOV.TabIndex = 3;
            this.TB_FOV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TB_FOV.TextChanged += new System.EventHandler(this.TB_FOV_Changed);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.donateLink);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 47);
            this.panel2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "SuicideMachine";
            // 
            // donateLink
            // 
            this.donateLink.AutoSize = true;
            this.donateLink.Location = new System.Drawing.Point(85, 20);
            this.donateLink.Name = "donateLink";
            this.donateLink.Size = new System.Drawing.Size(46, 13);
            this.donateLink.TabIndex = 12;
            this.donateLink.TabStop = true;
            this.donateLink.Text = "(donate)";
            this.donateLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DonateLink_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Credits:";
            // 
            // HorPlus_Tooltip
            // 
            this.HorPlus_Tooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.HorPlus_Tooltip.ToolTipTitle = "Horizontal+ FOV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 202);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Starship Troopers FOV Changer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_ResX;
        private System.Windows.Forms.TextBox TB_ResY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button B_WriteToAFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label L_Byte3;
        private System.Windows.Forms.Label L_Byte2;
        private System.Windows.Forms.Label L_Byte1;
        private System.Windows.Forms.Label L_Byte0;
        private System.Windows.Forms.LinkLabel LL_PCGW_link;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel donateLink;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox CB_HorizontalPlusFOV;
        private System.Windows.Forms.TextBox TB_FOV;
        private System.Windows.Forms.ToolTip HorPlus_Tooltip;
    }
}

