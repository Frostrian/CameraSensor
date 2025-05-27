namespace CameraSensor
{
    public partial class FormCameraSensor : Form
    {
        private CameraSensorCore cameraCore;

        public FormCameraSensor()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            var config = new CameraConfig
            {
                DeviceId = txtDeviceId.Text,
                WifiSSID = txtSSID.Text,
                WifiPassword = txtWifiPass.Text,
                MqttHost = txtMqttHost.Text,
                MqttPort = int.Parse(txtMqttPort.Text),
                MqttUsername = txtMqttUser.Text,
                MqttPassword = txtMqttPass.Text,
                StaticIp = txtStaticIp.Text
            };

            cameraCore = new CameraSensorCore(config, Log);
            await cameraCore.StartAsync();
        }

        private void Log(string message)
        {
            txtLog.Invoke((MethodInvoker)(() =>
            {
                txtLog.AppendText($"{DateTime.Now:HH:mm:ss} - {message}\n");
                txtLog.ScrollToCaret();
            }));
        }
    }
}

