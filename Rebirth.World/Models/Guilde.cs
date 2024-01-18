using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Models
{
    [TableName("Guildes")]
    public class Guilde
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Exp { get; set; }
    }
}
