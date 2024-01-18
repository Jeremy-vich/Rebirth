using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Rebirth.Shop.Models
{
    public class Gift
    {
        public string article_name { get; set; } = string.Empty;
        public int article_price { get; set; } 
        public string article_pricecrossed { get; set; } = string.Empty;
        public string article_visual { get; set; } = string.Empty;
        [JsonPropertyName("new")]
        public bool isNew { get; set; }
        public bool promo { get; set; }
        public bool redirect { get; set; }
        public string title { get; set; } = string.Empty;
        public string url { get; set; } = string.Empty;

        public string ToXML()
        {
            using (var stringwriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(GetType());
                serializer.Serialize(stringwriter, this);
                return stringwriter.ToString();
            }
        }
    }
}
