using Newtonsoft.Json;

namespace LightControllerClient.Models
{
    public class LoginResult
    {
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }
    }
}
