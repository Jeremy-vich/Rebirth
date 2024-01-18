using Rebirth.Common.Dispatcher;
using Rebirth.Common.GameData.D2O;
using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Protocol.Messages;
using Rebirth.World.Datas.Dialogs;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Frames
{
    public class ExchangeFrame
    {
        [MessageHandler(ExchangeObjectMoveMessage.Id)]
        private void HandleExchangeObjectMoveMessage(Client client, ExchangeObjectMoveMessage msg)
        {
            if (client.Character.Dialog is CraftDialog)
            {
                var atelier = (CraftDialog)client.Character.Dialog;
                atelier.Add(msg.objectUID, msg.quantity);
            }
        }

        [MessageHandler(ExchangeCraftCountRequestMessage.Id)]
        private void HandleExchangeCraftCountRequestMessage(Client client, ExchangeCraftCountRequestMessage msg)
        {
            if (msg.count <= 0)
                return;
            if (client.Character.Dialog is CraftDialog)
            {
                var atelier = (CraftDialog)client.Character.Dialog;
                atelier.UpdateReplay(msg.count);
            }
        }

        [MessageHandler(ExchangeSetCraftRecipeMessage.Id)]
        private void HandleExchangeSetCraftRecipeMessage(Client client, ExchangeSetCraftRecipeMessage msg)
        {
            if (client.Character.Dialog is CraftDialog)
            {
                var atelier = (CraftDialog)client.Character.Dialog;
                var recipe = ObjectDataManager.Get<Recipe>(msg.objectGID);
                if (recipe is null)
                    return;
                for (int i = 0; i < recipe.ingredientIds.Count; i++)
                {
                    var ingredient = recipe.ingredientIds[i];
                    var item = client.Character.Items.FirstOrDefault(x => x.Gid == ingredient);
                    if (item is null) continue;
                    atelier.Add((uint)item.Id, (int)recipe.quantities[i]);
                }
            }
        }

        [MessageHandler(ExchangeReadyMessage.Id)]
        private void HandleExchangeReadyMessage(Client client, ExchangeReadyMessage msg)
        {
            (client.Character.Dialog as CraftDialog)?.Execute();
        }
    }
}
