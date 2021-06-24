using Newtonsoft.Json;
using System;

namespace LightControllerClient.Models
{
    public class CreateLightReportModel
    {
        [JsonProperty("controllerId")]
        public Guid ControllerId { get; set; }
        
        [JsonProperty("lumens")]
        public double Lumens { get; set; }
    }
}
