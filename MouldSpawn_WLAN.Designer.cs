namespace Get_Your_QR_Code
{
    partial class MouldSpawn_WLAN
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
            label1 = new Label();
            label2 = new Label();
            WLANTextboxSSID = new TextBox();
            label3 = new Label();
            WLANTextboxPASSWORD = new TextBox();
            label4 = new Label();
            SpawnWLANQRCodeBtn = new Button();
            label5 = new Label();
            comboBox1 = new ComboBox();
            linkLabel1 = new LinkLabel();
            AutoGetSSIDBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 20F);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(38, 34);
            label1.Name = "label1";
            label1.Size = new Size(88, 45);
            label1.TabIndex = 0;
            label1.Text = "常规";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 93);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 1;
            label2.Text = "网络名称（SSID）";
            // 
            // WLANTextboxSSID
            // 
            WLANTextboxSSID.Location = new Point(51, 125);
            WLANTextboxSSID.Name = "WLANTextboxSSID";
            WLANTextboxSSID.PlaceholderText = "输入网络名称（SSID）";
            WLANTextboxSSID.Size = new Size(283, 27);
            WLANTextboxSSID.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 20F);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(38, 193);
            label3.Name = "label3";
            label3.Size = new Size(88, 45);
            label3.TabIndex = 3;
            label3.Text = "安全";
            // 
            // WLANTextboxPASSWORD
            // 
            WLANTextboxPASSWORD.Location = new Point(51, 286);
            WLANTextboxPASSWORD.Name = "WLANTextboxPASSWORD";
            WLANTextboxPASSWORD.PlaceholderText = "输入网络密码，若无密码可直接留白。密码为隐藏状态，只需确保输入正确即可";
            WLANTextboxPASSWORD.Size = new Size(543, 27);
            WLANTextboxPASSWORD.TabIndex = 5;
            WLANTextboxPASSWORD.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 254);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 4;
            label4.Text = "网络密码";
            // 
            // SpawnWLANQRCodeBtn
            // 
            SpawnWLANQRCodeBtn.Location = new Point(572, 458);
            SpawnWLANQRCodeBtn.Name = "SpawnWLANQRCodeBtn";
            SpawnWLANQRCodeBtn.Size = new Size(190, 61);
            SpawnWLANQRCodeBtn.TabIndex = 11;
            SpawnWLANQRCodeBtn.Text = "生成二维码";
            SpawnWLANQRCodeBtn.UseVisualStyleBackColor = true;
            SpawnWLANQRCodeBtn.Click += SpawnWLANQRCodeBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 339);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 12;
            label5.Text = "加密方式";
            // 
            // comboBox1
            // 
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "WEP", "WPA/WPA2-Personal", "WPA/WPA2-Enterprise", "WPA3" });
            comboBox1.Location = new Point(51, 378);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(232, 28);
            comboBox1.TabIndex = 13;
            comboBox1.Text = "此选项暂时不可用";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(300, 381);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(69, 20);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "如何选择";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // AutoGetSSIDBtn
            // 
            AutoGetSSIDBtn.Location = new Point(340, 125);
            AutoGetSSIDBtn.Name = "AutoGetSSIDBtn";
            AutoGetSSIDBtn.Size = new Size(94, 29);
            AutoGetSSIDBtn.TabIndex = 15;
            AutoGetSSIDBtn.Text = "自动获取";
            AutoGetSSIDBtn.UseVisualStyleBackColor = true;
            AutoGetSSIDBtn.Click += AutoGetSSIDBtn_Click;
            // 
            // MouldSpawn_WLAN
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 555);
            Controls.Add(AutoGetSSIDBtn);
            Controls.Add(linkLabel1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(SpawnWLANQRCodeBtn);
            Controls.Add(WLANTextboxPASSWORD);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(WLANTextboxSSID);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MouldSpawn_WLAN";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "模板生成：带有 WLAN 信息的二维码";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox WLANTextboxSSID;
        private Label label3;
        private TextBox WLANTextboxPASSWORD;
        private Label label4;
        private Button SpawnWLANQRCodeBtn;
        private Label label5;
        private ComboBox comboBox1;
        private LinkLabel linkLabel1;
        private Button AutoGetSSIDBtn;
    }
}