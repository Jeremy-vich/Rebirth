using Rebirth.Common.Network;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Protocol.Types;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Datas
{
    public class Party
    {
        private List<Client> _clients = new List<Client>();
        private List<Client> _guests = new List<Client>();
        private Client _leader;
        public uint Id { get; set; }

        #region Get
        public PartyMemberInformations[] PartyMemberInformations => _clients.Select(x => x.Character.PartyMemberInformations).ToArray();
        public PartyGuestInformations[] PartyGuestInformations => _guests.Select(x => x.Character.PartyGuestInformations(Id)).ToArray();
        #endregion

        public void Enter(Client client)
        {
            if(_leader is null)
                _leader = client;
            Id = 1;
            _clients.Add(client);

            Send(new PartyJoinMessage(Id, (sbyte)PartyTypeEnum.PARTY_TYPE_CLASSICAL, _leader.Character.Id, 8, PartyMemberInformations, PartyGuestInformations, false, "Test"));
        }

        public void Invitation(Client client, Client from)
        {
            _guests.Add(client);

            Send(new PartyNewGuestMessage(Id, client.Character.PartyGuestInformations(Id)));
            client.Send(new PartyInvitationMessage(Id, (sbyte)PartyTypeEnum.PARTY_TYPE_CLASSICAL, "Test", 8, from.Character.Id, from.Character.Name, 0));
        }



        public void Send(NetworkMessage msg)
        {
            foreach (var client in _clients)
                client.Send(msg);
        }
    }
}
