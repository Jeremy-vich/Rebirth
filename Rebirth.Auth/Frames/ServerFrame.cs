using Rebirth.Auth.Managers;
using Rebirth.Auth.Models;
using Rebirth.Common.Dispatcher;
using Rebirth.Common.Extensions;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.Auth.Frames
{
    public class ServerFrame
    {
        [MessageHandler(AcquaintanceSearchMessage.Id)]
        private void HandleAcquaintanceSearchMessage(Client client, AcquaintanceSearchMessage msg)
        {
            var list = ServersManager.Instance.Get($"{msg.tag.nickname}#{msg.tag.tagNumber}");
            if(list == null)
            {
                client.Send(new AcquaintanceSearchErrorMessage(2));
                return;
            }
            else
            {
                if(list.Count <= 0)
                {
                    client.Send(new AcquaintanceSearchErrorMessage(2));
                    return;
                }
                else
                {
                    client.Send(new AcquaintanceServerListMessage(list.ToArray()));
                    return;
                }
            }
        }

        [MessageHandler(ServerSelectionMessage.Id)]
        private void HandleServerSelectionMessage(Client client, ServerSelectionMessage msg)
        {
            var server = ServersManager.Instance.Get((short)msg.serverId);
            if(server is null)
                client.Send(new SelectedServerRefusedMessage(msg.serverId, (sbyte)ServerConnectionErrorEnum.SERVER_CONNECTION_ERROR_NO_REASON, (sbyte)ServerStatusEnum.STATUS_UNKNOWN));
            else
            {
                client.Account.Ticket = new Random().RandomString(16);
                Starter.Database.Save(client.Account);
                client.Send(new SelectedServerDataMessage(server.Id, server.Ip, new uint[] { (uint)server.Port }, true, Encoding.Default.GetBytes(client.Account.Ticket).Select(x => (sbyte)x).ToArray()));
                client.Disconnect();
            }    
        }
    }
}
