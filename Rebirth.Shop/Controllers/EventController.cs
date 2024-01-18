using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rebirth.Shop.Controllers
{
    [Route("krosmoz/")]
    [ApiController]
    public class EventController : ControllerBase
    {
        [HttpGet("event.json")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost("event.json")]
        public string Post()
        {
            return "{\r\n    \"event\": {\r\n        \"id\": 119,\r\n        \"imageurl\": \"https://staticns.ankama.com/krosmoz/img/uploads/event/119/all_260_260.png\",\r\n        \"name\": \"\",\r\n        \"bosstext\": \"Ezimuos est la Méryde de la docilité. Elle a horreur des gens qui ne font pas ce qu’on leur demande. C’est pourquoi elle influence les esprits faibles, tout en douceur, et les force à obéir sans qu’ils s’en rendent compte ! Pas de protestations, et plein de larbins à disposition… Génial, non ?\",\r\n        \"ephemeris\": \"Aujourd’hui, même les créatures les plus féroces vont faire preuve de docilité. Vous n’aurez aucun mal à jouer à Saute-Bouftou avec un Mulou, même s’il est enragé ! Avec un peu de chance, il acceptera aussi de vous masser les gros orteils. Le meilleur moyen d’être fixé, c’est d’essayer...\",\r\n        \"rubrikabrax\": \"Kamasu Tar Junior est un jeune Phorreur : le familier préféré des Enutrofs ! Son temps, il le passe à faire le ménage et à ramasser les kamas tombés sous le plancher, sans rechigner ! Il faut dire qu’à la clef, il y a souvent la seule chose pour laquelle Ruel n’est pas avare : d’interminables caresses !\",\r\n        \"festtext\": \"\",\r\n    },\r\n    \"zodiac\": {\r\n        \"id\": 14,\r\n        \"name\": \"Le Centoror\",\r\n        \"description\": \"Les aventuriers nés sous le signe du Centoror  sont des « taxeurs » nés. Entendez par là qu’ils ont une fâcheuse tendance à s’approprier les biens d’autrui. Leur devise : « Tout ce qui est à toi est à moi aussi, surtout si ça a de la valeur » ! Un trait de caractère qui, s’ils ont le malheur d’être en plus disciples d’Enutrof, en fait des grippe-sous de la pire espèce !\",\r\n        \"imageurl\": \"https://staticns.ankama.com/krosmoz/img/uploads/zodiac/14/all_128_128.png\"\r\n    },\r\n    \"month\": {\r\n        \"id\": 7,\r\n        \"month\": 12,\r\n        \"name\": \"Descendre\",\r\n        \"protectorname\": \"Djaul\",\r\n        \"protectordesc\": \"Djaul est le Protecteur de Descendre. Il ne rêve que d’une chose : plonger le Monde des 12 dans un hiver éternel. Comment ? En prolongeant le mois dont il a la garde, bien sûr ! Voilà pourquoi, tous les ans, il tente de grappiller quelques jours à Javian. Mais Jiva, la gardienne de ce mois, n’est pas prête à accepter la garde partagée !\",\r\n        \"protectorimageurl\": \"https://staticns.ankama.com/krosmoz/img/uploads/month/7/all_128_128.png\"\r\n    }\r\n}";
        }
    }
}
