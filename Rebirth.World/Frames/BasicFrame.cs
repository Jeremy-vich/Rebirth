using Rebirth.Common.Dispatcher;
using Rebirth.Common.Network;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Random;
using Rebirth.World.Managers;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Frames
{
    public class BasicFrame
    {
        [MessageHandler(BasicPingMessage.Id)]
        private void HandleBasicPingMessage(Client client, BasicPingMessage msg)
        {
            client.Send(new BasicPongMessage());
        }

        [MessageHandler(ClientKeyMessage.Id)]
        private void HandleClientKeyMessage(Client client, ClientKeyMessage msg)
        {
            // TODO : Vérifier la clé du client n'est pas ban
        }

        [MessageHandler(ChannelEnablingMessage.Id)]
        private void HandleChannelEnablingMessage(Client client, ChannelEnablingMessage msg)
        {
            
        }


        [MessageHandler(KrosmasterAuthTokenRequestMessage.Id)]
        private void HandleKrosmasterAuthTokenRequestMessage(Client client, KrosmasterAuthTokenRequestMessage message)
        {
            string newTicket = StringGenerator.GetRandomString(60);
            client.Account.ShopToken = newTicket;
            client.Send(new KrosmasterAuthTokenMessage(newTicket));
            AccountManager.Instance.Save(client.Account);
        }

        [MessageHandler(QuestListRequestMessage.Id)]
        private void HandleQuestListRequestMessage(Client client, QuestListRequestMessage msg)
        {
            client.Send(new QuestListMessage(Array.Empty<uint>(), Array.Empty<uint>(), Array.Empty<Common.Protocol.Types.QuestActiveInformations>(), Array.Empty<uint>()));
        }
    }
}
