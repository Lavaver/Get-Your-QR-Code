using QRCoder;
using System.IO;
using System.Drawing.Imaging;
using static QRCoder.QRCodeGenerator;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using OpenCvSharp;
using ZXing;
using ZXing.QrCode;

namespace Get_Your_QR_Code
{

    public partial class Form1 : Form
    {

        private ECCLevel eccLevel;

        private bool generatingQRCode = false; // 标记生成二维码任务是否正在进行中

        private int ChunkSize = 500; // 设置块大小

        private string cacheFilePath;

        private string folderPath = "\\PageCachedFile";
        public Form1()
        {
            InitializeComponent();

            // 获取软件所在目录
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string cacheFolderPath = Path.Combine(appDirectory, "PageCachedFile");

            // 检查缓存文件夹是否存在，如果不存在则创建
            if (!Directory.Exists(cacheFolderPath))
            {
                Directory.CreateDirectory(cacheFolderPath);
            }

            // 拼接缓存文件的路径
            cacheFilePath = Path.Combine(cacheFolderPath, "cached_data.txt");

            // 在窗体加载时检查是否存在缓存文件，并加载内容到文本框
            this.Load += Form1_Load;

            this.FormClosing += Form1_Closing; // 手动绑定 Closing 事件

            eccLevel = ECCLevel.L;



            QRCodeStatus.Text = "就绪";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            // 检查缓存文件所在文件夹是否存在文件
            string cacheFolder = Path.GetDirectoryName(cacheFilePath);
            string[] filesInFolder = Directory.GetFiles(cacheFolder);
            if (filesInFolder.Length > 0)
            {
                // 存在文件，可以进行相应处理
                try
                {
                    // 检查缓存文件是否存在
                    if (File.Exists(cacheFilePath))
                    {
                        // 读取缓存文件的内容
                        string cachedContent = File.ReadAllText(cacheFilePath);

                        // 显示内容并等待用户确认
                        var result = MessageBox.Show("检测到存在缓存文件，是否加载内容到文本框？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        // 如果用户确认加载内容，则将内容显示在文本框中
                        if (result == DialogResult.Yes)
                        {
                            textBox1.Text = cachedContent;

                            // 加载完内容后删除缓存文件
                            File.Delete(cacheFilePath);

                            加载缓存文件内容ToolStripMenuItem.Enabled = false;
                            加载缓存文件内容ToolStripMenuItem.Text = "已读取过缓存文件";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("读取缓存文件时出现错误：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // 文件夹中没有文件，可以进行相应处理，比如禁用菜单项等
                加载缓存文件内容ToolStripMenuItem.Enabled = false;
                加载缓存文件内容ToolStripMenuItem.Text = "没有缓存文件";
            }
        }


        private void GenerateQRCode(string text)
        {
            try
            {
                QRCodeStatus.Text = "执行生成操作";
                // 根据内容长度确定二维码大小
                int size = CalculateQRCodeSize(text.Length);

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, eccLevel);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(size); // 设置二维码大小

                pictureBox1.Image = qrCodeImage;

                QRCodeStatus.Text = "生成成功";
            }
            catch (Exception log)
            {
                File.AppendAllText("Exception.log", "\r\n" + "--- 引发异常的上一位置中堆栈日志的末尾 ---\n" + log);
                QRCodeStatus.Text = "生成失败。引发异常的堆栈日志已保存在软件目录下";
            }

        }

        private int CalculateQRCodeSize(int contentLength)
        {
            // 根据内容长度来确定二维码的大小
            if (contentLength <= 50)
            {
                return 10;
            }
            else if (contentLength <= 100)
            {
                return 20;
            }
            else
            {
                return 30;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;
            GenerateQRCode(inputText);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("目前还在攻克这个问题啦...\n敬请期待", "功能未完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MIT_Lisence f2 = new MIT_Lisence();
            f2.Show();
        }

        private void 关闭选项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void 重置底部状态栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QRCodeStatus.Text = "就绪";
        }

        private async void UpLoadPictureBtn_Click_1(object sender, EventArgs e)
        {
            // 创建一个 OpenFileDialog 对象
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();

            // 设置文件对话框的属性
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "图片文件|*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            // 如果用户点击了确定按钮
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                try
                {

                    // 获取所选文件的路径
                    string selectedImagePath = openFileDialog.FileName;

                    // 弹出文件夹选择对话框
                    FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                    folderBrowserDialog.Description = "请选择保存位置";
                    folderBrowserDialog.ShowNewFolderButton = true;

                    // 如果用户点击了确定按钮
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        generatingQRCode = true;
                        string qrCodeFolderPath = folderBrowserDialog.SelectedPath;

                        StartGrapicingPage f3 = new StartGrapicingPage();
                        f3.Show();

                        QRCodeStatus.Text = "执行生成操作";

                        // 将选中的图片转换为Base64编码
                        string base64Image = await ConvertImageToBase64Async(selectedImagePath);

                        // 将Base64编码分成块
                        string[] chunks = ChunkBase64String(base64Image, ChunkSize);

                        // 逐个生成QR码并保存为图像文件
                        for (int i = 0; i < chunks.Length; i++)
                        {
                            string qrCodeFileName = Path.Combine(qrCodeFolderPath, $"qrcode_part_{i}.png");
                            await GenerateQRCodeAsync(chunks[i], qrCodeFileName);

                            // 更新渲染状态
                            QRCodeStatus.Text = $"正在渲染第 {i + 1} 张图片，共 {chunks.Length} 张";
                        }

                        // 更新QRCodeStatus文本框的内容
                        this.Invoke(new Action(() =>
                        {
                            QRCodeStatus.Text = $"生成成功。分块二维码文件已保存在所选位置";
                        }));

                        generatingQRCode = false;

                        MessageBox.Show($"生成成功。分块二维码文件已保存在所选位置", "渲染任务已全部完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("检测到你取消了选择操作\n你要保存在默认位置吗？", "你要保存在默认位置吗？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        // 如果用户点击了“确定”按钮
                        if (result == DialogResult.OK)
                        {
                            try
                            {
                                generatingQRCode = true;

                                StartGrapicingPage f3 = new StartGrapicingPage();
                                f3.Show();

                                QRCodeStatus.Text = "执行生成操作";

                                // 将选中的图片转换为Base64编码
                                string base64Image = await ConvertImageToBase64Async(selectedImagePath);

                                // 将Base64编码分成块
                                string[] chunks = ChunkBase64String(base64Image, ChunkSize);

                                // 获取当前日期的字符串表示形式，格式为 "yyyy-MM-dd"
                                string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

                                // 创建保存QR码图像的文件夹路径
                                string qrCodeFolderPath = Path.Combine(System.Windows.Forms.Application.StartupPath, $"QRCode_Picture_Packs_{currentDate}");

                                // 如果文件夹不存在，则创建它
                                if (!Directory.Exists(qrCodeFolderPath))
                                {
                                    Directory.CreateDirectory(qrCodeFolderPath);
                                }

                                // 逐个生成QR码并保存为图像文件
                                for (int i = 0; i < chunks.Length; i++)
                                {
                                    string qrCodeFileName = Path.Combine(System.Windows.Forms.Application.StartupPath, $"{qrCodeFolderPath}\\qrcode_part_{i}.png");
                                    await GenerateQRCodeAsync(chunks[i], qrCodeFileName);

                                    // 更新渲染状态
                                    QRCodeStatus.Text = $"正在渲染第 {i + 1} 张图片，共 {chunks.Length} 张";
                                }

                                // 更新QRCodeStatus文本框的内容
                                this.Invoke(new Action(() =>
                                {
                                    QRCodeStatus.Text = $"生成成功。分块二维码文件已保存在软件目录下的 /QRCode_Packs_[日期] 文件夹下";
                                }));

                                generatingQRCode = false;

                                MessageBox.Show($"生成成功。分块二维码文件已保存在软件目录下的 {qrCodeFolderPath} 文件夹下", "渲染任务已全部完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                generatingQRCode = false;
                                // 将异常信息记录到日志文件
                                File.AppendAllText("Exception.log", "\r\n" + "--- 引发异常的上一位置中堆栈日志的末尾 ---\n" + ex);
                                QRCodeStatus.Text = "生成失败。引发异常的堆栈日志已保存在软件目录下";
                            }
                        }
                        else
                        {
                            return;
                        }

                    }
                }
                catch (Exception ex)
                {
                    generatingQRCode = false;
                    // 将异常信息记录到日志文件
                    File.AppendAllText("Exception.log", "\r\n" + "--- 引发异常的上一位置中堆栈日志的末尾 ---\n" + ex);
                    QRCodeStatus.Text = "生成失败。引发异常的堆栈日志已保存在软件目录下";
                }
            }
        }

        // 将图片转换为Base64编码（异步版本）
        private async Task<string> ConvertImageToBase64Async(string imagePath)
        {
            return await Task.Run(() =>
            {
                using (System.Drawing.Image image = System.Drawing.Image.FromFile(imagePath))
                {
                    using (MemoryStream m = new MemoryStream())
                    {
                        image.Save(m, image.RawFormat);
                        byte[] imageBytes = m.ToArray();
                        return Convert.ToBase64String(imageBytes);
                    }
                }
            });
        }

        // 将Base64字符串分成指定大小的块
        private string[] ChunkBase64String(string base64String, int chunkSize)
        {
            int numChunks = (int)Math.Ceiling((double)base64String.Length / chunkSize);
            string[] chunks = new string[numChunks];
            for (int i = 0; i < numChunks; i++)
            {
                int offset = i * chunkSize;
                int chunkLength = chunkSize;
                if (offset + chunkSize > base64String.Length)
                {
                    chunkLength = base64String.Length - offset;
                }
                chunks[i] = base64String.Substring(offset, chunkLength);
            }
            return chunks;
        }


        private async Task GenerateQRCodeAsync(string data, string outputFileName)
        {
            await Task.Run(() =>
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, eccLevel);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);
                qrCodeImage.Save(outputFileName, System.Drawing.Imaging.ImageFormat.Png);
            });
        }

        private void Help1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("选择文件后，程序先将图片进行 Base64 转换，然后将转换后字符串进行分块操作\n完成后将逐个渲染每个区块对应的二维码并输出到软件目录下的 /QRCode_Packs_[日期] 文件夹下\n这个功能用来传输密报或许不错，但如果想要用这种方式来传输比较大的图片的话...\n...那你得做好不间断扫码、合并与转换三重心理打击的准备（", "帮助", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 区块二维码体积最小但生成量和占用呈几何倍增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 取消其他菜单项的选中状态
            区块ToolStripMenuItem.Checked = false;
            h区块ToolStripMenuItem1.Checked = false;
            区块默认ToolStripMenuItem.Checked = false;
            区块最大ToolStripMenuItem.Checked = false;
            // 设置当前菜单项的选中状态
            区块二维码体积最小但生成量和占用呈几何倍增ToolStripMenuItem.Checked = true;

            ChunkSize = 10;
        }

        private void 区块ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            区块ToolStripMenuItem.Checked = true;
            h区块ToolStripMenuItem1.Checked = false;
            区块默认ToolStripMenuItem.Checked = false;
            区块最大ToolStripMenuItem.Checked = false;
            区块二维码体积最小但生成量和占用呈几何倍增ToolStripMenuItem.Checked = false;

            ChunkSize = 50;
        }

        private void h区块ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            区块ToolStripMenuItem.Checked = false;
            h区块ToolStripMenuItem1.Checked = true;
            区块默认ToolStripMenuItem.Checked = false;
            区块最大ToolStripMenuItem.Checked = false;
            区块二维码体积最小但生成量和占用呈几何倍增ToolStripMenuItem.Checked = false;

            ChunkSize = 100;
        }

        private void 区块默认ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            区块ToolStripMenuItem.Checked = false;
            h区块ToolStripMenuItem1.Checked = false;
            区块默认ToolStripMenuItem.Checked = true;
            区块最大ToolStripMenuItem.Checked = false;
            区块二维码体积最小但生成量和占用呈几何倍增ToolStripMenuItem.Checked = false;

            ChunkSize = 500;
        }

        private void 区块最大ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            区块ToolStripMenuItem.Checked = false;
            h区块ToolStripMenuItem1.Checked = false;
            区块默认ToolStripMenuItem.Checked = false;
            区块最大ToolStripMenuItem.Checked = true;
            区块二维码体积最小但生成量和占用呈几何倍增ToolStripMenuItem.Checked = false;

            ChunkSize = 1000;
        }

        private void 该选项的作用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("设置 Base64 区块大小可最大限度地缩短渲染时间和张数。\n设置的区块越大，在面对分辨率较高的图片时也能确保生成的每张二维码承载的信息量能最大限度地减少渲染张数和时间。", "使用说明", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = null;
                QRCodeStatus.Text = "成功的操作";
            }
            catch
            {
                QRCodeStatus.Text = "失败的操作";
            }
        }
        private string GenerateRandomFileName()
        {
            // 生成随机文件名，由英文和数字组成
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, 8)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void RenderToDesktop()
        {
            if (pictureBox1.Image == null)
            {
                QRCodeStatus.Text = "失败的操作。检测到实时生成结果框内无二维码存在";
            }
            else
            {
                using (Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height))
                {
                    pictureBox1.DrawToBitmap(bmp, pictureBox1.ClientRectangle);
                    Graphics g = this.CreateGraphics();
                    g.DrawImage(bmp, new System.Drawing.Point(0, 0));

                    // 生成随机文件名
                    string fileName = GenerateRandomFileName() + ".png";

                    // 获取桌面路径
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    // 拼接保存路径
                    string filePath = Path.Combine(desktopPath, fileName);

                    // 保存图像
                    bmp.Save(filePath, ImageFormat.Png);
                }

                QRCodeStatus.Text = "成功的操作。渲染后二维码已保存至桌面";
            }
        }

        private void 至桌面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenderToDesktop();
        }

        private void 带有WLAN信息的二维码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MouldSpawn_WLAN f4 = new MouldSpawn_WLAN();
            f4.Show();
        }

        private void UpdateLogBtn_Click(object sender, EventArgs e)
        {
            UpdateLog f5 = new UpdateLog();
            f5.Show();
        }

        private void 保存键入内容至缓存文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("键入内容不得为空", "保存失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    string contentToSave = textBox1.Text;

                    // 获取软件所在目录
                    string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

                    // 拼接保存文件的路径，将文件保存在 PageCachedFile 文件夹中
                    string cacheFolderPath = Path.Combine(appDirectory, "PageCachedFile");
                    string cacheFilePath = Path.Combine(cacheFolderPath, "cached_data.txt");

                    // 创建 PageCachedFile 文件夹（如果不存在）
                    Directory.CreateDirectory(cacheFolderPath);

                    // 将内容写入文件
                    File.WriteAllText(cacheFilePath, contentToSave);

                    加载缓存文件内容ToolStripMenuItem.Enabled = true;
                    加载缓存文件内容ToolStripMenuItem.Text = "加载缓存过的键入内容";

                    MessageBox.Show("内容已成功保存至缓存文件。", "保存成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存内容时出现错误：" + ex.Message, "保存失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void 加载缓存文件内容ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 检查缓存文件所在文件夹是否存在文件
            string cacheFolder = Path.GetDirectoryName(cacheFilePath);
            string[] filesInFolder = Directory.GetFiles(cacheFolder);
            if (filesInFolder.Length > 0)
            {
                加载缓存文件内容ToolStripMenuItem.Enabled = true;
                try
                {
                    // 获取当前日期的字符串表示形式，格式为 "yyyy-MM-dd"
                    string currentDate = DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss");

                    // 读取缓存文件的内容
                    string cachedContent = File.ReadAllText(cacheFilePath);
                    textBox1.Text = null;
                    textBox1.Text = cachedContent;
                    QRCodeStatus.Text = "成功的操作";
                    // 加载完内容后删除缓存文件
                    File.Delete(cacheFilePath);

                    加载缓存文件内容ToolStripMenuItem.Enabled = false;
                    加载缓存文件内容ToolStripMenuItem.Text = $"上次读取：{currentDate}";
                }
                catch (Exception ex)
                {
                    QRCodeStatus.Text = "失败的操作";
                    MessageBox.Show("读取缓存文件时出现错误：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                加载缓存文件内容ToolStripMenuItem.Enabled = false;
                加载缓存文件内容ToolStripMenuItem.Text = "没有缓存文件";
            }
        }

        private void 其他路径ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                QRCodeStatus.Text = "失败的操作。检测到实时生成结果框内无二维码存在";
            }
            else
            {
                try
                {
                    // 创建一个 SaveFileDialog 对象
                    using (System.Windows.Forms.SaveFileDialog saveFileDialog = new System.Windows.Forms.SaveFileDialog())
                    {
                        saveFileDialog.Filter = "PNG 图像文件 (*.png)|*.png";
                        saveFileDialog.Title = "选择保存位置";
                        saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        saveFileDialog.RestoreDirectory = true;

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // 获取用户选择的保存路径
                            string filePath = saveFileDialog.FileName;

                            using (Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height))
                            {
                                pictureBox1.DrawToBitmap(bmp, pictureBox1.ClientRectangle);

                                // 保存图像
                                bmp.Save(filePath, ImageFormat.Png);
                            }

                            QRCodeStatus.Text = $"成功的操作。渲染后二维码已保存至：{filePath}";
                        }
                        else
                        {
                            QRCodeStatus.Text = "用户取消了保存操作";
                        }
                    }
                }
                catch (Exception ex)
                {
                    QRCodeStatus.Text = $"保存图像时出现错误：{ex.Message}";
                }
            }
        }

        private void 带有Unix时间戳的二维码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 生成当前时间的Unix时间戳
                long unixTimestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

                // 将时间戳转换为字符串
                string timestampString = unixTimestamp.ToString();

                // 创建二维码生成器对象
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(timestampString, eccLevel);
                QRCode qrCode = new QRCode(qrCodeData);

                // 将二维码转换为位图图像
                Bitmap qrCodeImage = qrCode.GetGraphic(20);

                // 保存二维码到桌面
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string qrCodeFilePath = Path.Combine(desktopPath, "UnixTimestampQRCode.png");
                qrCodeImage.Save(qrCodeFilePath, System.Drawing.Imaging.ImageFormat.Png);

                MessageBox.Show($"二维码已保存到桌面：{qrCodeFilePath}", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"生成二维码时出现错误：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void l低纠错7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eccLevel = ECCLevel.L;
            m中等纠错15ToolStripMenuItem.Checked = false;
            q较高容错25ToolStripMenuItem.Checked = false;
            h精密容错30ToolStripMenuItem.Checked = false;
            l低纠错7ToolStripMenuItem.Checked = true;

        }

        private void m中等纠错15ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eccLevel = ECCLevel.M;
            m中等纠错15ToolStripMenuItem.Checked = true;
            q较高容错25ToolStripMenuItem.Checked = false;
            h精密容错30ToolStripMenuItem.Checked = false;
            l低纠错7ToolStripMenuItem.Checked = false;
        }

        private void q较高容错25ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eccLevel = ECCLevel.Q;
            m中等纠错15ToolStripMenuItem.Checked = false;
            q较高容错25ToolStripMenuItem.Checked = true;
            h精密容错30ToolStripMenuItem.Checked = false;
            l低纠错7ToolStripMenuItem.Checked = false;
        }

        private void h精密容错30ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eccLevel = ECCLevel.H;
            m中等纠错15ToolStripMenuItem.Checked = false;
            q较高容错25ToolStripMenuItem.Checked = false;
            h精密容错30ToolStripMenuItem.Checked = true;
            l低纠错7ToolStripMenuItem.Checked = false;
        }

        private async void Form1_Closing(object sender, FormClosingEventArgs e)
        {

            if (generatingQRCode)
            {
                // 如果生成二维码任务正在进行中，弹出警告提示对话框
                DialogResult result = MessageBox.Show("继续关闭软件会杀死渲染进程，你确定要继续关闭软件？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    // 如果用户选择不关闭软件，取消关闭操作
                    e.Cancel = true;
                }
                else
                {
                    // 如果用户选择关闭软件，继续执行关闭操作
                    e.Cancel = false;
                }
            }
        }

        private async Task U1()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "图像文件|*.jpg;*.jpeg;*.png;*.bmp;*.gif|所有文件|*.*";
            openFileDialog.Title = "选择二维码图片";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                Mat image = Cv2.ImRead(selectedFilePath, ImreadModes.Grayscale);
                if (!image.Empty())
                {
                    // 加载图像文件并显示到 pictureBox3
                    Image selectedImage = Image.FromFile(selectedFilePath);
                    pictureBox3.Image = selectedImage;

                    QRCodeDetector detector = new QRCodeDetector();
                    Point2f[] points;
                    string result = detector.DetectAndDecode(image, out points);
                    if (!string.IsNullOrEmpty(result))
                    {
                        textBox2.Text = result;
                        QRCodeStatus.Text = "成功解析";
                    }
                    else
                    {
                        QRCodeStatus.Text = "失败的操作";
                        MessageBox.Show("未能解析二维码。", "解析失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Open_Source_Lib_Attributions f2 = new Open_Source_Lib_Attributions();
            f2.Show();
        }
    }

}
