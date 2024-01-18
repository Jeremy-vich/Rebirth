using Rebirth.Common.Dispatcher;
using Rebirth.Common.GameData.D2O;
using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Protocol.Messages;
using Rebirth.World.Managers;
using Rebirth.World.Models;

namespace Rebirth.World.Frames
{
    public class AdminFrame
    {
        [MessageHandler(AdminQuietCommandMessage.Id)]
        private void HandleAdminQuietCommandMessage(Client client, AdminQuietCommandMessage msg)
        {
            if (client.Account.Role <= CharacterRoleEnum.Player)
                return;

            Command.CommandManager.Instance.Execute(client, msg.content);
        }

        [MessageHandler(AdminCommandMessage.Id)]
        private void HandleAdminCommandMessage(Client client, AdminCommandMessage msg)
        {
            if (client.Account.Role <= CharacterRoleEnum.Player)
                return;

            Command.CommandManager.Instance.Execute(client, msg.content);
        }
    }
}
