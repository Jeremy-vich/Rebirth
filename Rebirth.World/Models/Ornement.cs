using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Models
{
    [TableName("Ornements")]
    public class Ornement
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public int OrnementId { get; set; }
        public bool Enable { get; set; }
    }
}
