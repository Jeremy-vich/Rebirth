using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Models
{
    [TableName("Titles")]
    public class Title
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public int TitleId { get; set; }
        public bool Enable { get; set; }
    }
}
