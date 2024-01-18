using Microsoft.VisualBasic;
using Rebirth.Common.Dispatcher;
using Rebirth.Common.Extensions;
using Rebirth.Common.GameData;
using Rebirth.Common.GameData.D2O;
using Rebirth.Common.GameData.Maps;
using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Protocol.Types;
using Rebirth.World.Datas;
using Rebirth.World.Enums;
using Rebirth.World.Managers;
using Rebirth.World.Models;
using Rebirth.World.Pathfinder;
using System.IO;
using Map = Rebirth.World.Models.Map;
using MapsManager = Rebirth.World.Managers.MapsManager;
using Point = Rebirth.Common.GameData.Point;

namespace Rebirth.World.Frames
{
    public class RolePlayFrame
    {
        [MessageHandler(MapInformationsRequestMessage.Id)]
        private void HandleMapInformationsRequestMessage(Client client, MapInformationsRequestMessage msg)
        {
            var map = client.Character.Map;
            client.Send(new MapComplementaryInformationsWithCoordsMessage(
                (uint)map.Template.SubAreaId, 
                map.Template.Id,
                Array.Empty<HouseInformations>(),
                client.Character.Map.GameRolePlayActorInformations, 
                client.Character.Map.GetInteractives(client), 
                client.Character.Map.GetStatedElements(),
                Array.Empty<MapObstacle>(),
                Array.Empty<FightCommonInformations>(),
                false,
                (short)map.Position.posX,
                (short)map.Position.posY,
                new FightStartingPositions(map.GetFightCells(FightPositionEnum.Red), map.GetFightCells(FightPositionEnum.Blue)
                )));

            if (map.Items.Count > 0)
                client.Send(new ObjectGroundListAddedMessage(map.Items.Keys.ToArray(), map.Items.Values.Select(x => (uint)x.Gid).ToArray()));

            client.Send(new BasicTimeMessage(System.DateTime.Now.DateTimeToUnixTimestamp(), 0));
        }

        [MessageHandler(GameMapMovementRequestMessage.Id)]
        private void HandleGameMapMovementRequestMessage(Client client, GameMapMovementRequestMessage msg)
        {
            // Il manque encore des vérification on les feras au fur est à mesure <3
            var map = client.Character.Map;
            if (map != null)
            {
                var path = new Pathfinder.Pathfinder();
                path.SetMap(map, true);
                path.GetPath((short)client.Character.CellId, (short)(msg.keyMovements.Last() & 4095));

                if (path.Cells != null)
                {
                    client.Character.StartMovement(path.Cells);
                    map.MoveEntity(client, path.GetCompressedPath());
                }
                else
                {
                    var point = new MapPoint((short)client.Character.CellId);
                    client.Send(new GameMapNoMovementMessage((short)point.X, (short)point.Y));
                }
            }
        }

        [MessageHandler(GameMapMovementCancelMessage.Id)]
        private void HandleGameMapMovementCancelMessage(Client client, GameMapMovementCancelMessage msg)
        {
            Console.WriteLine($"{msg.cellId} = {client.Character.StopMove()}");
        }

        [MessageHandler(GameMapChangeOrientationRequestMessage.Id)]
        private void HandleGameMapChangeOrientationRequestMessage(Client client, GameMapChangeOrientationRequestMessage msg)
        {
            if (msg.direction < 0 || msg.direction > 7)
                return;
            client.Character.Direction = (DirectionsEnum)msg.direction;
            client.Character.Save();
            client.Character.Map.Send(new GameMapChangeOrientationMessage(client.Character.ActorOrientation));
        }

        
        [MessageHandler(ChangeMapMessage.Id)]
        private void HandleChangeMapMessage(Client client, ChangeMapMessage msg)
        {
            //var test = msg.mapId; // 84674051
            //var scroll = ObjectDataManager.GetAll<MapScrollAction>().FirstOrDefault(x => x.id == client.Character.Map.Template.Id);

            var actualMap = client.Character.Map;
            var cell = actualMap.Template.Cells[client.Character.CellId];
            MapNeighbour mapNeighbour = 0;
            if (cell.IsBotChange)
            {
                mapNeighbour = MapNeighbour.Bottom;
                if (msg.mapId != client.Character.Map.Template.BottomNeighbourId)
                {
                    client.Send(new BasicNoOperationMessage());
                    return;
                }
            }
            else if (cell.IsTopChange)
            {
                mapNeighbour = MapNeighbour.Top;
                if (msg.mapId != client.Character.Map.Template.TopNeighbourId)
                {
                    client.Send(new BasicNoOperationMessage());
                    return;
                }
            }
            else if (cell.IsLeftChange)
            {
                mapNeighbour = MapNeighbour.Left;
                if (msg.mapId != client.Character.Map.Template.LeftNeighbourId)
                {
                    client.Send(new BasicNoOperationMessage());
                    return;
                }
            }
            else if (cell.IsRightChange)
            {
                mapNeighbour = MapNeighbour.Right;
                if(msg.mapId != client.Character.Map.Template.RightNeighbourId)
                {
                    client.Send(new BasicNoOperationMessage());
                    return;
                }
            }

            var nextCell = cell.GetCellAfterChangeMap(mapNeighbour);
            // TODO : si la cellule d'arriver est en Mov false alors trouver la plus proche avec Mov true
            client.Character.CellId = nextCell;

            var map = MapsManager.Instance.Get(msg.mapId);
            if (map == null)
                map = MapsManager.Instance.Get(actualMap, mapNeighbour);
            else if (map.Position.worldMap != actualMap.Position.worldMap)
                map = MapsManager.Instance.Get(actualMap, mapNeighbour);

            if(map == null)
            {
                client.Send(new ChatAdminServerMessage((sbyte)ChatChannelsMultiEnum.CHANNEL_GLOBAL, "Impossible de trouver la prochaine map.", DateTime.Now.DateTimeToUnixTimestampSeconds(), "", 0, "[Server]", 0));
                return;
            }

            var CellsWithMove = map.Template.Cells.FindAll(x => x.IsRightChange);

            if (client.Character.CellId == cell.Id)
                Console.WriteLine($"[World.ChangeMapMessage] CellAfterChangeMap is a same !");

            client.Character.MapId = map.Template.Id;
            client.Character.Save();
            client.Character.Map.Exit(client);
            map.Enter(client);
        }

        [MessageHandler(GameMapMovementConfirmMessage.Id)]
        private void HandleGameMapMovementConfirmMessage(Client client, GameMapMovementConfirmMessage msg)
        {
            if (!client.Character.MoveIsFinish)
            {
                client.Disconnect();
                return;
            }
            // Il manque encore des vérification on les feras au fur est à mesure <3
            client.Character.Save();
            client.Character.Map.Trigger(client, (uint)client.Character.CellId);
        }

        [MessageHandler(StatsUpgradeRequestMessage.Id)]
        private void HandleStatsUpgradeRequestMessage(Client client, StatsUpgradeRequestMessage msg)
        {
            if (msg.statId < 10 || msg.statId > 15 || msg.boostPoint <= 0)
            {
                client.Send(new StatsUpgradeResultMessage((sbyte)StatsUpgradeResultEnum.NONE, 0));
                return;
            }
            if(msg.boostPoint > client.Character.StatsPoints)
            {
                client.Send(new StatsUpgradeResultMessage((sbyte)StatsUpgradeResultEnum.NOT_ENOUGH_POINT, 0));
                return;
            }

            var nbr = client.Character.UpgradeStat(msg.statId, msg.boostPoint);
            if (nbr > 0)
            {
                client.Character.Save();
                client.Send(new StatsUpgradeResultMessage((sbyte)StatsUpgradeResultEnum.SUCCESS, nbr));
                client.Send(new CharacterStatsListMessage(client.Character.CharacterCharacteristicsInformations));
                client.Send(new InventoryWeightMessage(0, client.Character.MaxPod));
            } 
            else
            {
                client.Send(new StatsUpgradeResultMessage((sbyte)StatsUpgradeResultEnum.NONE, 0));
                return;
            }
        }

        [MessageHandler(SpellModifyRequestMessage.Id)]
        private void HandleSpellModifyRequestMessage(Client client, SpellModifyRequestMessage msg)
        {
            if(msg.spellLevel <= 0 || msg.spellId <= 0)
            {
                client.Send(new SpellModifyFailureMessage());
                return;
            }
            if(!client.Character.UpgradeSpell((int)msg.spellId, msg.spellLevel))
            {
                client.Send(new SpellModifyFailureMessage());
                return;
            }
            client.Send(new SpellModifySuccessMessage((int)msg.spellId, msg.spellLevel));
            client.Send(new CharacterStatsListMessage(client.Character.CharacterCharacteristicsInformations));
        }

        [MessageHandler(EmotePlayRequestMessage.Id)]
        private void HandleEmotePlayRequestMessage(Client client, EmotePlayRequestMessage msg)
        {
            if (client.Character.Emotes.Any(x => x.EmoteId == msg.emoteId))
            {
                client.Character.Map.Send(new EmotePlayMessage(msg.emoteId, DateTime.Now.DateTimeToUnixTimestamp(), client.Character.Id, client.Account.Id));
                return;
            }
            client.Send(new EmotePlayErrorMessage(msg.emoteId));
        }

        [MessageHandler(ChatSmileyRequestMessage.Id)]
        private void HandleChatSmileyRequestMessage(Client client, ChatSmileyRequestMessage msg)
        {
            client.Character.Map?.Send(new ChatSmileyMessage(client.Character.Id, msg.smileyId, client.Account.Id));
            client.Character.Map?.Execute(client, msg.smileyId);
        }
    }
}
