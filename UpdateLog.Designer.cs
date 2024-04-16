namespace Get_Your_QR_Code
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
            richTextBox1.Text = "软件更新 2.5\n---------------------------\n[+] “模板生成”功能添加带有 Unix 时间戳的二维码选项\n[+] ”生成“选项卡新增”ECC 纠错“菜单。用户现在可从四种标准的 ECC 纠错方式中选择任意一种\n[+] 实装存储输入到缓存文件及读取、保存二维码到其他位置的功能\n[=] 修复了一些问题\n";
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