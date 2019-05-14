using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace FreshShopBM.Data.Models
{
    public class TokenModel
    {
        [JsonProperty(propertyName:"access_token")]
        public string AccessToken { get; set; }
        [JsonProperty(propertyName:"expires_in")]
        public string ExpiresIn { get; set; }
        [JsonProperty(propertyName:"user_id")]
        public string UserId { get; set; }
    }
}