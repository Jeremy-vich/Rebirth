using PetaPoco;
using Rebirth.Common.Protocol.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Models
{   
    [TableName("InteractiveData")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class InteractiveData
    {       
        public int Id { get; set; }
        public int Identifier { get; set; }
        public int MapId { get; set; }
        public int CellId { get; set; }
        public InteractiveTypeEnum Type { get; set; }
        public bool OnMap { get; set; }
        public string Condition { get; set; } = "";
        public int param1 { get; set; }
        public int param2 { get; set; }
        public string param3 { get; set; } = "";
        public string param4 { get; set; } = "";
        public string param5 { get; set; } = "";
        public string Description { get; set; } = "";
    }
}
