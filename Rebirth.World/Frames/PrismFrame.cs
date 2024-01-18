using Rebirth.Common.Dispatcher;
using Rebirth.Common.GameData.D2O;
using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Protocol.Types;
using Rebirth.World.Models;

namespace Rebirth.World.Frames
{
    public class PrismFrame
    {
        [MessageHandler(PrismsListRegisterMessage.Id)]
        private void HandlePrismsListRegisterMessage(Client client, PrismsListRegisterMessage msg)
        {
            var list = new List<PrismSubareaEmptyInfo>();
            foreach (var item in ObjectDataManager.GetAll<SubArea>())
            {
                list.Add(new PrismSubareaEmptyInfo((uint)item.id, 0));
            }
            client.Send(new PrismsListUpdateMessage(list.ToArray()));
        }
    }
}
