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
            label7 = new Label();
            SpawnWLANQRCodeBtn = new Button();
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
            label3.Location = new Point(38, 181);
            label3.Name = "label3";
            label3.Size = new Size(88, 45);
            label3.TabIndex = 3;
            label3.Text = "安全";
            // 
            // WLANTextboxPASSWORD
            // 
            WLANTextboxPASSWORD.Location = new Point(51, 276);
            WLANTextboxPASSWORD.Name = "WLANTextboxPASSWORD";
            WLANTextboxPASSWORD.PlaceholderText = "输入网络密码，若无密码可直接留白。密码为隐藏状态，只需确保输入正确即可";
            WLANTextboxPASSWORD.Size = new Size(543, 27);
            WLANTextboxPASSWORD.TabIndex = 5;
            WLANTextboxPASSWORD.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 244);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 4;
            label4.Text = "网络密码";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 491);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 9;
            // 
            // SpawnWLANQRCodeBtn
            // 
            SpawnWLANQRCodeBtn.Location = new Point(578, 540);
            SpawnWLANQRCodeBtn.Name = "SpawnWLANQRCodeBtn";
            SpawnWLANQRCodeBtn.Size = new Size(190, 61);
            SpawnWLANQRCodeBtn.TabIndex = 11;
            SpawnWLANQRCodeBtn.Text = "生成二维码";
            SpawnWLANQRCodeBtn.UseVisualStyleBackColor = true;
            SpawnWLANQRCodeBtn.Click += SpawnWLANQRCodeBtn_Click;
            // 
            // MouldSpawn_WLAN
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 624);
            Controls.Add(SpawnWLANQRCodeBtn);
            Controls.Add(label7);
            Controls.Add(WLANTextboxPASSWORD);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(WLANTextboxSSID);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label7;
        private Button SpawnWLANQRCodeBtn;
    }
}