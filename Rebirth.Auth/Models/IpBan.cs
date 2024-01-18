using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.Auth.Models
{
    [PrimaryKey("Id")]
    [TableName("IpsBan")]
    public class IpBan
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("Ip")]
        public string Ip { get; set; } = "";
        [Column("BanDate")]
        public DateTime BanDate { get; set; }
        [Column("BanEndDate")]
        public DateTime BanEndDate { get; set; }
    }
}
