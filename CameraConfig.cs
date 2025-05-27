using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraSensor
{
    public class CameraConfig
    {
        public string DeviceId { get; set; }
        public string WifiSSID { get; set; }
        public string WifiPassword { get; set; }
        public string MqttHost { get; set; }
        public int MqttPort { get; set; }
        public string MqttUsername { get; set; }
        public string MqttPassword { get; set; }
        public string StaticIp { get; set; }

        public static CameraConfig Load(string path)
        {
            if (!File.Exists(path))
                return new CameraConfig();

            var json = File.ReadAllText(path);
            return System.Text.Json.JsonSerializer.Deserialize<CameraConfig>(json);
        }

        public void Save(string path)
        {
            var json = System.Text.Json.JsonSerializer.Serialize(this, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }
    }
}
