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
            QRCodeStatus.Text = "����";
        }



        private void GenerateQRCode(string text)
        {

            QRCodeStatus.Text = "ִ�в��� - ����";
            // �������ݳ���ȷ����ά���С
            int size = CalculateQRCodeSize(text.Length);

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(size); // ���ö�ά���С

            pictureBox1.Image = qrCodeImage;

            QRCodeStatus.Text = "���ɳɹ�";
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
            MessageBox.Show("Ŀǰ���ڹ������������...\n�����ڴ�","����δ���",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MIT_Lisence f2 = new MIT_Lisence();
            f2.Show();
        }
    }

}
