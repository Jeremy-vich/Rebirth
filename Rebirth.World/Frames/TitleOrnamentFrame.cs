using Rebirth.Common.Dispatcher;
using Rebirth.Common.Protocol.Messages;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Frames
{
    public class TitleOrnamentFrame
    {
        [MessageHandler(TitlesAndOrnamentsListRequestMessage.Id)]
        private void HandleTitlesAndOrnamentsListRequestMessage(Client client, TitlesAndOrnamentsListRequestMessage msg)
        {
            client.Send(new TitlesAndOrnamentsListMessage(client.Character.Titles.Select(x => (uint)x.TitleId).ToArray(),
                client.Character.Ornements.Select(x => (uint)x.OrnementId).ToArray(),
                (uint)(client.Character.Title?.TitleId ?? 0), (uint)(client.Character.Ornement?.OrnementId ?? 0)));
        }

        [MessageHandler(TitleSelectRequestMessage.Id)]
        private void HandleMessage(Client client, TitleSelectRequestMessage msg)
        {
            if (client.Character.SetTitle(msg.titleId))
                client.Send(new TitleSelectedMessage(msg.titleId));
            else
                client.Send(new TitleSelectErrorMessage(1));
        }

        [MessageHandler(OrnamentSelectRequestMessage.Id)]
        private void HandleOrnamentSelectRequestMessage(Client client, OrnamentSelectRequestMessage msg)
        {
            if (client.Character.SetOrnament(msg.ornamentId))
                client.Send(new OrnamentSelectedMessage(msg.ornamentId));
            else
                client.Send(new OrnamentSelectErrorMessage(1));
        }
    }
}
