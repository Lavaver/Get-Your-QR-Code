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

        private bool generatingQRCode = false; // ������ɶ�ά�������Ƿ����ڽ�����

        private int ChunkSize = 500; // ���ÿ��С

        private string cacheFilePath;

        private string folderPath = "\\PageCachedFile";
        public Form1()
        {
            InitializeComponent();

            // ��ȡ�������Ŀ¼
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string cacheFolderPath = Path.Combine(appDirectory, "PageCachedFile");

            // ��黺���ļ����Ƿ���ڣ�����������򴴽�
            if (!Directory.Exists(cacheFolderPath))
            {
                Directory.CreateDirectory(cacheFolderPath);
            }

            // ƴ�ӻ����ļ���·��
            cacheFilePath = Path.Combine(cacheFolderPath, "cached_data.txt");

            // �ڴ������ʱ����Ƿ���ڻ����ļ������������ݵ��ı���
            this.Load += Form1_Load;

            this.FormClosing += Form1_Closing; // �ֶ��� Closing �¼�

            eccLevel = ECCLevel.L;



            QRCodeStatus.Text = "����";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            // ��黺���ļ������ļ����Ƿ�����ļ�
            string cacheFolder = Path.GetDirectoryName(cacheFilePath);
            string[] filesInFolder = Directory.GetFiles(cacheFolder);
            if (filesInFolder.Length > 0)
            {
                // �����ļ������Խ�����Ӧ����
                try
                {
                    // ��黺���ļ��Ƿ����
                    if (File.Exists(cacheFilePath))
                    {
                        // ��ȡ�����ļ�������
                        string cachedContent = File.ReadAllText(cacheFilePath);

                        // ��ʾ���ݲ��ȴ��û�ȷ��
                        var result = MessageBox.Show("��⵽���ڻ����ļ����Ƿ�������ݵ��ı���", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        // ����û�ȷ�ϼ������ݣ���������ʾ���ı�����
                        if (result == DialogResult.Yes)
                        {
                            textBox1.Text = cachedContent;

                            // ���������ݺ�ɾ�������ļ�
                            File.Delete(cacheFilePath);

                            ���ػ����ļ�����ToolStripMenuItem.Enabled = false;
                            ���ػ����ļ�����ToolStripMenuItem.Text = "�Ѷ�ȡ�������ļ�";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("��ȡ�����ļ�ʱ���ִ���" + ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // �ļ�����û���ļ������Խ�����Ӧ����������ò˵����
                ���ػ����ļ�����ToolStripMenuItem.Enabled = false;
                ���ػ����ļ�����ToolStripMenuItem.Text = "û�л����ļ�";
            }
        }


        private void GenerateQRCode(string text)
        {
            try
            {
                QRCodeStatus.Text = "ִ�����ɲ���";
                // �������ݳ���ȷ����ά���С
                int size = CalculateQRCodeSize(text.Length);

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, eccLevel);
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

        private async void UpLoadPictureBtn_Click_1(object sender, EventArgs e)
        {
            // ����һ�� OpenFileDialog ����
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();

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

                    // �����ļ���ѡ��Ի���
                    FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                    folderBrowserDialog.Description = "��ѡ�񱣴�λ��";
                    folderBrowserDialog.ShowNewFolderButton = true;

                    // ����û������ȷ����ť
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        generatingQRCode = true;
                        string qrCodeFolderPath = folderBrowserDialog.SelectedPath;

                        StartGrapicingPage f3 = new StartGrapicingPage();
                        f3.Show();

                        QRCodeStatus.Text = "ִ�����ɲ���";

                        // ��ѡ�е�ͼƬת��ΪBase64����
                        string base64Image = await ConvertImageToBase64Async(selectedImagePath);

                        // ��Base64����ֳɿ�
                        string[] chunks = ChunkBase64String(base64Image, ChunkSize);

                        // �������QR�벢����Ϊͼ���ļ�
                        for (int i = 0; i < chunks.Length; i++)
                        {
                            string qrCodeFileName = Path.Combine(qrCodeFolderPath, $"qrcode_part_{i}.png");
                            await GenerateQRCodeAsync(chunks[i], qrCodeFileName);

                            // ������Ⱦ״̬
                            QRCodeStatus.Text = $"������Ⱦ�� {i + 1} ��ͼƬ���� {chunks.Length} ��";
                        }

                        // ����QRCodeStatus�ı��������
                        this.Invoke(new Action(() =>
                        {
                            QRCodeStatus.Text = $"���ɳɹ����ֿ��ά���ļ��ѱ�������ѡλ��";
                        }));

                        generatingQRCode = false;

                        MessageBox.Show($"���ɳɹ����ֿ��ά���ļ��ѱ�������ѡλ��", "��Ⱦ������ȫ�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("��⵽��ȡ����ѡ�����\n��Ҫ������Ĭ��λ����", "��Ҫ������Ĭ��λ����", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        // ����û�����ˡ�ȷ������ť
                        if (result == DialogResult.OK)
                        {
                            try
                            {
                                generatingQRCode = true;

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

                                generatingQRCode = false;

                                MessageBox.Show($"���ɳɹ����ֿ��ά���ļ��ѱ��������Ŀ¼�µ� {qrCodeFolderPath} �ļ�����", "��Ⱦ������ȫ�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                generatingQRCode = false;
                                // ���쳣��Ϣ��¼����־�ļ�
                                File.AppendAllText("Exception.log", "\r\n" + "--- �����쳣����һλ���ж�ջ��־��ĩβ ---\n" + ex);
                                QRCodeStatus.Text = "����ʧ�ܡ������쳣�Ķ�ջ��־�ѱ��������Ŀ¼��";
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
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, eccLevel);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);
                qrCodeImage.Save(outputFileName, System.Drawing.Imaging.ImageFormat.Png);
            });
        }

        private void Help1_Click_1(object sender, EventArgs e)
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = null;
                QRCodeStatus.Text = "�ɹ��Ĳ���";
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
                    g.DrawImage(bmp, new System.Drawing.Point(0, 0));

                    // ��������ļ���
                    string fileName = GenerateRandomFileName() + ".png";

                    // ��ȡ����·��
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    // ƴ�ӱ���·��
                    string filePath = Path.Combine(desktopPath, fileName);

                    // ����ͼ��
                    bmp.Save(filePath, ImageFormat.Png);
                }

                QRCodeStatus.Text = "�ɹ��Ĳ�������Ⱦ���ά���ѱ���������";
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

        private void ������������������ļ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("�������ݲ���Ϊ��", "����ʧ��", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    string contentToSave = textBox1.Text;

                    // ��ȡ�������Ŀ¼
                    string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

                    // ƴ�ӱ����ļ���·�������ļ������� PageCachedFile �ļ�����
                    string cacheFolderPath = Path.Combine(appDirectory, "PageCachedFile");
                    string cacheFilePath = Path.Combine(cacheFolderPath, "cached_data.txt");

                    // ���� PageCachedFile �ļ��У���������ڣ�
                    Directory.CreateDirectory(cacheFolderPath);

                    // ������д���ļ�
                    File.WriteAllText(cacheFilePath, contentToSave);

                    ���ػ����ļ�����ToolStripMenuItem.Enabled = true;
                    ���ػ����ļ�����ToolStripMenuItem.Text = "���ػ�����ļ�������";

                    MessageBox.Show("�����ѳɹ������������ļ���", "����ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("��������ʱ���ִ���" + ex.Message, "����ʧ��", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void ���ػ����ļ�����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ��黺���ļ������ļ����Ƿ�����ļ�
            string cacheFolder = Path.GetDirectoryName(cacheFilePath);
            string[] filesInFolder = Directory.GetFiles(cacheFolder);
            if (filesInFolder.Length > 0)
            {
                ���ػ����ļ�����ToolStripMenuItem.Enabled = true;
                try
                {
                    // ��ȡ��ǰ���ڵ��ַ�����ʾ��ʽ����ʽΪ "yyyy-MM-dd"
                    string currentDate = DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss");

                    // ��ȡ�����ļ�������
                    string cachedContent = File.ReadAllText(cacheFilePath);
                    textBox1.Text = null;
                    textBox1.Text = cachedContent;
                    QRCodeStatus.Text = "�ɹ��Ĳ���";
                    // ���������ݺ�ɾ�������ļ�
                    File.Delete(cacheFilePath);

                    ���ػ����ļ�����ToolStripMenuItem.Enabled = false;
                    ���ػ����ļ�����ToolStripMenuItem.Text = $"�ϴζ�ȡ��{currentDate}";
                }
                catch (Exception ex)
                {
                    QRCodeStatus.Text = "ʧ�ܵĲ���";
                    MessageBox.Show("��ȡ�����ļ�ʱ���ִ���" + ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ���ػ����ļ�����ToolStripMenuItem.Enabled = false;
                ���ػ����ļ�����ToolStripMenuItem.Text = "û�л����ļ�";
            }
        }

        private void ����·��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                QRCodeStatus.Text = "ʧ�ܵĲ�������⵽ʵʱ���ɽ�������޶�ά�����";
            }
            else
            {
                try
                {
                    // ����һ�� SaveFileDialog ����
                    using (System.Windows.Forms.SaveFileDialog saveFileDialog = new System.Windows.Forms.SaveFileDialog())
                    {
                        saveFileDialog.Filter = "PNG ͼ���ļ� (*.png)|*.png";
                        saveFileDialog.Title = "ѡ�񱣴�λ��";
                        saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        saveFileDialog.RestoreDirectory = true;

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // ��ȡ�û�ѡ��ı���·��
                            string filePath = saveFileDialog.FileName;

                            using (Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height))
                            {
                                pictureBox1.DrawToBitmap(bmp, pictureBox1.ClientRectangle);

                                // ����ͼ��
                                bmp.Save(filePath, ImageFormat.Png);
                            }

                            QRCodeStatus.Text = $"�ɹ��Ĳ�������Ⱦ���ά���ѱ�������{filePath}";
                        }
                        else
                        {
                            QRCodeStatus.Text = "�û�ȡ���˱������";
                        }
                    }
                }
                catch (Exception ex)
                {
                    QRCodeStatus.Text = $"����ͼ��ʱ���ִ���{ex.Message}";
                }
            }
        }

        private void ����Unixʱ����Ķ�ά��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // ���ɵ�ǰʱ���Unixʱ���
                long unixTimestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

                // ��ʱ���ת��Ϊ�ַ���
                string timestampString = unixTimestamp.ToString();

                // ������ά������������
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(timestampString, eccLevel);
                QRCode qrCode = new QRCode(qrCodeData);

                // ����ά��ת��Ϊλͼͼ��
                Bitmap qrCodeImage = qrCode.GetGraphic(20);

                // �����ά�뵽����
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string qrCodeFilePath = Path.Combine(desktopPath, "UnixTimestampQRCode.png");
                qrCodeImage.Save(qrCodeFilePath, System.Drawing.Imaging.ImageFormat.Png);

                MessageBox.Show($"��ά���ѱ��浽���棺{qrCodeFilePath}", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"���ɶ�ά��ʱ���ִ���{ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void l�;���7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eccLevel = ECCLevel.L;
            m�еȾ���15ToolStripMenuItem.Checked = false;
            q�ϸ��ݴ�25ToolStripMenuItem.Checked = false;
            h�����ݴ�30ToolStripMenuItem.Checked = false;
            l�;���7ToolStripMenuItem.Checked = true;

        }

        private void m�еȾ���15ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eccLevel = ECCLevel.M;
            m�еȾ���15ToolStripMenuItem.Checked = true;
            q�ϸ��ݴ�25ToolStripMenuItem.Checked = false;
            h�����ݴ�30ToolStripMenuItem.Checked = false;
            l�;���7ToolStripMenuItem.Checked = false;
        }

        private void q�ϸ��ݴ�25ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eccLevel = ECCLevel.Q;
            m�еȾ���15ToolStripMenuItem.Checked = false;
            q�ϸ��ݴ�25ToolStripMenuItem.Checked = true;
            h�����ݴ�30ToolStripMenuItem.Checked = false;
            l�;���7ToolStripMenuItem.Checked = false;
        }

        private void h�����ݴ�30ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eccLevel = ECCLevel.H;
            m�еȾ���15ToolStripMenuItem.Checked = false;
            q�ϸ��ݴ�25ToolStripMenuItem.Checked = false;
            h�����ݴ�30ToolStripMenuItem.Checked = true;
            l�;���7ToolStripMenuItem.Checked = false;
        }

        private async void Form1_Closing(object sender, FormClosingEventArgs e)
        {

            if (generatingQRCode)
            {
                // ������ɶ�ά���������ڽ����У�����������ʾ�Ի���
                DialogResult result = MessageBox.Show("�����ر������ɱ����Ⱦ���̣���ȷ��Ҫ�����ر������", "����", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    // ����û�ѡ�񲻹ر������ȡ���رղ���
                    e.Cancel = true;
                }
                else
                {
                    // ����û�ѡ��ر����������ִ�йرղ���
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
            openFileDialog.Filter = "ͼ���ļ�|*.jpg;*.jpeg;*.png;*.bmp;*.gif|�����ļ�|*.*";
            openFileDialog.Title = "ѡ���ά��ͼƬ";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                Mat image = Cv2.ImRead(selectedFilePath, ImreadModes.Grayscale);
                if (!image.Empty())
                {
                    // ����ͼ���ļ�����ʾ�� pictureBox3
                    Image selectedImage = Image.FromFile(selectedFilePath);
                    pictureBox3.Image = selectedImage;

                    QRCodeDetector detector = new QRCodeDetector();
                    Point2f[] points;
                    string result = detector.DetectAndDecode(image, out points);
                    if (!string.IsNullOrEmpty(result))
                    {
                        textBox2.Text = result;
                        QRCodeStatus.Text = "�ɹ�����";
                    }
                    else
                    {
                        QRCodeStatus.Text = "ʧ�ܵĲ���";
                        MessageBox.Show("δ�ܽ�����ά�롣", "����ʧ��", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
