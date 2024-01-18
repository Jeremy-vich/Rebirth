using Rebirth.Common.Dispatcher;
using Rebirth.Common.GameData.D2O;
using Rebirth.Common.GameData.Maps;
using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.World.Frames;
using Rebirth.World.Managers;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Datas.Dialogs
{
    public class CraftDialog : IDialog
    {
        public DialogTypeEnum DialogType
        {
            get
            {
                return DialogTypeEnum.DIALOG_EXCHANGE;
            }
        }

        public Client Client { get; set; }
        private Models.Job? _job;
        private Skill? _skill;
        private Dictionary<uint, int> _items = new();
        private int replay = 1;
        private Recipe? _recipe { get
            {
                var recipes = ObjectDataManager.GetAll<Recipe>();
                return recipes.FirstOrDefault(x => 
                    x.ingredientIds.All(z => 
                        _items.Select(y => 
                            Client.Character.Items.FirstOrDefault(u => 
                                u.Id == y.Key)?.Gid).Contains(z))
                    && x.quantities.All(z =>
                        _items.ContainsValue((int)z))
                );
            } 
        }

        public CraftDialog(Client client, uint skillId)
        {
            Client = client;
            _job = client.Character.Jobs.FirstOrDefault(x => x.Skills.Any(x => x.id == skillId));
            _skill = _job?.Skills.FirstOrDefault(x => x.id == skillId);
        }

        public void Close()
        {
            Client.Character.Dialog = null;
            Client.RemoveFrame(typeof(ExchangeFrame));
            Client.Send(new ExchangeLeaveMessage((sbyte)DialogType, _items.Count <= 0));
        }

        public void Open()
        {
            if (_job is null || _skill is null)
            {
                Client.Send(new ExchangeErrorMessage((sbyte)ExchangeErrorEnum.REQUEST_IMPOSSIBLE));
                return;
            }
            Client.AddFrame(typeof(ExchangeFrame));
            Client.Character.Dialog = this;
            Client.Send(new ExchangeStartOkCraftWithInformationMessage((uint)_skill.id));
        }

        public void Add(uint objectUid, int quantity)
        {
            if(quantity > 0)
            {
                var item = Client.Character.Items.FirstOrDefault(x => x.Id == objectUid);
                var actualQuantity = _items.ContainsKey(objectUid) ? _items[objectUid] : 0;
                if (actualQuantity + quantity > item.Quantity)
                    quantity = item.Quantity - actualQuantity;
                if(_items.ContainsKey(objectUid))
                {
                    _items[objectUid] += quantity;
                    Client.Send(new ExchangeObjectModifiedMessage(false, new Common.Protocol.Types.ObjectItem()
                    {
                        effects = item.ObjectEffects,
                        objectGID = (uint)item.Gid,
                        objectUID = objectUid,
                        position = (byte)item.Position,
                        quantity = (uint)(quantity + actualQuantity)
                    }));
                }
                else
                {
                    _items.Add(objectUid, quantity);
                    Client.Send(new ExchangeObjectAddedMessage(false, new Common.Protocol.Types.ObjectItem()
                    {
                        effects = item.ObjectEffects,
                        objectGID = (uint)item.Gid,
                        objectUID = objectUid,
                        position = (byte)item.Position,
                        quantity = (uint)quantity
                    }));
                }
            }
            else if(quantity < 0)
            {
                if (_items.ContainsKey(objectUid))
                {
                    _items[objectUid] += quantity;
                    if (_items[objectUid] < 0)
                    {
                        _items.Remove(objectUid);
                        Client.Send(new ExchangeObjectRemovedMessage(false, objectUid));
                    }
                    else
                    {
                        var item = Client.Character.Items.FirstOrDefault(x => x.Id == objectUid);
                        Client.Send(new ExchangeObjectModifiedMessage(false, new Common.Protocol.Types.ObjectItem()
                        {
                            effects = item.ObjectEffects,
                            objectGID = (uint)item.Gid,
                            objectUID = objectUid,
                            position = (byte)item.Position,
                            quantity = (uint)_items[objectUid]
                        }));
                    }
                }
            }

        }

        public void UpdateReplay(int replayCount)
        {
            var maxReplay = _items.Select(x => Client.Character.Items.First(z => z.Id == x.Key).Quantity / x.Value).Min();
            replay = replayCount > maxReplay ? maxReplay : replayCount;
            Client.Send(new ExchangeCraftCountModifiedMessage(replay));
        }

        public void Execute()
        {
            if (_recipe is null)
            {
                Client.Send(new ExchangeCraftResultMessage((sbyte)CraftResultEnum.CRAFT_IMPOSSIBLE));
                Close();
                return;
            }
            foreach (var item in _items)
            {
                Client.Send(new ExchangeObjectRemovedMessage(false, item.Key));
            }
            foreach (var item in _items)
            {
                var clientItem = Client.Character.Items.FirstOrDefault(x => x.Id == item.Key);
                if (clientItem.Quantity <= item.Value * replay)
                {
                    ItemsManager.Instance.Delete(clientItem);
                    Client.Send(new ObjectDeletedMessage((uint)clientItem.Id));
                }
                else
                {
                    clientItem.Quantity -= item.Value * replay;
                    ItemsManager.Instance.Save(clientItem);
                    Client.Send(new ObjectModifiedMessage(clientItem.ObjectItem));
                }
                Client.Send(new InventoryWeightMessage(Client.Character.Pods, Client.Character.MaxPod));
                Client.Send(new CharacterStatsListMessage(Client.Character.CharacterCharacteristicsInformations));
            }
            for (int i = 0; i < replay; i++)
            {
                var datas = Client.Character.AddItem(_recipe.resultId, 1);
                if (datas.Item1)
                    Client.Send(new ObjectAddedMessage(datas.Item2.ObjectItem));
                else
                    Client.Send(new ObjectModifiedMessage(datas.Item2.ObjectItem));
            }
            _items.Clear();
        }
    }
}
