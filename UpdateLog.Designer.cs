﻿namespace Get_Your_QR_Code
{
    partial class UpdateLog
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
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(660, 565);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "重磅更新 3.0\n---------------------------\n[+] 酝酿了好久咱终于把二维码识别功能搬上来啦，在此特别感谢 OpenCvSharp 库的支持！\n[=] 修复了一些问题\n";
            // 
            // UpdateLog
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(684, 589);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdateLog";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "更新日志";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
    }
}