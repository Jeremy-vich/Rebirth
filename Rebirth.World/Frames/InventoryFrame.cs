using Rebirth.Common.Dispatcher;
using Rebirth.Common.GameData.Maps;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.World.Datas;
using Rebirth.World.Managers;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Frames
{
    public class InventoryFrame
    {
        [MessageHandler(ObjectSetPositionMessage.Id)]
        private void HandleObjectSetPositionMessage(Client client, ObjectSetPositionMessage msg)
        {
            if(msg.position < 0)
            {
                client.Send(new ObjectErrorMessage((sbyte)ObjectErrorEnum.CANNOT_EQUIP_HERE));
                return;
            }
            var item = client.Character.Items.FirstOrDefault(x => x.Id == msg.objectUID);
            if(item is null)
            {
                client.Send(new ObjectErrorMessage((sbyte)ObjectErrorEnum.CANNOT_EQUIP_HERE));
                return;
            }
            var result = client.Character.Equip(item, (CharacterInventoryPositionEnum)msg.position);

            if(result != ObjectErrorEnum.SUCCESS)
            {
                client.Send(new ObjectErrorMessage((sbyte)result));
                return;
            }
                
            if((CharacterInventoryPositionEnum)msg.position != CharacterInventoryPositionEnum.INVENTORY_POSITION_NOT_EQUIPED)
            {
                var old = client.Character.Items.FirstOrDefault(x => x.Position == (CharacterInventoryPositionEnum)msg.position);  
                if (old != null)
                {
                    if(item.EffectsS != old.EffectsS || old.Gid != item.Gid)
                    {
                        var stack = client.Character.Items.FirstOrDefault(x => x.Gid == old.Gid && x.EffectsS == old.EffectsS && x.Id != x.Id && x.Position == CharacterInventoryPositionEnum.INVENTORY_POSITION_NOT_EQUIPED);
                        if(stack != null)
                        {
                            stack.Quantity += old.Quantity;
                            ItemsManager.Instance.Save(stack);
                            client.Send(new ObjectModifiedMessage(stack.ObjectItem));
                            ItemsManager.Instance.Delete(old);
                            client.Send(new ObjectDeletedMessage((uint)old.Id));
                        }
                        else
                        {
                            old.Position = CharacterInventoryPositionEnum.INVENTORY_POSITION_NOT_EQUIPED;
                            ItemsManager.Instance.Save(old);
                            client.Send(new ObjectMovementMessage((uint)old.Id, (byte)old.Position));
                            item.Position = (CharacterInventoryPositionEnum)msg.position;
                            ItemsManager.Instance.Save(item);
                            client.Send(new ObjectMovementMessage((uint)item.Id, msg.position));
                        }
                    }
                } 
                else
                {
                    if(item.Quantity > 1)
                    {
                        var newItem = new Item(item, client.Character.Id, (CharacterInventoryPositionEnum)msg.position);
                        ItemsManager.Instance.Save(newItem);
                        client.Send(new ObjectAddedMessage(newItem.ObjectItem));
                        item.Quantity -= 1;
                        ItemsManager.Instance.Save(item);
                        client.Send(new ObjectModifiedMessage(item.ObjectItem));
                    }
                    else
                    {
                        item.Position = (CharacterInventoryPositionEnum)msg.position;
                        ItemsManager.Instance.Save(item);
                        client.Send(new ObjectMovementMessage((uint)item.Id, msg.position));
                    }
                }
            }
            else
            {
                var stack = client.Character.Items.FirstOrDefault(x => x.EffectsS == item.EffectsS && x.Gid == item.Gid && x.Id != item.Id && x.Position == CharacterInventoryPositionEnum.INVENTORY_POSITION_NOT_EQUIPED);
                if (stack != null)
                {
                    stack.Quantity += item.Quantity;
                    ItemsManager.Instance.Save(stack);
                    client.Send(new ObjectModifiedMessage(stack.ObjectItem));
                    ItemsManager.Instance.Delete(item);
                    client.Send(new ObjectDeletedMessage((uint)item.Id));
                }
                else
                {
                    item.Position = (CharacterInventoryPositionEnum)msg.position;
                    ItemsManager.Instance.Save(item);
                    client.Send(new ObjectMovementMessage((uint)item.Id, msg.position));
                }
            }
            client.Send(new InventoryWeightMessage(client.Character.Pods, client.Character.MaxPod));
            client.Send(new CharacterStatsListMessage(client.Character.CharacterCharacteristicsInformations));
        }

        [MessageHandler(ObjectDeleteMessage.Id)]
        private void HandleObjectDeleteMessage(Client client, ObjectDeleteMessage msg)
        {
            var item = client.Character.Items.FirstOrDefault(x => x.Id == msg.objectUID);
            if(item is null || msg.quantity <= 0)
            {
                client.Send(new ObjectErrorMessage((sbyte)ObjectErrorEnum.CANNOT_DESTROY));
            }
            if(item.Quantity <= msg.quantity)
            {
                ItemsManager.Instance.Delete(item);
                client.Send(new ObjectDeletedMessage((uint)item.Id));
            }
            else
            {
                item.Quantity -= (int)msg.quantity;
                ItemsManager.Instance.Save(item);
                client.Send(new ObjectModifiedMessage(item.ObjectItem));
            }
            client.Send(new InventoryWeightMessage(client.Character.Pods, client.Character.MaxPod));
            client.Send(new CharacterStatsListMessage(client.Character.CharacterCharacteristicsInformations));
        }

        [MessageHandler(ObjectDropMessage.Id)]
        private void HandleObjectDropMessage(Client client, ObjectDropMessage msg)
        {
            MapPoint point = new MapPoint((short)client.Character.CellId);
            var cell = point.GetAdjacentCells(new Func<short, bool>(x => client.Character.Map.IsCellFreeItem(x))).FirstOrDefault();
            if(cell is null)
            {
                client.Send(new ObjectErrorMessage((sbyte)ObjectErrorEnum.CANNOT_DROP_NO_PLACE));
            }
            var item = client.Character.Items.FirstOrDefault(x => x.Id == msg.objectUID);
            if(item is null || msg.quantity <= 0)
            {
                client.Send(new ObjectErrorMessage((sbyte)ObjectErrorEnum.CANNOT_DROP));
                return;
            }
            if(item.Quantity <= msg.quantity)
            {
                item.CharacterId = 0;
                item.Position = CharacterInventoryPositionEnum.INVENTORY_POSITION_NOT_EQUIPED;
                client.Character.Map.Items.Add((uint)cell.CellId, item);
                ItemsManager.Instance.Delete(item);
                client.Send(new ObjectDeletedMessage((uint)item.Id));
                client.Character.Map.Send(new ObjectGroundAddedMessage((uint)cell.CellId, (uint)item.Gid));
            }
            else
            {
                item.Quantity -= (int)msg.quantity;
                ItemsManager.Instance.Save(item);
                client.Send(new ObjectModifiedMessage(item.ObjectItem));
                var newItem = new Item()
                {
                    CharacterId = 0,
                    Gid = item.Gid,
                    EffectsS = item.EffectsS,
                    Quantity = (int)msg.quantity
                };
                client.Character.Map.Items.Add((uint)cell.CellId, newItem);
                client.Character.Map.Send(new ObjectGroundAddedMessage((uint)cell.CellId, (uint)newItem.Gid));
            }
            client.Send(new InventoryWeightMessage(client.Character.Pods, client.Character.MaxPod));
            client.Send(new CharacterStatsListMessage(client.Character.CharacterCharacteristicsInformations));
        }
    }
}
