﻿namespace BeautyForestAgent
{
    partial class FormOpinion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpinion));
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlsMenu = new System.Windows.Forms.ToolStrip();
            this.fontDlg = new System.Windows.Forms.FontDialog();
            this.colorDlg = new System.Windows.Forms.ColorDialog();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.tsbtnFont = new System.Windows.Forms.ToolStripButton();
            this.tsbtnColor = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.tlsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 204);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "제출";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 251);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(297, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(120, 17);
            this.toolStripStatusLabel1.Text = "건의사항 - 폰트 변경";
            // 
            // tlsMenu
            // 
            this.tlsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnFont,
            this.tsbtnColor});
            this.tlsMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsMenu.Name = "tlsMenu";
            this.tlsMenu.Size = new System.Drawing.Size(297, 25);
            this.tlsMenu.TabIndex = 2;
            this.tlsMenu.Text = "toolStrip1";
            // 
            // rtbText
            // 
            this.rtbText.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbText.Location = new System.Drawing.Point(0, 25);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(297, 174);
            this.rtbText.TabIndex = 3;
            this.rtbText.Text = resources.GetString("rtbText.Text");
            // 
            // tsbtnFont
            // 
            this.tsbtnFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFont.Image = global::BeautyForestAgent.Properties.Resources.tsbtnFont;
            this.tsbtnFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFont.Name = "tsbtnFont";
            this.tsbtnFont.Size = new System.Drawing.Size(23, 22);
            this.tsbtnFont.Text = "toolStripButton1";
            // 
            // tsbtnColor
            // 
            this.tsbtnColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnColor.Image = global::BeautyForestAgent.Properties.Resources.tsbtnColor;
            this.tsbtnColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnColor.Name = "tsbtnColor";
            this.tsbtnColor.Size = new System.Drawing.Size(23, 22);
            this.tsbtnColor.Text = "toolStripButton1";
            // 
            // FormOpinion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 273);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.tlsMenu);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormOpinion";
            this.Text = "FormOpinion";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tlsMenu.ResumeLayout(false);
            this.tlsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip tlsMenu;
        private System.Windows.Forms.FontDialog fontDlg;
        private System.Windows.Forms.ColorDialog colorDlg;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.ToolStripButton tsbtnFont;
        private System.Windows.Forms.ToolStripButton tsbtnColor;
    }
}