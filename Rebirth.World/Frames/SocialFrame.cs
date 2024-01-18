using Rebirth.Common.Dispatcher;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Protocol.Types;
using Rebirth.World.Datas;
using Rebirth.World.Managers;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Frames
{
    public class SocialFrame
    {
        [MessageHandler(IgnoredAddRequestMessage.Id)]
        private void HandleIgnoredAddRequestMessage(Client client, IgnoredAddRequestMessage msg)
        {
            var friend = CharacterManager.Instance.Get(msg.name);
            var acc = AccountManager.Instance.GetByName(msg.name);
            if (friend is null && acc is null)
            {
                client.Send(new IgnoredAddFailureMessage((sbyte)ListAddFailureEnum.LIST_ADD_FAILURE_NOT_FOUND));
                return;
            }
            if (friend?.AccountId == client.Account.Id || acc?.Id == client.Account.Id)
            {
                client.Send(new IgnoredAddFailureMessage((sbyte)ListAddFailureEnum.LIST_ADD_FAILURE_EGOCENTRIC));
                return;
            }
            var id = friend?.AccountId ?? acc?.Id;
            if (client.Account.Friends.Any(x => x.accountId == id))
            {
                client.Send(new IgnoredAddFailureMessage((sbyte)ListAddFailureEnum.LIST_ADD_FAILURE_IS_DOUBLE));
                return;
            }
            client.Account.IgnoredDatas += $"{id},";
            AccountManager.Instance.Save(client.Account);
            client.Send(new IgnoredAddedMessage(AccountManager.Instance.GetIgnored((double)id), msg.session));
        }

        [MessageHandler(IgnoredDeleteRequestMessage.Id)]
        private void HandleFriendDeleteRequestMessage(Client client, IgnoredDeleteRequestMessage msg)
        {
            var friend = AccountManager.Instance.Get(msg.accountId);
            if (friend is null)
            {
                client.Send(new FriendDeleteResultMessage(false, ""));
                return;
            }
            client.Account.IgnoredDatas = client.Account.IgnoredDatas.Replace($"{msg.accountId},", "");
            AccountManager.Instance.Save(client.Account);
            client.Send(new FriendDeleteResultMessage(true, friend.Username));
        }

        [MessageHandler(FriendsGetListMessage.Id)]
        private void HandleFriendsGetListMessage(Client client, FriendsGetListMessage msg)
        {
            client.Send(new FriendsListMessage(client.Account.Friends.ToArray()));
        }

        [MessageHandler(FriendAddRequestMessage.Id)]
        private void HandleFriendAddRequestMessage(Client client, FriendAddRequestMessage msg)
        {           
            var friend = CharacterManager.Instance.Get(msg.name);
            var acc = AccountManager.Instance.GetByName(msg.name);
            if (friend is null && acc is null)
            {
                client.Send(new FriendAddFailureMessage((sbyte)ListAddFailureEnum.LIST_ADD_FAILURE_NOT_FOUND));
                return;
            }
            if (friend?.AccountId == client.Account.Id || acc?.Id == client.Account.Id)
            {
                client.Send(new FriendAddFailureMessage((sbyte)ListAddFailureEnum.LIST_ADD_FAILURE_EGOCENTRIC));
                return;
            }
            var id = friend?.AccountId ?? acc?.Id;
            if (client.Account.Friends.Any(x => x.accountId == id))
            {
                client.Send(new FriendAddFailureMessage((sbyte)ListAddFailureEnum.LIST_ADD_FAILURE_IS_DOUBLE));
                return;
            }
            client.Account.FriendDatas += $"{id},";
            AccountManager.Instance.Save(client.Account);
            client.Send(new FriendAddedMessage(AccountManager.Instance.GetFriend((double)id)));
        }

        [MessageHandler(FriendDeleteRequestMessage.Id)]
        private void HandleFriendDeleteRequestMessage(Client client, FriendDeleteRequestMessage msg)
        {

            var friend = AccountManager.Instance.Get(msg.accountId);
            if (friend is null)
            {
                client.Send(new FriendDeleteResultMessage(false, ""));
                return;
            }
            client.Account.FriendDatas = client.Account.FriendDatas.Replace($"{msg.accountId},", "");
            AccountManager.Instance.Save(client.Account);
            client.Send(new FriendDeleteResultMessage(true, friend.Username));
        }

        [MessageHandler(IgnoredGetListMessage.Id)]
        private void HandleIgnoredGetListMessage(Client client, IgnoredGetListMessage msg)
        {
            client.Send(new IgnoredListMessage(client.Account.Ignored.ToArray()));
        }

        [MessageHandler(SpouseGetInformationsMessage.Id)]
        private void HandleSpouseGetInformationsMessage(Client client, SpouseGetInformationsMessage msg)
        {
            //client.Send(new SpouseInformationsMessage(new FriendSpouseInformations()));
        }

        [MessageHandler(FriendSetWarnOnConnectionMessage.Id)]
        private void HandleFriendSetWarnOnConnectionMessage(Client client, FriendSetWarnOnConnectionMessage msg)
        {
            client.Account.FriendWarnOnConnection = msg.enable;
            AccountManager.Instance.Save(client.Account);
        }

        [MessageHandler(PartyInvitationRequestMessage.Id)]
        private void HandlePartyInvitationRequestMessage(Client client, PartyInvitationRequestMessage msg)
        {
            var invit = ClientsManager.Instance.Get(msg.name);
            if (invit is null)
                return; // TODO : trouver le message d'erreur que le joueur invité n'est pas connecté
            if(client.Party is null)
            {
                client.Party = new Party();
                client.Party.Enter(client);
            }
            invit.Character.Hosteds.Add(client.Party.Id, client.Character.Id);
            client.Party.Invitation(invit, client);
        }
    }
}
