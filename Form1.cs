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
        private int ChunkSize = 500; // ���ÿ��С

        // ����һ�� OpenFileDialog ����
        OpenFileDialog openFileDialog = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
            QRCodeStatus.Text = "����";
        }



        private void GenerateQRCode(string text)
        {
            try
            {
                QRCodeStatus.Text = "ִ�����ɲ���";
                // �������ݳ���ȷ����ά���С
                int size = CalculateQRCodeSize(text.Length);

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.L);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(size); // ���ö�ά���С

                pictureBox1.Image = qrCodeImage;

                QRCodeStatus.Text = "���ɳɹ�";
            }
            catch (Exception log)
            {
                File.AppendAllText("Exception.log", "\r\n" + "--- �����쳣����һλ���ж�ջ��־��ĩβ ---\n" + log);
                QRCodeStatus.Text = "����ʧ�ܡ������쳣�Ķ�ջ��־�ѱ��������Ŀ¼��";
            }

        }

        private int CalculateQRCodeSize(int contentLength)
        {
            // �������ݳ�����ȷ����ά��Ĵ�С
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
            MessageBox.Show("Ŀǰ���ڹ������������...\n�����ڴ�", "����δ���", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MIT_Lisence f2 = new MIT_Lisence();
            f2.Show();
        }

        private void �ر�ѡ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ���õײ�״̬��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QRCodeStatus.Text = "����";
        }

        private async void UpLoadPictureBtn_Click(object sender, EventArgs e)
        {
            // ����һ�� OpenFileDialog ����
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // �����ļ��Ի��������
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "ͼƬ�ļ�|*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            // ����û������ȷ����ť
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // ��ȡ��ѡ�ļ���·��
                    string selectedImagePath = openFileDialog.FileName;

                    StartGrapicingPage f3 = new StartGrapicingPage();
                    f3.Show();

                    QRCodeStatus.Text = "ִ�����ɲ���";

                    // ��ѡ�е�ͼƬת��ΪBase64����
                    string base64Image = await ConvertImageToBase64Async(selectedImagePath);

                    // ��Base64����ֳɿ�
                    string[] chunks = ChunkBase64String(base64Image, ChunkSize);

                    // ��ȡ��ǰ���ڵ��ַ�����ʾ��ʽ����ʽΪ "yyyy-MM-dd"
                    string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

                    // ��������QR��ͼ����ļ���·��
                    string qrCodeFolderPath = Path.Combine(System.Windows.Forms.Application.StartupPath, $"QRCode_Picture_Packs_{currentDate}");

                    // ����ļ��в����ڣ��򴴽���
                    if (!Directory.Exists(qrCodeFolderPath))
                    {
                        Directory.CreateDirectory(qrCodeFolderPath);
                    }

                    // �������QR�벢����Ϊͼ���ļ�
                    for (int i = 0; i < chunks.Length; i++)
                    {
                        string qrCodeFileName = Path.Combine(System.Windows.Forms.Application.StartupPath, $"{qrCodeFolderPath}\\qrcode_part_{i}.png");
                        await GenerateQRCodeAsync(chunks[i], qrCodeFileName);

                        // ������Ⱦ״̬
                        QRCodeStatus.Text = $"������Ⱦ�� {i + 1} ��ͼƬ���� {chunks.Length} ��";
                    }

                    // ����QRCodeStatus�ı��������
                    this.Invoke(new Action(() =>
                    {
                        QRCodeStatus.Text = $"���ɳɹ����ֿ��ά���ļ��ѱ��������Ŀ¼�µ� /QRCode_Packs_[����] �ļ�����";
                    }));

                    MessageBox.Show($"���ɳɹ����ֿ��ά���ļ��ѱ��������Ŀ¼�µ� {qrCodeFolderPath} �ļ�����", "��Ⱦ������ȫ�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // ���쳣��Ϣ��¼����־�ļ�
                    File.AppendAllText("Exception.log", "\r\n" + "--- �����쳣����һλ���ж�ջ��־��ĩβ ---\n" + ex);
                    QRCodeStatus.Text = "����ʧ�ܡ������쳣�Ķ�ջ��־�ѱ��������Ŀ¼��";
                }
            }
        }

        // ��ͼƬת��ΪBase64���루�첽�汾��
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

        // ��Base64�ַ����ֳ�ָ����С�Ŀ�
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
            MessageBox.Show("ѡ���ļ��󣬳����Ƚ�ͼƬ���� Base64 ת����Ȼ��ת�����ַ������зֿ����\n��ɺ������Ⱦÿ�������Ӧ�Ķ�ά�벢��������Ŀ¼�µ� /QRCode_Packs_[����] �ļ�����\n����������������ܱ��������������Ҫ�����ַ�ʽ������Ƚϴ��ͼƬ�Ļ�...\n...��������ò����ɨ�롢�ϲ���ת��������������׼����", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void �����ά�������С����������ռ�óʼ��α���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ȡ�������˵����ѡ��״̬
            ����ToolStripMenuItem.Checked = false;
            h����ToolStripMenuItem1.Checked = false;
            ����Ĭ��ToolStripMenuItem.Checked = false;
            �������ToolStripMenuItem.Checked = false;
            // ���õ�ǰ�˵����ѡ��״̬
            �����ά�������С����������ռ�óʼ��α���ToolStripMenuItem.Checked = true;

            ChunkSize = 10;
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ����ToolStripMenuItem.Checked = true;
            h����ToolStripMenuItem1.Checked = false;
            ����Ĭ��ToolStripMenuItem.Checked = false;
            �������ToolStripMenuItem.Checked = false;
            �����ά�������С����������ռ�óʼ��α���ToolStripMenuItem.Checked = false;

            ChunkSize = 50;
        }

        private void h����ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ����ToolStripMenuItem.Checked = false;
            h����ToolStripMenuItem1.Checked = true;
            ����Ĭ��ToolStripMenuItem.Checked = false;
            �������ToolStripMenuItem.Checked = false;
            �����ά�������С����������ռ�óʼ��α���ToolStripMenuItem.Checked = false;

            ChunkSize = 100;
        }

        private void ����Ĭ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ����ToolStripMenuItem.Checked = false;
            h����ToolStripMenuItem1.Checked = false;
            ����Ĭ��ToolStripMenuItem.Checked = true;
            �������ToolStripMenuItem.Checked = false;
            �����ά�������С����������ռ�óʼ��α���ToolStripMenuItem.Checked = false;

            ChunkSize = 500;
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ����ToolStripMenuItem.Checked = false;
            h����ToolStripMenuItem1.Checked = false;
            ����Ĭ��ToolStripMenuItem.Checked = false;
            �������ToolStripMenuItem.Checked = true;
            �����ά�������С����������ռ�óʼ��α���ToolStripMenuItem.Checked = false;

            ChunkSize = 1000;
        }

        private void ��ѡ�������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� Base64 �����С������޶ȵ�������Ⱦʱ���������\n���õ�����Խ������Էֱ��ʽϸߵ�ͼƬʱҲ��ȷ�����ɵ�ÿ�Ŷ�ά����ص���Ϣ��������޶ȵؼ�����Ⱦ������ʱ�䡣", "ʹ��˵��", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ���´�����ʱ����DPI����ģʽToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� DPI ��֪����ģʽ������ĳЩ����������ɰ����������ڣ�\n- ���ģ��\n- �ؼ�λ�ô���\n- �����ڸ�ģʽ�µ����©����\nҪ������", "����", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = null;
                QRCodeStatus.Text = "�ɹ�����";
            }
            catch
            {
                QRCodeStatus.Text = "ʧ�ܵĲ���";
            }
        }
        private string GenerateRandomFileName()
        {
            // ��������ļ�������Ӣ�ĺ��������
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, 8)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void RenderToDesktop()
        {
            if (pictureBox1.Image == null)
            {
                QRCodeStatus.Text = "ʧ�ܵĲ�������⵽ʵʱ���ɽ�������޶�ά�����";
            }
            else
            {
                using (Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height))
                {
                    pictureBox1.DrawToBitmap(bmp, pictureBox1.ClientRectangle);
                    Graphics g = this.CreateGraphics();
                    g.DrawImage(bmp, new Point(0, 0));

                    // ��������ļ���
                    string fileName = GenerateRandomFileName() + ".png";

                    // ��ȡ����·��
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    // ƴ�ӱ���·��
                    string filePath = Path.Combine(desktopPath, fileName);

                    // ����ͼ��
                    bmp.Save(filePath, ImageFormat.Png);
                }

                QRCodeStatus.Text = "�ɹ���������Ⱦ���ά���ѱ���������";
            }
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenderToDesktop();
        }

        private void ����WLAN��Ϣ�Ķ�ά��ToolStripMenuItem_Click(object sender, EventArgs e)
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
