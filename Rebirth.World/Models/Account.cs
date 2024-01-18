using PetaPoco;
using Rebirth.Common.Extensions;
using Rebirth.Common.Protocol.Types;
using Rebirth.World.Managers;

namespace Rebirth.World.Models
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
        [Column("ShopToken")]
        public string ShopToken { get; set; } = "";
        public CharacterRoleEnum Role { get; set; }
        public DateTime MuteDate { get; set; } = DateTime.Now;
        public DateTime UnMuteDate { get; set; } = DateTime.Now;
        public string LastIp { get; set; } = "";
        public DateTime LastDate { get; set; } = DateTime.Now;
        public DateTime? UnJail { get; set; }
        public string IgnoredDatas { get; set; } = "";
        public string FriendDatas { get; set; } = "";
        public bool FriendWarnOnConnection { get; set; } = true;
        [Ignore]
        public List<FriendInformations> Friends => AccountManager.Instance.GetFriend(FriendDatas);
        [Ignore]
        public List<IgnoredInformations> Ignored => AccountManager.Instance.GetIgnored(IgnoredDatas);

    }
}
