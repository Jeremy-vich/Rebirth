using PetaPoco;
using Rebirth.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.Auth.Models
{
    [PrimaryKey("Id", AutoIncrement = true)]
    [TableName("Account")]
    public class Account
    {
        [Column("Id")]
        public int Id { get; set; } = 0;
        [Column("Username")]
        public string Username { get; set; } = "";
        [Column("Login")]
        public string Login { get; set; } = "";
        [Column("Password")]
        public string Password { get; set; } = "";
        [Column("SecretQuestion")]
        public string SecretQuestion { get; set; } = "";
        [Column("SecretAnswer")]
        public string SecretAnswer { get; set; } = "";
        [Column("SubscriptionEndDate")]
        public double SubscriptionEndDate { get; set; } = DateTime.Now.AddYears(8).DateTimeToUnixTimestamp();
        [Column("CreationDate")]
        public double CreationDate { get; set; } = DateTime.Now.DateTimeToUnixTimestamp();
        [Column("IsAdmin")]
        public bool IsAdmin { get; set; } = false;
        [Column("Ticket")]
        public string Ticket { get; set; } = "";
        [Column("BanDate")]
        public DateTime BanDate { get; set; } = DateTime.Now;
        [Column("BanEndDate")]
        public DateTime BanEndDate { get; set; } = DateTime.Now;
        public CharacterRoleEnum Role { get; set; }
        public string FriendDatas { get; set; } = "";
        public bool FriendWarnOnConnection { get; set; } = true;
    }
}
