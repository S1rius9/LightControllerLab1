using Newtonsoft.Json;

namespace LightControllerClient.Models
{
    public class LightModel
    {
        [JsonProperty("seconds")]
        public double Seconds { get; set; }

        [JsonProperty("reportIntervalSeconds")]
        public double ReportIntervalSeconds { get; set; }
    }
}