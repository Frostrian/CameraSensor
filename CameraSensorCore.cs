using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Protocol;
using System.Text;
using System.Timers;

namespace CameraSensor
{
    public class CameraSensorCore
    {
        private IMqttClient mqttClient;
        private MqttFactory mqttFactory;
        private CameraConfig config;
        private Action<string> logAction;
        private bool authenticated = false;
        private System.Timers.Timer timerStatus, timerFrame;

        public CameraSensorCore(CameraConfig cfg, Action<string> logCallback)
        {
            config = cfg;
            logAction = logCallback;
            mqttFactory = new MqttFactory();
        }

        public async Task StartAsync()
        {
            mqttClient = mqttFactory.CreateMqttClient();

            var options = new MqttClientOptionsBuilder()
                .WithTcpServer(config.MqttHost, config.MqttPort)
                .WithClientId(config.DeviceId)
                .Build();

            mqttClient.ApplicationMessageReceivedAsync += async e =>
            {
                var topic = e.ApplicationMessage.Topic;
                var payload = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);

                if (topic == $"auth/{config.DeviceId}/response")
                    HandleAuthResponse(payload);

                await Task.CompletedTask;
            };

            await mqttClient.ConnectAsync(options, CancellationToken.None);
            logAction("MQTT bağlantısı kuruldu.");

            await mqttClient.SubscribeAsync($"auth/{config.DeviceId}/response");

            var authPayload = new
            {
                deviceId = config.DeviceId,
                ip = config.StaticIp,
                username = config.MqttUsername,
                password = config.MqttPassword
            };

            var json = System.Text.Json.JsonSerializer.Serialize(authPayload);

            await mqttClient.PublishAsync(new MqttApplicationMessageBuilder()
                .WithTopic("auth/request")
                .WithPayload(json)
                .WithQualityOfServiceLevel(MqttQualityOfServiceLevel.AtLeastOnce)
                .Build());

            logAction("Giriş isteği gönderildi.");
        }

        private void HandleAuthResponse(string payload)
        {
            var result = System.Text.Json.JsonSerializer.Deserialize<AuthResponse>(payload);
            if (result.status == "ok")
            {
                logAction("Doğrulama başarılı. Kamera aktif.");
                authenticated = true;
                StartTimers();
            }
            else
            {
                logAction("❌ Doğrulama başarısız: " + result.reason);
            }
        }

        private void StartTimers()
        {
            timerFrame = new System.Timers.Timer(20000); // 20 saniyede bir sahte "görüntü"
            timerFrame.Elapsed += async (s, e) => await SendFrame();
            timerFrame.AutoReset = true;
            timerFrame.Start();

            timerStatus = new System.Timers.Timer(60000);
            timerStatus.Elapsed += async (s, e) => await SendStatus();
            timerStatus.AutoReset = true;
            timerStatus.Start();
        }

        private async Task SendFrame()
        {
            if (!authenticated || !mqttClient.IsConnected) return;

            var msg = $"{{\"deviceId\":\"{config.DeviceId}\",\"frameId\":\"F-{Guid.NewGuid().ToString().Substring(0, 6)}\",\"timestamp\":\"{DateTime.Now:O}\"}}";

            await mqttClient.PublishAsync(new MqttApplicationMessageBuilder()
                .WithTopic($"camera/{config.DeviceId}/frame")
                .WithPayload(msg)
                .WithQualityOfServiceLevel(MqttQualityOfServiceLevel.AtLeastOnce)
                .Build());

            logAction("📷 Frame verisi gönderildi.");
        }

        private async Task SendStatus()
        {
            if (!authenticated || !mqttClient.IsConnected) return;

            var status = new[] { "online", "idle", "recording" }[new Random().Next(3)];
            var msg = $"{{\"deviceId\":\"{config.DeviceId}\",\"status\":\"{status}\",\"timestamp\":\"{DateTime.Now:O}\"}}";

            await mqttClient.PublishAsync(new MqttApplicationMessageBuilder()
                .WithTopic($"camera/{config.DeviceId}/status")
                .WithPayload(msg)
                .WithQualityOfServiceLevel(MqttQualityOfServiceLevel.AtLeastOnce)
                .Build());

            logAction($"🟢 Durum bilgisi gönderildi: {status}");
        }

        private class AuthResponse
        {
            public string status { get; set; }
            public string reason { get; set; }
        }
    }
}