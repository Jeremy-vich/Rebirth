using System.Text.Json.Serialization;

namespace Rebirth.Shop.Models.Results
{
    public class ResultIdentification
    {
        [JsonPropertyName("sucess")]
        public bool Sucess { get; set; }
        [JsonPropertyName("nickname")]
        public string Nickname { get; set; } = string.Empty;
    }
}
