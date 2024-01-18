using Rebirth.Common.Extensions;
using Rebirth.Common.GameData.D2O;
using Rebirth.Common.GameData.Maps;
using Rebirth.Common.IStructures;
using Rebirth.Common.Network;
using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Protocol.Types;
using Rebirth.World.Datas.Interactives.Types.Classic;
using Rebirth.World.Datas.Interactives.Types;
using Rebirth.World.Managers;
using MapsManager = Rebirth.World.Managers.MapsManager;
using Rebirth.World.Enums;
using Rebirth.World.Services;
using Rebirth.World.Datas;
using System.Globalization;
using Rebirth.World.Datas.Events;

namespace Rebirth.World.Models
{
    public class Map
    {
        #region Datas
        public Common.GameData.Maps.Map Template { get; set; }
        public MapPosition Position { get; set; }
        public List<TriggerMap> Triggers { get { return Starter.DatabaseWorld.Fetch<TriggerMap>("WHERE MapId = @0", Template.Id); } }
        public List<Npc> Npcs { 
            get {
                List<Tuple<int, int>> npcs = new();
                foreach (var npc in ObjectDataManager.Get<SubArea>(Template.SubAreaId).npcs)
                {
                    npcs.Add(new Tuple<int, int>(npc[0], npc[1]));
                }
                return npcs.FindAll(x => x.Item2 == Template.Id).Select(x => ObjectDataManager.Get<Npc>(x.Item1)).ToList();
            }
        }
        public Dictionary<uint, Item> Items { get; set; } = new();
        public List<MonsterGroup> MonsterGroups { get; set; } = new();
        private SmileyEvent? _smileyEvent;
        #endregion

        #region Vars
        private List<Client> _clients = new();
        private List<AbstractInteractive> _interactives = new();
        private Dictionary<FightPositionEnum, List<int>> _figthCells = new()
        {
            { FightPositionEnum.Blue, new() },
            { FightPositionEnum.Red, new() },
        };
        #endregion

        #region Get
        public MonstersMap? MonstersMap => MonstersManager.Instance.Get(Template.Id);
        public GameRolePlayActorInformations[] GameRolePlayActorInformations
        {
            get
            {
                List<GameRolePlayActorInformations> grpai = new();
                grpai.AddRange(_clients.Select(x => x.Character.GameRolePlayCharacterInformations));
                //grpai.AddRange(Npcs.Select((x, i) => new GameRolePlayNpcInformations(x.id * -1, new EntityLook(x.look, true).GetEntityLook(), new EntityDispositionInformations((short)Template.Cells.FindAll(u => !u.NonWalkableDuringFight && u.NonWalkableDuringRP)[i].Id, (sbyte)DirectionsEnum.DIRECTION_SOUTH_WEST), (uint)x.id, x.gender == 0, 0)));
                grpai.AddRange(MonsterGroups.Select(x => x.GameRolePlayGroupMonsterInformations));
                return grpai.ToArray();
            }
        }

        public bool IsCellFree(short cell)
        {
            CellData newCell = Template.Cells.FirstOrDefault(x => x.Id == cell);
            return newCell != null ? newCell.Mov && !newCell.FarmCell : false;
        }

        public uint GetRandomCell()
        {
            var cellid = -1;
            do
            {
                var rdn = new Random().Next(1, Template.Cells.Count);
                if(IsCellFree((short)rdn))
                    cellid = rdn;
            } while (cellid == -1);
            return (uint)cellid;
        }
        #endregion

        public Map(Common.GameData.Maps.Map template, MapPosition position)
        {
            (Template, Position) = (template, position);
            var cells = Template.Cells.FindAll(x => x.Red);
            if (cells.Count > 0)
            {
                _figthCells[FightPositionEnum.Red] = cells.Select(x => x.Id).ToList();
                cells = Template.Cells.FindAll(x => x.Blue);
                if (cells.Count > 0)
                    _figthCells[FightPositionEnum.Blue] = cells.Select(x => x.Id).ToList();
            } else
                InitPositions();

            _interactives = InteractivesManager.Instance.GetInteractives(Template.Id);

            if(Position.worldMap >= 1 || (Position.allowFightChallenges && Position.allowTaxCollector))
                InitMonsters();
        }

        #region Monsters
        public void UpdateMonsters()
        {
            var mons = new MonsterGroup[MonsterGroups.Count];
            MonsterGroups.CopyTo(mons);
            foreach (var group in mons)
                RemoveMonster(group.id);

            InitMonsters();
        }
        public void RemoveMonster(double id)
        {
            var group = MonsterGroups.FirstOrDefault(x => x.id == id);
            if(group is not null)
            {
                MonsterGroups.Remove(group);
                Send(new GameContextRemoveElementMessage(id));
            }
        }
        private void InitMonsters()
        {
            if (MonstersMap is null)
                return;
            for (int i = 1; i < 4; i++)
            {
                var group = new MonsterGroup(this, i, GetRandomCell());
                if (group.Monsters.Count <= 0)
                    return;
                MonsterGroups.Add(group);
                if(_clients.Count > 0)
                    Send(new GameRolePlayShowActorMessage(group.GameRolePlayGroupMonsterInformations));
            }
        }
        #endregion

        #region Fight

        public void InitPositions()
        {
            try
            {
                CultureInfo myCI = new CultureInfo("fr-FR");
                Calendar myCal = myCI.Calendar;
                // Gets the DTFI properties required by GetWeekOfYear.
                CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
                DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
                bool isDistance = myCal.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW) % 2 == 0;

                Random rdn = new Random();
                var nbr = Enum.GetNames(typeof(FightPositionModelEnum)).Length - 1;
                var rng = rdn.Next(0, Enum.GetNames(typeof(FightPositionModelEnum)).Length);
                FightPositionModelEnum model = (FightPositionModelEnum)rng;

                bool result = true;
                switch (model)
                {
                    case FightPositionModelEnum.X6X2:
                        // potentiel direction
                        var test = X6X2Template.GetCells(Template.Cells);
                        if (test.Count <= 0)
                        {
                            result = false;
                            break;
                        }
                        // Aujourd'hui map cac
                        rng = rdn.Next(0, test.Count);
                        var cellDir = test.ElementAt(rng).Value;
                        rng = rdn.Next(0, cellDir.Count);
                        _figthCells[FightPositionEnum.Red] = cellDir.ElementAt(rng).Value;
                        // Il faut trier chaque direction et chaque cellule de départ du pattern
                        var temp = test.ToDictionary(entry => entry.Key,
                                                   entry => entry.Value);
                        foreach (var item in temp)
                        {
                            var item1 = item.Value.Where(x => !x.Value.Any(z => _figthCells[FightPositionEnum.Red].Any(y => y == z)));
                            if (item1.Count() <= 0)
                                test.Remove(item.Key);
                            else
                                if (isDistance)
                                test[item.Key] = item1
                                    .Where(x => x.Value.All(z => _figthCells[FightPositionEnum.Red].All(y => new MapPoint((short)y).DistanceToCell(new MapPoint((short)z)) > 6)))
                                    .ToDictionary(x => x.Key, x => x.Value);
                            else
                                test[item.Key] = item1
                                    .Where(x => x.Value.Any(z => _figthCells[FightPositionEnum.Red].Any(y => new MapPoint((short)y).DistanceToCell(new MapPoint((short)z)) <= 10)))
                                    .ToDictionary(x => x.Key, x => x.Value);
                        }
                        rng = rdn.Next(0, test.Count);
                        cellDir = test.ElementAt(rng).Value;
                        if (test.Count <= 0)
                        {
                            result = false;
                            break;
                        }
                        rng = rdn.Next(0, test.Count);
                        _figthCells[FightPositionEnum.Blue] = cellDir.ElementAt(rng).Value;
                        break;
                    case FightPositionModelEnum.Damier:
                        var test1 = DamierTemplate.GetCells(Template.Cells);
                        if (test1.Count <= 0)
                        {
                            result = false;
                            break;
                        }
                        rng = rdn.Next(0, test1.Count - 1);
                        var select = test1.ElementAt(rng).Value;
                        _figthCells[FightPositionEnum.Red].Add(select[0]);
                        _figthCells[FightPositionEnum.Red].Add(select[1]);
                        var sel = select.GetRange(2, test1.ElementAt(0).Value.Count - 2);
                        for (int i = 0; i < sel.Count; i++)
                        {
                            if (i == sel.Count / 2)
                                continue;
                            if (i % 2 == 1)
                                _figthCells[FightPositionEnum.Red].Add(sel[i]);
                            else
                                _figthCells[FightPositionEnum.Blue].Add(sel[i]);
                        }
                        break;
                    case FightPositionModelEnum.Losange:
                        test1 = LosangeTemplate.GetCells(Template.Cells);
                        if (test1.Count <= 0)
                        {
                            result = false;
                            break;
                        }
                        rng = rdn.Next(0, test1.Count - 1);
                        select = test1.ElementAt(rng).Value;
                        _figthCells[FightPositionEnum.Red].Add(select[0]);
                        _figthCells[FightPositionEnum.Red].Add(select[1]);
                        sel = select.GetRange(2, test1.ElementAt(0).Value.Count - 2);
                        for (int i = 0; i < sel.Count; i++)
                        {
                            if (i < (sel.Count / 2) - 1)
                                _figthCells[FightPositionEnum.Red].Add(sel[i]);
                            else
                                _figthCells[FightPositionEnum.Blue].Add(sel[i]);
                        }
                        break;
                    case FightPositionModelEnum.Cible:
                        test1 = CibleTemplate.GetCells(Template.Cells);
                        if (test1.Count <= 0)
                        {
                            result = false;
                            break;
                        }
                        rng = rdn.Next(0, test1.Count - 1);
                        select = test1.ElementAt(rng).Value;
                        _figthCells[FightPositionEnum.Red].Add(select[0]);
                        _figthCells[FightPositionEnum.Red].Add(select[1]);
                        sel = select.GetRange(2, test1.ElementAt(0).Value.Count - 2);
                        for (int i = 0; i < sel.Count; i++)
                        {
                            if (i < (sel.Count / 2) - 1)
                                _figthCells[FightPositionEnum.Red].Add(sel[i]);
                            else
                                _figthCells[FightPositionEnum.Blue].Add(sel[i]);
                        }
                        break;
                    case FightPositionModelEnum.Random:
                    default:
                        for (int i = 0; i < 12; i++)
                        {
                            var cells = Template.Cells.FindAll(x => x.Mov && !x.FarmCell
                            && !_figthCells[FightPositionEnum.Red].Any(z => z == x.Id)
                            && !_figthCells[FightPositionEnum.Blue].Any(z => z == x.Id));
                            rng = rdn.Next(0, cells.Count);
                            _figthCells[FightPositionEnum.Red].Add(cells[rng].Id);
                        }
                        for (int i = 0; i < 12; i++)
                        {
                            var cells = Template.Cells.FindAll(x => x.Mov && !x.FarmCell
                            && !_figthCells[FightPositionEnum.Red].Any(z => z == x.Id)
                            && !_figthCells[FightPositionEnum.Blue].Any(z => z == x.Id));
                            rng = rdn.Next(0, cells.Count);
                            _figthCells[FightPositionEnum.Blue].Add(cells[rng].Id);
                        }
                        break;
                }
                if (!result)
                {
                    for (int i = 0; i < 12; i++)
                    {
                        var cells = Template.Cells.FindAll(x => x.Mov && !x.FarmCell
                        && !_figthCells[FightPositionEnum.Red].Any(z => z == x.Id)
                        && !_figthCells[FightPositionEnum.Blue].Any(z => z == x.Id));
                        rng = rdn.Next(0, cells.Count);
                        _figthCells[FightPositionEnum.Red].Add(cells[rng].Id);
                    }
                    for (int i = 0; i < 12; i++)
                    {
                        var cells = Template.Cells.FindAll(x => x.Mov && !x.FarmCell
                        && !_figthCells[FightPositionEnum.Red].Any(z => z == x.Id)
                        && !_figthCells[FightPositionEnum.Blue].Any(z => z == x.Id));
                        rng = rdn.Next(0, cells.Count);
                        _figthCells[FightPositionEnum.Blue].Add(cells[rng].Id);
                    }
                }
            }
            catch (Exception)
            {
                _figthCells[FightPositionEnum.Red] = new();
                _figthCells[FightPositionEnum.Blue] = new();
                Console.WriteLine($"[World.Map.FightPosition] Cells disponible = 0 sur la map = {Template.Id} !");
            }
        }

        public List<int> GetFightCells(FightPositionEnum team) => _figthCells[team];
        #endregion

        #region Interactives
        public void UpdateInteractives()
        {
            _interactives = InteractivesManager.Instance.GetInteractives(Template.Id);
        }

        public void UpdateInteractive(Ressource interactive)
        {
            foreach (var client in _clients)
            {
                var datass = new StatedElementUpdatedMessage(interactive.GetStatedElement());
                client.Send(datass);
                var datas = new InteractiveElementUpdatedMessage(interactive.GetInteractiveElement(client));
                client.Send(datas);
            }
        }

        public AbstractInteractive GetInterctive(int id)
        {
            return _interactives.FirstOrDefault(x => x.Identifier == id);
        }

        public List<AbstractInteractive> GetInterctives()
        {
            return _interactives;
        }

        public InteractiveElement[] GetInteractives(Client client)
        {
            return (from x in _interactives
                    select x.GetInteractiveElement(client)).ToArray();
        }

        public StatedElement[] GetStatedElements()
        {
            return (from IStatedElement x in _interactives.FindAll(z => z is IStatedElement)
                    where x is not null
                    select x.GetStatedElement()).ToArray();
        }

        public AbstractInteractive GetZaap()
        {
            return _interactives.FirstOrDefault(x => x is InteractiveZaap);
        }

        public AbstractInteractive GetZaapi()
        {
            return _interactives.FirstOrDefault(x => x is InteractiveZaapi);
        }
        #endregion

        #region Client Method
        public void Enter(Client client)
        {
            Send(new GameRolePlayShowActorMessage(client.Character.GameRolePlayCharacterInformations));
            _clients.Add(client);

            client.Send(new CurrentMapMessage(Template.Id, "649ae451ca33ec53bbcbcc33becf15f4"));
        }

        public void Exit(Client client)
        {
            _clients.Remove(client);
            Send(new GameContextRemoveElementMessage(client.Character.Id));
        }

        public void Send(NetworkMessage msg)
        {
            foreach (var item in _clients)
                item.Send(msg);
        }

        public void MoveEntity(Client client, short[] cells)
        {
            foreach (var actor in _clients)
            {
                if(actor.Character.Id != client.Character.Id)
                    actor.Send(new GameMapMovementMessage(cells, client.Character.Id));
            }
        }
        #endregion

        #region Triggers
        public bool IsCellFreeItem(int cellId) => Template.Cells[cellId].Mov && !Template.Cells[cellId].FarmCell && !Items.ContainsKey((uint)cellId);
        public bool Trigger(Client client, uint cellId)
        {
            
            if (Items.ContainsKey(cellId))
            {
                var item = Items[cellId];
                var stack = client.Character.Items.FirstOrDefault(x => x.EffectsS == item.EffectsS && x.Gid == item.Gid && x.Position == CharacterInventoryPositionEnum.INVENTORY_POSITION_NOT_EQUIPED);
                if (stack is null)
                {
                    item.Id = 0;
                    item.CharacterId = client.Character.Id;
                    ItemsManager.Instance.Save(item);
                    client.Send(new ObjectAddedMessage(item.ObjectItem));
                }
                else
                {
                    stack.Quantity += item.Quantity;
                    ItemsManager.Instance.Save(stack);
                    client.Send(new ObjectModifiedMessage(stack.ObjectItem));
                }
                Items.Remove(cellId);
                client.Send(new InventoryWeightMessage(client.Character.Pods, client.Character.MaxPod));
                client.Send(new CharacterStatsListMessage(client.Character.CharacterCharacteristicsInformations));
                Send(new ObjectGroundRemovedMessage(cellId));
            }

            var trigger = Triggers.FirstOrDefault(x => x.CellId == cellId);
            if(trigger == null)
                return false;

            switch (trigger.Type)
            {
                case Enums.TriggerMapEnum.TP:
                    var nMap = MapsManager.Instance.Get(trigger.param1);
                    if (nMap == null)
                    {
                        client.Send(new ChatAdminServerMessage((sbyte)ChatChannelsMultiEnum.CHANNEL_GLOBAL, "Impossible de trouver la prochaine map.", DateTime.Now.DateTimeToUnixTimestampSeconds(), "", 0, "[Server]", 0));
                        return false;
                    }
                    else
                    {
                        client.Character.CellId = trigger.param2;
                        client.Character.MapId = nMap.Template.Id;
                        client.Character.Save();
                        client.Character.Map.Exit(client);
                        nMap.Enter(client);
                    }
                    return true;
                case Enums.TriggerMapEnum.ChangeMap:

                default:
                    break;
            }

            return true;
        }
        #endregion

        #region Events
        public void AddSmileyEvent(Client client)
        {
            if (_smileyEvent is null)
                _smileyEvent = new SmileyEvent(client);
            else
                client.Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 0, new string[]
                {
                    $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#e74c3c").ToArgb():X}\">Event déjà en cours.</font>"
                }));
        }
        public void Execute(Client client, uint smileyId)
        {
            if(_smileyEvent?.Execute(client, smileyId) ?? false)
                _smileyEvent = null;
        }
        #endregion
    }
}
