using PetaPoco;
using Rebirth.World.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Models
{
    [PrimaryKey("Id")]
    [TableName("TriggersMap")]
    public class TriggerMap
    {
        public int Id { get; set; }
        public int MapId { get; set; }
        public int CellId { get; set; }
        public TriggerMapEnum Type { get; set; }
        public int param1 { get; set; }
        public int param2 { get; set; }
        public int param3 { get; set; }
        public int param4 { get; set; }
        public int param5 { get; set; }
    }
}
