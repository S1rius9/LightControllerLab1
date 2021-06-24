using Newtonsoft.Json;

namespace LightControllerClient.Models
{
    public class LoginBody
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
