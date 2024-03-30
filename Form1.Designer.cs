namespace Get_Your_QR_Code
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            statusStrip1 = new StatusStrip();
            QRCodeStatus = new ToolStripStatusLabel();
            tabPage3 = new TabPage();
            groupBox3 = new GroupBox();
            button3 = new Button();
            label13 = new Label();
            label12 = new Label();
            groupBox2 = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            tabPage2 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            tabControl1 = new TabControl();
            tabPage4 = new TabPage();
            CodeSpawnSizeTextBox = new TextBox();
            label15 = new Label();
            button4 = new Button();
            label14 = new Label();
            statusStrip1.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { QRCodeStatus });
            statusStrip1.Location = new Point(0, 699);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // QRCodeStatus
            // 
            QRCodeStatus.Name = "QRCodeStatus";
            QRCodeStatus.Size = new Size(0, 16);
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(pictureBox2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 664);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "关于本程序";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Location = new Point(54, 363);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(682, 124);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "开源许可证";
            // 
            // button3
            // 
            button3.Location = new Point(523, 74);
            button3.Name = "button3";
            button3.Size = new Size(131, 29);
            button3.TabIndex = 4;
            button3.Text = "完整许可证协议";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(24, 78);
            label13.Name = "label13";
            label13.Size = new Size(189, 20);
            label13.TabIndex = 3;
            label13.Text = "点击右侧按钮查看详细协议";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(24, 37);
            label12.Name = "label12";
            label12.Size = new Size(270, 20);
            label12.TabIndex = 2;
            label12.Text = "本软件及开源库均遵循 MIT 许可证协议";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(54, 199);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(682, 124);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "制作人员及工具支持";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 73);
            label11.Name = "label11";
            label11.Size = new Size(547, 20);
            label11.TabIndex = 1;
            label11.Text = "Visual Studio 2022 - 可视化的开发环境使唯一的开发者从繁重的工作中脱离出来";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 32);
            label10.Name = "label10";
            label10.Size = new Size(408, 20);
            label10.TabIndex = 0;
            label10.Text = "Lavaver - 所有程序逻辑和界面设计都是完完全全一个人做的";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("等线", 20F);
            label9.ForeColor = SystemColors.AppWorkspace;
            label9.Location = new Point(641, 562);
            label9.Name = "label9";
            label9.Size = new Size(134, 36);
            label9.TabIndex = 6;
            label9.Text = "Build 10";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("等线", 30F);
            label8.ForeColor = SystemColors.AppWorkspace;
            label8.Location = new Point(522, 598);
            label8.Name = "label8";
            label8.Size = new Size(262, 53);
            label8.TabIndex = 5;
            label8.Text = "Version 1.0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 10F);
            label7.Location = new Point(59, 105);
            label7.Name = "label7";
            label7.Size = new Size(366, 23);
            label7.TabIndex = 4;
            label7.Text = "一款基于 WinForm 自由的二维码解决方案项目";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("等线", 24F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label6.Location = new Point(318, 47);
            label6.Name = "label6";
            label6.Size = new Size(110, 41);
            label6.TabIndex = 3;
            label6.Text = "Code";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("等线", 28F);
            label5.ForeColor = Color.MediumTurquoise;
            label5.Location = new Point(227, 41);
            label5.Name = "label5";
            label5.Size = new Size(85, 49);
            label5.TabIndex = 2;
            label5.Text = "QR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("等线", 24F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.Location = new Point(50, 47);
            label4.Name = "label4";
            label4.Size = new Size(171, 41);
            label4.TabIndex = 1;
            label4.Text = "Get Your";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(600, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 149);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 664);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "反向扫描二维码";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(616, 151);
            button2.Name = "button2";
            button2.Size = new Size(139, 29);
            button2.TabIndex = 5;
            button2.Text = "开始扫描";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(616, 102);
            button1.Name = "button1";
            button1.Size = new Size(139, 29);
            button1.TabIndex = 4;
            button1.Text = "查看正确扫描图例";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 84);
            label3.Name = "label3";
            label3.Size = new Size(429, 20);
            label3.TabIndex = 2;
            label3.Text = "完成后将根据二维码内容读取后显示在屏幕上或使用浏览器打开";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 52);
            label2.Name = "label2";
            label2.Size = new Size(339, 20);
            label2.TabIndex = 1;
            label2.Text = "扫描时请勿立即将含有二维码信息的物体迅速移出";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 23);
            label1.Name = "label1";
            label1.Size = new Size(219, 20);
            label1.TabIndex = 0;
            label1.Text = "请将二维码放置于你的摄像头下";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 664);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "生成二维码";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(47, 137);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(691, 505);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "实时生成结果";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(6, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(679, 473);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 47);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "在此处键入内容";
            textBox1.Size = new Size(525, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 697);
            tabControl1.TabIndex = 1;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(CodeSpawnSizeTextBox);
            tabPage4.Controls.Add(label15);
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(label14);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(792, 664);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "首选项";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // CodeSpawnSizeTextBox
            // 
            CodeSpawnSizeTextBox.Location = new Point(54, 137);
            CodeSpawnSizeTextBox.Name = "CodeSpawnSizeTextBox";
            CodeSpawnSizeTextBox.PlaceholderText = "必须为纯数字，为空自动调整";
            CodeSpawnSizeTextBox.Size = new Size(249, 27);
            CodeSpawnSizeTextBox.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(54, 100);
            label15.Name = "label15";
            label15.Size = new Size(144, 20);
            label15.TabIndex = 4;
            label15.Text = "限制二维码生成大小";
            // 
            // button4
            // 
            button4.Location = new Point(309, 136);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "应用";
            button4.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label14.ForeColor = SystemColors.AppWorkspace;
            label14.Location = new Point(40, 28);
            label14.Name = "label14";
            label14.Size = new Size(102, 52);
            label14.TabIndex = 2;
            label14.Text = "主要";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(800, 721);
            Controls.Add(tabControl1);
            Controls.Add(statusStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "获取你的二维码";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel QRCodeStatus;
        private TabPage tabPage3;
        private GroupBox groupBox3;
        private Button button3;
        private Label label13;
        private Label label12;
        private GroupBox groupBox2;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox2;
        private TabPage tabPage2;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TabControl tabControl1;
        private TabPage tabPage4;
        private Label label15;
        private Button button4;
        private Label label14;
        private TextBox CodeSpawnSizeTextBox;
    }
}
