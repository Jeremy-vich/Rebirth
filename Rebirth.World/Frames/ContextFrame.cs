using Rebirth.Common.Dispatcher;
using Rebirth.Common.Extensions;
using Rebirth.Common.GameData.Maps;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Protocol.Types;
using Rebirth.World.Managers;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Frames
{
    public class ContextFrame
    {
        [MessageHandler(GameContextCreateRequestMessage.Id)]
        private void HandleGameContextCreateRequestMessage(Client client, GameContextCreateRequestMessage msg)
        {

            client.RemoveFrame(typeof(ContextFrame));
            client.AddFrame(typeof(RolePlayFrame));

            client.Send(new GameContextDestroyMessage());
            client.Send(new GameContextCreateMessage(1));

            client.Send(new CharacterStatsListMessage(client.Character.CharacterCharacteristicsInformations));

            client.Character.Map.Enter(client);
        }
    }
}
