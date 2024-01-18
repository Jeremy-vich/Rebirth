using System.Text.Json.Serialization;

namespace Rebirth.Shop.Models
{

    public class RequestDatas
    {
        [JsonPropertyName("params")]
        public List<dynamic> Parameters { get; set; } = new List<dynamic>();
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("method")]
        public string Method { get; set; } = string.Empty;
    }
}
