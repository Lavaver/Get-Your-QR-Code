using QRCoder;
using System.Runtime.InteropServices;
using System.IO;

namespace Get_Your_QR_Code
{
    public partial class MouldSpawn_WLAN : Form
    {
        [DllImport("C:\\windows\\System32\\wlanapi.dll", SetLastError = true)]
        public static extern uint WlanQueryInterface(
        IntPtr hClientHandle,
        [MarshalAs(UnmanagedType.LPStruct)] Guid pInterfaceGuid,
        int OpCode,
        IntPtr pReserved,
        out uint pdwDataSize,
        out IntPtr ppData,
        IntPtr pReserved2
    );

        [DllImport("C:\\windows\\System32\\wlanapi.dll")]
        public static extern void WlanFreeMemory(IntPtr pMemory);

        [DllImport("C:\\windows\\System32\\wlanapi.dll")]
        public static extern uint WlanOpenHandle(
            uint dwClientVersion,
            IntPtr pReserved,
            out uint pdwNegotiatedVersion,
            out IntPtr phClientHandle
        );

        [DllImport("C:\\windows\\System32\\wlanapi.dll")]
        public static extern uint WlanCloseHandle(
            IntPtr hClientHandle,
            IntPtr pReserved
        );

        public MouldSpawn_WLAN()
        {
            InitializeComponent();
            WLANTextboxPASSWORD.TextChanged += CheckWLANTextboxPASSWORD;

        }

        private void CheckWLANTextboxPASSWORD(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender; // 将sender转换为TextBox类型
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                comboBox1.Enabled = true;
                comboBox1.SelectedIndex = 1;
                comboBox1.Text = $"{comboBox1.SelectedItem}";
            }
            else
            {
                comboBox1.Enabled = false;
                comboBox1.Text = "此选项暂时不可用";
            }
        }

        private void SpawnWLANQRCodeBtn_Click(object sender, EventArgs e)
        {
            string wifiSSID = WLANTextboxSSID.Text;
            string wifiPassWord = WLANTextboxPASSWORD.Text;

            if (string.IsNullOrEmpty(wifiSSID))
            {
                MessageBox.Show("网络 SSID 不应为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(wifiPassWord))
            {
                SpawnWLANNonPasswd();
            }
            else
            {
                SpawnWLAN();
            }
        }

        private void SpawnWLAN()
        {
            string wifiSSID = WLANTextboxSSID.Text;

            string wifiPassWord = WLANTextboxPASSWORD.Text;

            // 从输入框获取 WiFi 配置信息
            string wifiInfo = $"WIFI:T:{comboBox1.SelectedItem};P:{wifiPassWord};S:{wifiSSID};H:true;";

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

        private void SpawnWLANNonPasswd()
        {
            string wifiSSID = WLANTextboxSSID.Text;

            // 从输入框获取 WiFi 配置信息
            string wifiInfo = $"WIFI:T:;S:{wifiSSID};P:;;";

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("加密方式可用于保护你的设备与路由器免遭攻击与威胁。\n在你输入密码后，将启用该选择框，你可以选择任意一种加密方式保护你的网络安全。\n- WEP ：基础加密保护，出于潜在被攻破可能，建议非必要切勿选择。\n- WPA/WPA2-Personal ：为个人或家庭用户提供进阶加密保护，也是当今路由器的首选加密方式。\n- WPA/WPA2-Enterprise ：为企业用户提供进阶加密保护。\n- WPA3 ：为个人用户提供高级进阶加密保护。", "帮助", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AutoGetSSIDBtn_Click(object sender, EventArgs e)
        {
            IntPtr hClientHandle;
            uint dwResult = WlanOpenHandle(2, IntPtr.Zero, out _, out hClientHandle);

            if (dwResult == 0)
            {
                uint pdwDataSize;
                IntPtr ppData;
                dwResult = WlanQueryInterface(hClientHandle, Guid.Empty, 6, IntPtr.Zero, out pdwDataSize, out ppData, IntPtr.Zero);

                if (dwResult == 0)
                {
                    string ssid = Marshal.PtrToStringUni(ppData).Trim();
                    WLANTextboxSSID.Text = ssid;
                    WlanFreeMemory(ppData);
                }
                else
                {
                    MessageBox.Show($"在获取信息时出现 {dwResult} 错误。");
                }

                WlanCloseHandle(hClientHandle, IntPtr.Zero);
            }
            else
            {
                MessageBox.Show($"在获取信息时出现 {dwResult} 错误。");
            }
        }
    }
}
