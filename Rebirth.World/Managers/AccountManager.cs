using Rebirth.Common.Extensions;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Types;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Managers
{
    public class AccountManager : DataManager<AccountManager>
    {
        public Account? Get(string ticket) => Starter.DatabaseAuth.SingleOrDefault<Account>("SELECT * FROM Account WHERE Ticket=@0", ticket);
        public Account? Get(double id) => Starter.DatabaseAuth.SingleOrDefault<Account>(id);
        public Account? GetByName(string name) => Starter.DatabaseAuth.SingleOrDefault<Account>("SELECT * FROM Account WHERE Username=@0", name);
        public void Save(Account account) => Starter.DatabaseAuth.Save(account);

        public FriendInformations GetFriend(double id)
        {
            var acc = Get(id);
            var client = ClientsManager.Instance.Get(x => x.Account.Id == id);
            if (client is null) return new FriendInformations(acc.Id, acc.Username, (sbyte)PlayerStateEnum.NOT_CONNECTED, 0, 0);
            else return new FriendOnlineInformations(acc.Id, acc.Username, (sbyte)PlayerStateEnum.GAME_TYPE_ROLEPLAY, 0, 0, client.Character.Id, client.Character.Name, client.Character.Level, 0, (sbyte)client.Character.BreedId, client.Character.Sex, new GuildInformations(0, "", 0, new(0, 0, 0, 0)), 0, new PlayerStatus((sbyte)PlayerStatusEnum.PLAYER_STATUS_AVAILABLE));
        }
        public List<FriendInformations> GetFriend(string friendDatas)
        {
            if (string.IsNullOrEmpty(friendDatas))
                return new();
            var datas = friendDatas.Split(',');
            var result = new List<FriendInformations>();
            foreach (var id in datas)
            {
                if(string.IsNullOrEmpty(id)) continue;
                var acc = Get(double.Parse(id));
                if(acc is null) continue;
                var client = ClientsManager.Instance.Get(x => x.Account.Id == double.Parse(id));
                if (client is null || client.Character is null) result.Add(new FriendInformations(acc.Id, acc.Username, (sbyte)PlayerStateEnum.NOT_CONNECTED, 0, 0));
                else result.Add(new FriendOnlineInformations(acc.Id, acc.Username, (sbyte)PlayerStateEnum.GAME_TYPE_ROLEPLAY, (uint)0, 0, client.Character.Id, client.Character.Name, client.Character.Level, 0, (sbyte)client.Character.BreedId, client.Character.Sex, new GuildInformations(0, "", 0, new(0, 0, 0, 0)), 0, new PlayerStatus((sbyte)PlayerStatusEnum.PLAYER_STATUS_AVAILABLE)));
            }
            return result;
        }
        public IgnoredInformations GetIgnored(double id)
        {
            var acc = Get(id);
            var client = ClientsManager.Instance.Get(x => x.Account.Id == id);
            if (client is null) return new IgnoredInformations(acc.Id, acc.Username);
            else return new IgnoredOnlineInformations(acc.Id, acc.Username, client.Character.Id, client.Character.Name, (sbyte)client.Character.BreedId, client.Character.Sex);
        }
        public List<IgnoredInformations> GetIgnored(string ignoredDatas)
        {
            if (string.IsNullOrEmpty(ignoredDatas))
                return new();
            var datas = ignoredDatas.Split(',');
            var result = new List<IgnoredInformations>();
            foreach (var id in datas)
            {
                if (string.IsNullOrEmpty(id)) continue;
                var acc = Get(double.Parse(id));
                if (acc is null) continue;
                var client = ClientsManager.Instance.Get(x => x.Account.Id == double.Parse(id));
                if (client is null || client.Character is null) result.Add(new IgnoredInformations(acc.Id, acc.Username));
                else result.Add(new IgnoredOnlineInformations(acc.Id, acc.Username, client.Character.Id, client.Character.Name, (sbyte)client.Character.BreedId, client.Character.Sex));
            }
            return result;
        }
    }
}
