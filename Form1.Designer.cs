﻿namespace Get_Your_QR_Code
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
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            保存二维码ToolStripMenuItem = new ToolStripMenuItem();
            至桌面ToolStripMenuItem = new ToolStripMenuItem();
            其他路径ToolStripMenuItem = new ToolStripMenuItem();
            保存键入内容至缓存文件ToolStripMenuItem = new ToolStripMenuItem();
            加载缓存文件内容ToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            重置底部状态栏ToolStripMenuItem = new ToolStripMenuItem();
            关闭选项ToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            图片Base64分块大小ToolStripMenuItem = new ToolStripMenuItem();
            区块二维码体积最小但生成量和占用呈几何倍增ToolStripMenuItem = new ToolStripMenuItem();
            区块ToolStripMenuItem = new ToolStripMenuItem();
            h区块ToolStripMenuItem1 = new ToolStripMenuItem();
            区块默认ToolStripMenuItem = new ToolStripMenuItem();
            区块最大ToolStripMenuItem = new ToolStripMenuItem();
            该选项的作用ToolStripMenuItem = new ToolStripMenuItem();
            模板生成ToolStripMenuItem = new ToolStripMenuItem();
            带有WLAN信息的二维码ToolStripMenuItem = new ToolStripMenuItem();
            带有Unix时间戳的二维码ToolStripMenuItem = new ToolStripMenuItem();
            带有UUID信息的二维码ToolStripMenuItem = new ToolStripMenuItem();
            eCC纠错级别ToolStripMenuItem = new ToolStripMenuItem();
            l低纠错7ToolStripMenuItem = new ToolStripMenuItem();
            m中等纠错15ToolStripMenuItem = new ToolStripMenuItem();
            q较高容错25ToolStripMenuItem = new ToolStripMenuItem();
            h精密容错30ToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            tabPage3 = new TabPage();
            groupBox3 = new GroupBox();
            button1 = new Button();
            button3 = new Button();
            label13 = new Label();
            label12 = new Label();
            groupBox2 = new GroupBox();
            UpdateLogBtn = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            tabPage1 = new TabPage();
            Help1 = new Button();
            UpLoadPictureBtn = new Button();
            label14 = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            button2 = new Button();
            label1 = new Label();
            groupBox4 = new GroupBox();
            pictureBox3 = new PictureBox();
            textBox2 = new TextBox();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { QRCodeStatus });
            statusStrip1.Location = new Point(0, 728);
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
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { 保存二维码ToolStripMenuItem, 保存键入内容至缓存文件ToolStripMenuItem, 加载缓存文件内容ToolStripMenuItem, toolStripMenuItem1, 重置底部状态栏ToolStripMenuItem, 关闭选项ToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(53, 24);
            toolStripDropDownButton1.Text = "常规";
            toolStripDropDownButton1.ToolTipText = "基础控件";
            // 
            // 保存二维码ToolStripMenuItem
            // 
            保存二维码ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 至桌面ToolStripMenuItem, 其他路径ToolStripMenuItem });
            保存二维码ToolStripMenuItem.Name = "保存二维码ToolStripMenuItem";
            保存二维码ToolStripMenuItem.Size = new Size(257, 26);
            保存二维码ToolStripMenuItem.Text = "保存二维码...";
            // 
            // 至桌面ToolStripMenuItem
            // 
            至桌面ToolStripMenuItem.Name = "至桌面ToolStripMenuItem";
            至桌面ToolStripMenuItem.Size = new Size(152, 26);
            至桌面ToolStripMenuItem.Text = "至桌面";
            至桌面ToolStripMenuItem.Click += 至桌面ToolStripMenuItem_Click;
            // 
            // 其他路径ToolStripMenuItem
            // 
            其他路径ToolStripMenuItem.Name = "其他路径ToolStripMenuItem";
            其他路径ToolStripMenuItem.Size = new Size(152, 26);
            其他路径ToolStripMenuItem.Text = "其他路径";
            其他路径ToolStripMenuItem.Click += 其他路径ToolStripMenuItem_Click;
            // 
            // 保存键入内容至缓存文件ToolStripMenuItem
            // 
            保存键入内容至缓存文件ToolStripMenuItem.Name = "保存键入内容至缓存文件ToolStripMenuItem";
            保存键入内容至缓存文件ToolStripMenuItem.Size = new Size(257, 26);
            保存键入内容至缓存文件ToolStripMenuItem.Text = "保存键入内容至缓存文件";
            保存键入内容至缓存文件ToolStripMenuItem.Click += 保存键入内容至缓存文件ToolStripMenuItem_Click;
            // 
            // 加载缓存文件内容ToolStripMenuItem
            // 
            加载缓存文件内容ToolStripMenuItem.Name = "加载缓存文件内容ToolStripMenuItem";
            加载缓存文件内容ToolStripMenuItem.Size = new Size(257, 26);
            加载缓存文件内容ToolStripMenuItem.Text = "加载缓存过的键入内容";
            加载缓存文件内容ToolStripMenuItem.Click += 加载缓存文件内容ToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(257, 26);
            toolStripMenuItem1.Text = "清除实时生成的二维码";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // 重置底部状态栏ToolStripMenuItem
            // 
            重置底部状态栏ToolStripMenuItem.Name = "重置底部状态栏ToolStripMenuItem";
            重置底部状态栏ToolStripMenuItem.Size = new Size(257, 26);
            重置底部状态栏ToolStripMenuItem.Text = "重置底部状态栏";
            重置底部状态栏ToolStripMenuItem.Click += 重置底部状态栏ToolStripMenuItem_Click;
            // 
            // 关闭选项ToolStripMenuItem
            // 
            关闭选项ToolStripMenuItem.Name = "关闭选项ToolStripMenuItem";
            关闭选项ToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
            关闭选项ToolStripMenuItem.Size = new Size(257, 26);
            关闭选项ToolStripMenuItem.Text = "关闭程序";
            关闭选项ToolStripMenuItem.Click += 关闭选项ToolStripMenuItem_Click;
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { 图片Base64分块大小ToolStripMenuItem, 模板生成ToolStripMenuItem, eCC纠错级别ToolStripMenuItem });
            toolStripDropDownButton2.Image = (Image)resources.GetObject("toolStripDropDownButton2.Image");
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(53, 24);
            toolStripDropDownButton2.Text = "生成";
            toolStripDropDownButton2.ToolTipText = "二维码生成行为及模板生成";
            // 
            // 图片Base64分块大小ToolStripMenuItem
            // 
            图片Base64分块大小ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 区块二维码体积最小但生成量和占用呈几何倍增ToolStripMenuItem, 区块ToolStripMenuItem, h区块ToolStripMenuItem1, 区块默认ToolStripMenuItem, 区块最大ToolStripMenuItem, 该选项的作用ToolStripMenuItem });
            图片Base64分块大小ToolStripMenuItem.Name = "图片Base64分块大小ToolStripMenuItem";
            图片Base64分块大小ToolStripMenuItem.Size = new Size(241, 26);
            图片Base64分块大小ToolStripMenuItem.Text = "图片 Base64 分块大小";
            图片Base64分块大小ToolStripMenuItem.ToolTipText = "划分区块大小以减少渲染时间和张数";
            // 
            // 区块二维码体积最小但生成量和占用呈几何倍增ToolStripMenuItem
            // 
            区块二维码体积最小但生成量和占用呈几何倍增ToolStripMenuItem.Name = "区块二维码体积最小但生成量和占用呈几何倍增ToolStripMenuItem";
            区块二维码体积最小但生成量和占用呈几何倍增ToolStripMenuItem.Size = new Size(474, 26);
            区块二维码体积最小但生成量和占用呈几何倍增ToolStripMenuItem.Text = "10 区块（二维码体积最小，但生成量和占用呈几何倍增）";
            区块二维码体积最小但生成量和占用呈几何倍增ToolStripMenuItem.Click += 区块二维码体积最小但生成量和占用呈几何倍增ToolStripMenuItem_Click;
            // 
            // 区块ToolStripMenuItem
            // 
            区块ToolStripMenuItem.Name = "区块ToolStripMenuItem";
            区块ToolStripMenuItem.Size = new Size(474, 26);
            区块ToolStripMenuItem.Text = "50 区块";
            区块ToolStripMenuItem.Click += 区块ToolStripMenuItem_Click;
            // 
            // h区块ToolStripMenuItem1
            // 
            h区块ToolStripMenuItem1.Name = "h区块ToolStripMenuItem1";
            h区块ToolStripMenuItem1.Size = new Size(474, 26);
            h区块ToolStripMenuItem1.Text = "100 区块";
            h区块ToolStripMenuItem1.Click += h区块ToolStripMenuItem1_Click;
            // 
            // 区块默认ToolStripMenuItem
            // 
            区块默认ToolStripMenuItem.Checked = true;
            区块默认ToolStripMenuItem.CheckState = CheckState.Checked;
            区块默认ToolStripMenuItem.Name = "区块默认ToolStripMenuItem";
            区块默认ToolStripMenuItem.Size = new Size(474, 26);
            区块默认ToolStripMenuItem.Text = "500 区块（默认）";
            区块默认ToolStripMenuItem.Click += 区块默认ToolStripMenuItem_Click;
            // 
            // 区块最大ToolStripMenuItem
            // 
            区块最大ToolStripMenuItem.Name = "区块最大ToolStripMenuItem";
            区块最大ToolStripMenuItem.Size = new Size(474, 26);
            区块最大ToolStripMenuItem.Text = "1000 区块（最大）";
            区块最大ToolStripMenuItem.Click += 区块最大ToolStripMenuItem_Click;
            // 
            // 该选项的作用ToolStripMenuItem
            // 
            该选项的作用ToolStripMenuItem.Name = "该选项的作用ToolStripMenuItem";
            该选项的作用ToolStripMenuItem.Size = new Size(474, 26);
            该选项的作用ToolStripMenuItem.Text = "该选项的作用";
            该选项的作用ToolStripMenuItem.Click += 该选项的作用ToolStripMenuItem_Click;
            // 
            // 模板生成ToolStripMenuItem
            // 
            模板生成ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 带有WLAN信息的二维码ToolStripMenuItem, 带有Unix时间戳的二维码ToolStripMenuItem, 带有UUID信息的二维码ToolStripMenuItem });
            模板生成ToolStripMenuItem.Name = "模板生成ToolStripMenuItem";
            模板生成ToolStripMenuItem.Size = new Size(241, 26);
            模板生成ToolStripMenuItem.Text = "模板生成";
            模板生成ToolStripMenuItem.ToolTipText = "通过模板快速生成特定格式二维码";
            // 
            // 带有WLAN信息的二维码ToolStripMenuItem
            // 
            带有WLAN信息的二维码ToolStripMenuItem.Name = "带有WLAN信息的二维码ToolStripMenuItem";
            带有WLAN信息的二维码ToolStripMenuItem.Size = new Size(267, 26);
            带有WLAN信息的二维码ToolStripMenuItem.Text = "带有 WLAN 信息的二维码";
            带有WLAN信息的二维码ToolStripMenuItem.Click += 带有WLAN信息的二维码ToolStripMenuItem_Click;
            // 
            // 带有Unix时间戳的二维码ToolStripMenuItem
            // 
            带有Unix时间戳的二维码ToolStripMenuItem.Name = "带有Unix时间戳的二维码ToolStripMenuItem";
            带有Unix时间戳的二维码ToolStripMenuItem.Size = new Size(267, 26);
            带有Unix时间戳的二维码ToolStripMenuItem.Text = "带有 Unix 时间戳的二维码";
            带有Unix时间戳的二维码ToolStripMenuItem.Click += 带有Unix时间戳的二维码ToolStripMenuItem_Click;
            // 
            // 带有UUID信息的二维码ToolStripMenuItem
            // 
            带有UUID信息的二维码ToolStripMenuItem.Name = "带有UUID信息的二维码ToolStripMenuItem";
            带有UUID信息的二维码ToolStripMenuItem.Size = new Size(267, 26);
            带有UUID信息的二维码ToolStripMenuItem.Text = "带有 UUID 信息的二维码";
            带有UUID信息的二维码ToolStripMenuItem.Click += 带有UUID信息的二维码ToolStripMenuItem_Click;
            // 
            // eCC纠错级别ToolStripMenuItem
            // 
            eCC纠错级别ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { l低纠错7ToolStripMenuItem, m中等纠错15ToolStripMenuItem, q较高容错25ToolStripMenuItem, h精密容错30ToolStripMenuItem });
            eCC纠错级别ToolStripMenuItem.Name = "eCC纠错级别ToolStripMenuItem";
            eCC纠错级别ToolStripMenuItem.Size = new Size(241, 26);
            eCC纠错级别ToolStripMenuItem.Text = "ECC 纠错级别";
            eCC纠错级别ToolStripMenuItem.ToolTipText = "设置容错级别以帮助在恶劣环境下仍能读取信息";
            // 
            // l低纠错7ToolStripMenuItem
            // 
            l低纠错7ToolStripMenuItem.Checked = true;
            l低纠错7ToolStripMenuItem.CheckState = CheckState.Checked;
            l低纠错7ToolStripMenuItem.Name = "l低纠错7ToolStripMenuItem";
            l低纠错7ToolStripMenuItem.Size = new Size(243, 26);
            l低纠错7ToolStripMenuItem.Text = "L（低容错，7%）";
            l低纠错7ToolStripMenuItem.Click += l低纠错7ToolStripMenuItem_Click;
            // 
            // m中等纠错15ToolStripMenuItem
            // 
            m中等纠错15ToolStripMenuItem.Name = "m中等纠错15ToolStripMenuItem";
            m中等纠错15ToolStripMenuItem.Size = new Size(243, 26);
            m中等纠错15ToolStripMenuItem.Text = "M（中等容错，15%）";
            m中等纠错15ToolStripMenuItem.Click += m中等纠错15ToolStripMenuItem_Click;
            // 
            // q较高容错25ToolStripMenuItem
            // 
            q较高容错25ToolStripMenuItem.Name = "q较高容错25ToolStripMenuItem";
            q较高容错25ToolStripMenuItem.Size = new Size(243, 26);
            q较高容错25ToolStripMenuItem.Text = "Q（高容错，25%）";
            q较高容错25ToolStripMenuItem.Click += q较高容错25ToolStripMenuItem_Click;
            // 
            // h精密容错30ToolStripMenuItem
            // 
            h精密容错30ToolStripMenuItem.Name = "h精密容错30ToolStripMenuItem";
            h精密容错30ToolStripMenuItem.Size = new Size(243, 26);
            h精密容错30ToolStripMenuItem.Text = "H（精密容错，30%）";
            h精密容错30ToolStripMenuItem.Click += h精密容错30ToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripDropDownButton2, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(191, 24);
            toolStripButton1.Text = "上报问题至 GitHub Issues";
            toolStripButton1.ToolTipText = "上报问题至 GitHub Issues ，并获得第一时间反馈";
            toolStripButton1.Click += toolStripButton1_Click;
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
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Location = new Point(54, 388);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(682, 124);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "开源许可证";
            // 
            // button1
            // 
            button1.Location = new Point(386, 74);
            button1.Name = "button1";
            button1.Size = new Size(131, 29);
            button1.TabIndex = 6;
            button1.Text = "开源库许可证";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            label12.Size = new Size(195, 20);
            label12.TabIndex = 2;
            label12.Text = "本软件遵循 MIT 许可证协议";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(UpdateLogBtn);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(54, 199);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(682, 158);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "制作人员及工具支持";
            // 
            // UpdateLogBtn
            // 
            UpdateLogBtn.Location = new Point(523, 112);
            UpdateLogBtn.Name = "UpdateLogBtn";
            UpdateLogBtn.Size = new Size(131, 29);
            UpdateLogBtn.TabIndex = 5;
            UpdateLogBtn.Text = "新增功能";
            UpdateLogBtn.UseVisualStyleBackColor = true;
            UpdateLogBtn.Click += UpdateLogBtn_Click;
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
            label9.Location = new Point(546, 562);
            label9.Name = "label9";
            label9.Size = new Size(238, 36);
            label9.TabIndex = 6;
            label9.Text = "Build 8624-RW";
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
            label8.Text = "Version 3.4";
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
            // tabPage1
            // 
            tabPage1.Controls.Add(Help1);
            tabPage1.Controls.Add(UpLoadPictureBtn);
            tabPage1.Controls.Add(label14);
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
            // Help1
            // 
            Help1.Location = new Point(558, 89);
            Help1.Name = "Help1";
            Help1.Size = new Size(94, 29);
            Help1.TabIndex = 5;
            Help1.Text = "如何运作";
            Help1.UseVisualStyleBackColor = true;
            Help1.Click += Help1_Click_1;
            // 
            // UpLoadPictureBtn
            // 
            UpLoadPictureBtn.Location = new Point(462, 89);
            UpLoadPictureBtn.Name = "UpLoadPictureBtn";
            UpLoadPictureBtn.Size = new Size(94, 29);
            UpLoadPictureBtn.TabIndex = 4;
            UpLoadPictureBtn.Text = "选择图片";
            UpLoadPictureBtn.UseVisualStyleBackColor = true;
            UpLoadPictureBtn.Click += UpLoadPictureBtn_Click_1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(127, 93);
            label14.Name = "label14";
            label14.Size = new Size(264, 20);
            label14.TabIndex = 3;
            label14.Text = "或者，你也可以用图片制作你的二维码";
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
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 28);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 697);
            tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(792, 664);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "解析二维码";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(562, 81);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "选择图片";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 85);
            label1.Name = "label1";
            label1.Size = new Size(294, 20);
            label1.TabIndex = 8;
            label1.Text = "点击右侧按钮选择图片，程序自动开始解析";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(pictureBox3);
            groupBox4.Location = new Point(51, 135);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(691, 495);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "待解析内容预览";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(6, 26);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(679, 473);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 35);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "反馈内容";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(525, 27);
            textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 750);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "获取你的二维码";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel QRCodeStatus;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem 保存二维码ToolStripMenuItem;
        private ToolStripMenuItem 至桌面ToolStripMenuItem;
        private ToolStripMenuItem 其他路径ToolStripMenuItem;
        private ToolStripMenuItem 保存键入内容至缓存文件ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem 重置底部状态栏ToolStripMenuItem;
        private ToolStripMenuItem 关闭选项ToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem 图片Base64分块大小ToolStripMenuItem;
        private ToolStripMenuItem 区块二维码体积最小但生成量和占用呈几何倍增ToolStripMenuItem;
        private ToolStripMenuItem 区块ToolStripMenuItem;
        private ToolStripMenuItem h区块ToolStripMenuItem1;
        private ToolStripMenuItem 区块默认ToolStripMenuItem;
        private ToolStripMenuItem 区块最大ToolStripMenuItem;
        private ToolStripMenuItem 该选项的作用ToolStripMenuItem;
        private ToolStripMenuItem 模板生成ToolStripMenuItem;
        private ToolStripMenuItem 带有WLAN信息的二维码ToolStripMenuItem;
        private ToolStrip toolStrip1;
        private TabPage tabPage3;
        private GroupBox groupBox3;
        private Button button3;
        private Label label13;
        private Label label12;
        private GroupBox groupBox2;
        private Button UpdateLogBtn;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox2;
        private TabPage tabPage1;
        private Label label14;
        private GroupBox groupBox1;
        public PictureBox pictureBox1;
        private TextBox textBox1;
        private TabControl tabControl1;
        private Button Help1;
        private Button UpLoadPictureBtn;
        private ToolStripMenuItem 加载缓存文件内容ToolStripMenuItem;
        private ToolStripMenuItem 带有Unix时间戳的二维码ToolStripMenuItem;
        private ToolStripMenuItem eCC纠错级别ToolStripMenuItem;
        private ToolStripMenuItem l低纠错7ToolStripMenuItem;
        private ToolStripMenuItem m中等纠错15ToolStripMenuItem;
        private ToolStripMenuItem q较高容错25ToolStripMenuItem;
        private ToolStripMenuItem h精密容错30ToolStripMenuItem;
        private TabPage tabPage2;
        private GroupBox groupBox4;
        public PictureBox pictureBox3;
        private TextBox textBox2;
        private Button button2;
        private Label label1;
        private Button button1;
        private ToolStripMenuItem 带有UUID信息的二维码ToolStripMenuItem;
        private ToolStripButton toolStripButton1;
    }
}
