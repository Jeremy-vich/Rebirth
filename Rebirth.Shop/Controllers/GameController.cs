using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PetaPoco;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Shop.Models;
using Rebirth.Shop.Models.Results;
using System.Net;
using System.Text.Json;
using System.Text.Json.Nodes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rebirth.Shop.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        [HttpPost("authentification.json")]
        public ResultBase Post()
        {
            var database = new Database("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jerem\\source\\repos\\Rebirth\\Rebirth.Auth\\Database1.mdf;Integrated Security=True", "SqlServerDatabaseProvider");
            var datas = JsonSerializer.Deserialize<RequestDatas>(Request.Form.First().Key);
            string token = Convert.ToString(datas.Parameters.First());
            Account acc = database.SingleOrDefault<Account>("WHERE ShopToken=@0", token);

            if (acc == null)
                return new()
                {
                    result = false
                };

            HttpContext.Response.Cookies.Append("WWDE5GH86", token);
            ResultBase @base = new ResultBase();
            ResultIdentification ident = new ResultIdentification()
            {
                Nickname = acc.Login,
                Sucess = true
            };
            @base.result = true;
            return @base;
        }

        [HttpPost("account.json")]
        public ResultBase GetMoney()
        {
            var database = new Database("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jerem\\source\\repos\\Rebirth\\Rebirth.Auth\\Database1.mdf;Integrated Security=True", "SqlServerDatabaseProvider");
            var datas = JsonSerializer.Deserialize<RequestDatas>(Request.Form.First().Key);
            var token = Request.Cookies["WWDE5GH86"];
            Account acc = database.SingleOrDefault<Account>("WHERE ShopToken=@0", token);

            if (acc == null)
                return new()
                {
                    result = false
                };
            return new ResultBase() { result = new ResultMoney() { krozs = acc.Kroz, ogrins = acc.Ogrines } };
        }

        [HttpPost("shop.json")]
        public ResultBase GetHome()
        {
            var database = new Database("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jerem\\source\\repos\\Rebirth\\Rebirth.Auth\\Database1.mdf;Integrated Security=True", "SqlServerDatabaseProvider");
            var datas = JsonSerializer.Deserialize<RequestDatas>(Request.Form.First().Key);
            var token = Request.Cookies["WWDE5GH86"];
            Account acc = database.SingleOrDefault<Account>("WHERE ShopToken=@0", token);

            if (acc == null)
                return new()
                {
                    result = false
                };
            return new ResultBase()
            {
                result = new ResultContent()
                {
                     content = new ResultHome()
                     {
                         categories = new ResultCategories()
                         {
                             categories = new Categorie[5]
                             {
                                new Categorie() {
                                    id = 0,
                                    displayMod = "",
                                    key = "news",
                                    name = "Nouveautés / Promotions"
                                },
                                new Categorie() {
                                    id = 1,
                                    displayMod = "",
                                    key = "abos",
                                    name = "Abonnements"
                                },
                                new Categorie() {
                                    id = 2,
                                    displayMod = "",
                                    key = "ogrines",
                                    name = "Ogrines"
                                },
                                new Categorie() {
                                    id = 3,
                                    displayMod = "",
                                    key = "services",
                                    name = "Services"
                                },
                                new Categorie() {
                                    id = 4,
                                    displayMod = "",
                                    key = "items",
                                    name = "Objets en jeu",
                                     child = new Categorie[9]
                                     {
                                         new Categorie() {
                                            id = 5,
                                            displayMod = "",
                                            key = "emotes",
                                            name = "Attitudes"
                                        },
                                         new Categorie() {
                                            id = 6,
                                            displayMod = "",
                                            key = "compagnons",
                                            name = "Compagnons"
                                        },
                                         new Categorie() {
                                            id = 7,
                                            displayMod = "",
                                            key = "finisher",
                                            name = "Coups Fatals"
                                        },
                                         new Categorie() {
                                            id = 8,
                                            displayMod = "",
                                            key = "pets",
                                            name = "Familiers et Montilliers"
                                        },
                                         new Categorie() {
                                            id = 9,
                                            displayMod = "",
                                            key = "deguisements",
                                            name = "Harnachements"
                                        },
                                         new Categorie() {
                                            id = 10,
                                            displayMod = "",
                                            key = "havresacs",
                                            name = "Havre-Sacs"
                                        },
                                         new Categorie() {
                                            id = 11,
                                            displayMod = "",
                                            key = "boxs",
                                            name = "Blind Box"
                                        },
                                         new Categorie() {
                                            id = 12,
                                            displayMod = "",
                                            key = "objvivant",
                                            name = "Objets Vivants"
                                        },
                                         new Categorie() {
                                            id = 13,
                                            displayMod = "",
                                            key = "apparats",
                                            name = "Panoplies d'apparat"
                                        },
                                     }
                                }
                             }
                         }
                     }
                }
            };
        }
    }
}
