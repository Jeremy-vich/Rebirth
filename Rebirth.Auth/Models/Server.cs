using PetaPoco;
using Rebirth.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.Auth.Models
{
    [PrimaryKey("Id")]
    [TableName("Server")]
    public class Server
    {
        [Column("Id")]
        public uint Id { get; set; }
        [Column("Ip")]
        public string Ip { get; set; } = "127.0.0.1";
        [Column("Port")]
        public int Port { get; set; }
        [Column("Base")]
        public string Base { get; set; } = "";
        [Column("Statut")]
        public int Statut { get; set; } = 0;
    }
}
