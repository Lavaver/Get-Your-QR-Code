using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Get_Your_QR_Code
{
    public partial class MouldSpawn_WLAN : Form
    {
        public MouldSpawn_WLAN()
        {
            InitializeComponent();
        }

        private void SpawnWLANQRCodeBtn_Click(object sender, EventArgs e)
        {
            string wifiSSID = WLANTextboxSSID.Text;

            string wifiPassWord = WLANTextboxPASSWORD.Text;

            // 从输入框获取 WiFi 配置信息
            string wifiInfo = $"WIFI:T:WPA;P:{wifiPassWord};S:{wifiSSID};H:true;";

            // 创建 QRCodeGenerator 实例
            QRCodeGenerator qrGenerator = new QRCodeGenerator();

            // 根据 WiFi 配置信息生成 Payload
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(wifiInfo, QRCodeGenerator.ECCLevel.Q);

            // 创建 QRCode 实例
            QRCode qrCode = new QRCode(qrCodeData);

            // 将 QRCode 渲染成图像
            Bitmap qrCodeImage = qrCode.GetGraphic(10); // 第二个参数是二维码的尺寸，可根据需要调整

            // 将图像保存到桌面上的文件
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = $"WiFi_QRCode_{wifiSSID}.png";
            string filePath = Path.Combine(desktopPath, fileName);
            qrCodeImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

            MessageBox.Show($"二维码已保存至桌面：{filePath}", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
