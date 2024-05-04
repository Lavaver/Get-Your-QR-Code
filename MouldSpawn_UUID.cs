using QRCoder;
using System.IO;

namespace Get_Your_QR_Code
{


    public partial class MouldSpawn_UUID : Form
    {
        private const int NumberOfUUIDs = 40;

        private Form1 form1Instance;

        // 构造函数，用于接收 Form1 的实例

        public MouldSpawn_UUID(Form1 form1)
        {
            InitializeComponent();

            GenerateUUIDs(NumberOfUUIDs);

            form1Instance = form1;
        }

        private void GenerateUUIDs(int count)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < count; i++)
            {
                string uuid = Guid.NewGuid().ToString();
                listBox1.Items.Add(uuid);
            }
        }

        private void RefreshUUIDs()
        {
            GenerateUUIDs(NumberOfUUIDs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshUUIDs();
            textBox1.Enabled = true;
            textBox1.PlaceholderText = "自主定义一个喜欢的 UUID";
        }


        private void SpawnUUIDQRCodeBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                // 奇妙的 CS8600 警告（
                string selectedUUID = listBox1.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(selectedUUID))
                {
                    // 使用 QRCoder 生成 QR Code
                    QRCodeGenerator qrGenerator = new();
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(selectedUUID, QRCodeGenerator.ECCLevel.Q);
                    QRCode qrCode = new(qrCodeData);
                    Bitmap qrCodeImage = qrCode.GetGraphic(5);

                    // 将 QR Code 保存到桌面上
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                    string filePath = Path.Combine(desktopPath, $"{selectedUUID}.png");
                    qrCodeImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

                    // 显示保存成功的消息
                    MessageBox.Show($"QR Code 已保存至桌面: {filePath}", "生成成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("请先选择一个 UUID。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string selectedUUID = textBox1.Text;

                // 使用 QRCoder 生成 QR Code
                QRCodeGenerator qrGenerator = new();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(selectedUUID, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(5);

                // 将 QR Code 保存到桌面上
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string filePath = Path.Combine(desktopPath, $"{selectedUUID}.png");
                qrCodeImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

                // 显示保存成功的消息
                MessageBox.Show($"QR Code 已保存至桌面: {filePath}", "生成成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                // 奇妙的 CS8600 警告（
                string selectedUUID = listBox1.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(selectedUUID))
                {
                    // 使用 QRCoder 生成 QR Code
                    QRCodeGenerator qrGenerator = new();
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(selectedUUID, QRCodeGenerator.ECCLevel.Q);
                    QRCode qrCode = new(qrCodeData);
                    Bitmap qrCodeImage = qrCode.GetGraphic(5);

                    // 将 QR Code 传入到主界面上

                    // 调用 Form1 实例的 DisplayQRCodeImage 方法来显示 QR Code
                    form1Instance.DisplayQRCodeImage(qrCodeImage);

                    // 显示成功的消息
                    MessageBox.Show("QR Code 已传入至主界面", "生成成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("请先选择一个 UUID。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string selectedUUID = textBox1.Text;

                // 使用 QRCoder 生成 QR Code
                QRCodeGenerator qrGenerator = new();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(selectedUUID, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(5);

                // 将 QR Code 传入到主界面上

                // 调用 Form1 实例的 DisplayQRCodeImage 方法来显示 QR Code
                form1Instance.DisplayQRCodeImage(qrCodeImage);

                // 显示成功的消息
                MessageBox.Show("QR Code 已传入至主界面", "生成成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // 检查是否在输入自定义的 UUID
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                listBox1.Enabled = false;
            }
            else
            {
                listBox1.Enabled = true;
            }

            string text = textBox1.Text.Replace("-", ""); // 移除所有破折号
            string formattedText = "";

            for (int i = 0; i < text.Length; i++)
            {
                formattedText += text[i];

                if ((i == 7 || i == 11 || i == 15 || i == 19) && i != text.Length - 1)
                {
                    formattedText += "-";
                }
            }

            textBox1.Text = formattedText.ToUpper(); // 将格式化后的文本显示在 textBox1 中，并转换为大写
            textBox1.SelectionStart = textBox1.Text.Length; // 将光标移到文本末尾
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 检查是否选择了已生成的 UUID
            if (listBox1.SelectedIndex != -1)
            {
                textBox1.Enabled = false;
                textBox1.Text = "";
                textBox1.PlaceholderText = "已选择 UUID，不能进行自定义";
            }
            else
            {
                textBox1.Enabled = true;
                textBox1.Text = "";
                textBox1.PlaceholderText = "自主定义一个喜欢的 UUID";
            }
        }
    }
}
