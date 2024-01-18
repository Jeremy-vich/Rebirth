using Rebirth.Common.Dispatcher;
using Rebirth.Common.Network;
using Rebirth.Common.Protocol.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.Auth.Frames
{
    public class BasicFrame
    {
        [MessageHandler(BasicPingMessage.Id)]
        private void HandleBasicPingMessage(IClient client, BasicPingMessage msg)
        {
            client.Send(new BasicPongMessage());
        }
    }
}
