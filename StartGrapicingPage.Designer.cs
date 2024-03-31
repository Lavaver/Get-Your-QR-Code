namespace Get_Your_QR_Code
{
    partial class StartGrapicingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartGrapicingPage));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(47, 36);
            label1.Name = "label1";
            label1.Size = new Size(382, 52);
            label1.TabIndex = 0;
            label1.Text = "二维码的渲染已提交";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 128);
            label2.Name = "label2";
            label2.Size = new Size(291, 20);
            label2.TabIndex = 1;
            label2.Text = "你可以在程序底部的“任务栏”查看渲染进度";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 165);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 2;
            label3.Text = "渲染完成后将提示您";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 206);
            label4.Name = "label4";
            label4.Size = new Size(264, 20);
            label4.TabIndex = 3;
            label4.Text = "你可以点击关闭窗口按钮继续你的工作";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(485, 151);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(374, 182);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(524, 339);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // StartGrapicingPage
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(907, 501);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StartGrapicingPage";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "渲染任务已提交";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}