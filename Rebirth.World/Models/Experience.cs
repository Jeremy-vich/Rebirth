using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Models
{
    [PrimaryKey("Id")]
    [TableName("Experience")]
    public class Experience
    {
        [Column("Id")]
        public int Id { get; set; } = -1;
        public double Character { get; set; } = -1;
        public int Job { get; set; } = -1;
        public int Dragodinde { get; set; } = -1;
        public double Guilde { get; set; } = -1;
        public int ObjetVivant { get; set; } = -1;
        public int JCJ { get; set; } = -1;
    }
}
