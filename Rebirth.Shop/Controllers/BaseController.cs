using Microsoft.AspNetCore.Mvc;
using Rebirth.Shop.Models;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rebirth.Shop.Controllers
{
    [Route("")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        // fr/json/shoplogincurentoffers.jsonsubscriberGifts_fr.xml
        [HttpGet("fr/json/shoplogincurentoffers.jsonsubscriberGifts_fr.xml")]
        public string Get()
        {
            Gift[] gifts = new Gift[] { 
                new Gift(){
                    article_name = "Vaporeuse",
                    article_price = 5000,
                    article_pricecrossed = "",
                    article_visual = "https://localhost:7219/imgs/vaporeuse.png",
                    isNew = true,
                    promo = false,
                    redirect = false,
                    title = "VAPOREUSE",
                    url = "https://www.dofus.com/fr/boutique/345-attitudes/7022-vaporeuse"
                },
                new Gift(){
                    article_name = "Intemporel",
                    article_price = 5000,
                    article_pricecrossed = "",
                    article_visual = "https://localhost:7219/imgs/intemporel.png",
                    isNew = true,
                    promo = false,
                    redirect = false,
                    title = "INTEMPOREL",
                    url = "https://www.dofus.com/fr/boutique/20-objets-jeu/6251-intemporel"
                },
                new Gift(){
                    article_name = "Rolivan",
                    article_price = 10000,
                    article_pricecrossed = "",
                    article_visual = "https://localhost:7219/imgs/rolivan.png",
                    isNew = true,
                    promo = true,
                    redirect = false,
                    title = "ROLIVAN",
                    url = "https://www.dofus.com/fr/boutique/20-objets-jeu/11924-panoplie-rolivan"
                },
            };
            return JsonSerializer.Serialize(gifts);
        }

        [HttpGet("imgs/{path}")]
        public IActionResult Get(string path)
        {
            var temporaryImage = System.IO.File.OpenRead($"Assets/{path}");
            //Replace "image/jpeg" with the mimetype of your image.
            return File(temporaryImage, "image/png");
        }

        // GET api/<BaseController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BaseController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BaseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BaseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
