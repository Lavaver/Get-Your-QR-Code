using System;
using System.Drawing;
using System.Windows.Forms;
using QRCoder;
using System.IO;
using System.Diagnostics;
using static System.Windows.Forms.DataFormats;
using Microsoft.VisualBasic.Logging;
using ZXing.Common;
using ZXing;
using ZXing.QrCode;
using ZXing.Rendering;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Imaging;

namespace Get_Your_QR_Code
{
    public partial class Form1 : Form
    {
        private int ChunkSize = 500; // 设置块大小

        // 创建一个 OpenFileDialog 对象
        OpenFileDialog openFileDialog = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
            QRCodeStatus.Text = "就绪";
        }



        private void GenerateQRCode(string text)
        {
            try
            {
                QRCodeStatus.Text = "执行生成操作";
                // 根据内容长度确定二维码大小
                int size = CalculateQRCodeSize(text.Length);

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.L);
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

        private async void UpLoadPictureBtn_Click(object sender, EventArgs e)
        {
            // 创建一个 OpenFileDialog 对象
            OpenFileDialog openFileDialog = new OpenFileDialog();

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

                    MessageBox.Show($"生成成功。分块二维码文件已保存在软件目录下的 {qrCodeFolderPath} 文件夹下", "渲染任务已全部完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
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
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);
                qrCodeImage.Save(outputFileName, System.Drawing.Imaging.ImageFormat.Png);
            });
        }

        private void Help1_Click(object sender, EventArgs e)
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

        private void 创建ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 在下次启动时禁用DPI缩放模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("禁用 DPI 感知缩放模式可能在某些缩放率下造成包括但不限于：\n- 组件模糊\n- 控件位置错乱\n- 其他在该模式下的软件漏洞等\n要继续？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = null;
                QRCodeStatus.Text = "成功操作";
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
                    g.DrawImage(bmp, new Point(0, 0));

                    // 生成随机文件名
                    string fileName = GenerateRandomFileName() + ".png";

                    // 获取桌面路径
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    // 拼接保存路径
                    string filePath = Path.Combine(desktopPath, fileName);

                    // 保存图像
                    bmp.Save(filePath, ImageFormat.Png);
                }

                QRCodeStatus.Text = "成功操作。渲染后二维码已保存至桌面";
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
    }

}
