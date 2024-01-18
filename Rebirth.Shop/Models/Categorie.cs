namespace Rebirth.Shop.Models
{
    public class Categorie
    {
        public int id { get; set; }
        public string key { get; set; }
        public string displayMod { get; set; }
        public string name { get; set; }
        public Categorie[] child { get; set; }
    }
}
