using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Models
{
    [TableName("Emotes")]
    public class Emote
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public int EmoteId { get; set; }
    }
}
