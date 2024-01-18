using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Models
{
    [TableName("MontersMap")]
    [PrimaryKey("Id", AutoIncrement = false)]
    public class MonstersMap
    {
        public int Id { get; set; }
        public int Delay { get; set; }
        public string Datas { get; set; }
    }
}
