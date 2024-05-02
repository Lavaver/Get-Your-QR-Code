namespace Get_Your_QR_Code
{
    partial class MouldSpawn_UUID
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
            button1 = new Button();
            SpawnUUIDQRCodeBtn = new Button();
            listBox1 = new ListBox();
            label3 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 20F);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(46, 42);
            label1.Name = "label1";
            label1.Size = new Size(490, 45);
            label1.TabIndex = 1;
            label1.Text = "在列表中选择一个喜欢的 UUID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 480);
            label2.Name = "label2";
            label2.Size = new Size(189, 20);
            label2.TabIndex = 3;
            label2.Text = "若都不满意，你可以尝试：";
            // 
            // button1
            // 
            button1.Location = new Point(54, 512);
            button1.Name = "button1";
            button1.Size = new Size(144, 29);
            button1.TabIndex = 4;
            button1.Text = "刷新新一批 UUID";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SpawnUUIDQRCodeBtn
            // 
            SpawnUUIDQRCodeBtn.Location = new Point(645, 480);
            SpawnUUIDQRCodeBtn.Name = "SpawnUUIDQRCodeBtn";
            SpawnUUIDQRCodeBtn.Size = new Size(190, 29);
            SpawnUUIDQRCodeBtn.TabIndex = 12;
            SpawnUUIDQRCodeBtn.Text = "生成二维码";
            SpawnUUIDQRCodeBtn.UseVisualStyleBackColor = true;
            SpawnUUIDQRCodeBtn.Click += SpawnUUIDQRCodeBtn_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(54, 114);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(781, 324);
            listBox1.TabIndex = 13;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 516);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 14;
            label3.Text = "或";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(234, 512);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "自主定义一个喜欢的 UUID";
            textBox1.Size = new Size(326, 27);
            textBox1.TabIndex = 15;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(645, 512);
            button2.Name = "button2";
            button2.Size = new Size(190, 40);
            button2.TabIndex = 16;
            button2.Text = "传入到主界面";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MouldSpawn_UUID
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(893, 587);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(SpawnUUIDQRCodeBtn);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MouldSpawn_UUID";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "模板生成：带有 UUID 信息的二维码";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button SpawnUUIDQRCodeBtn;
        private ListBox listBox1;
        private Label label3;
        private TextBox textBox1;
        private Button button2;
    }
}