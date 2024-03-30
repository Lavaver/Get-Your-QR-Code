using System;
using System.Drawing;
using System.Windows.Forms;
using QRCoder;
using System.IO;
using System.Diagnostics;
using static System.Windows.Forms.DataFormats;

namespace Get_Your_QR_Code
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            QRCodeStatus.Text = "就绪";
        }



        private void GenerateQRCode(string text)
        {

            QRCodeStatus.Text = "执行操作 - 生成";
            // 根据内容长度确定二维码大小
            int size = CalculateQRCodeSize(text.Length);

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(size); // 设置二维码大小

            pictureBox1.Image = qrCodeImage;

            QRCodeStatus.Text = "生成成功";
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
            MessageBox.Show("目前还在攻克这个问题啦...\n敬请期待","功能未完成",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MIT_Lisence f2 = new MIT_Lisence();
            f2.Show();
        }
    }

}
