using Rebirth.Common.Dispatcher;
using Rebirth.Common.IStructures;
using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Protocol.Messages;
using Rebirth.World.Datas.Interactives.Dialogs;
using Rebirth.World.Datas.Interactives.Types.Classic;
using Rebirth.World.Datas.Interactives.Types;
using Rebirth.World.Datas;
using Rebirth.World.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rebirth.World.Models;

namespace Rebirth.World.Frames
{
    public class InteractiveFrame
    {
        [MessageHandler(InteractiveUseRequestMessage.Id)]
        private void HandleInteractiveUseRequestMessage(Client client, InteractiveUseRequestMessage message)
        {
            AbstractInteractive interact = client.Character.Map.GetInterctive((int)message.elemId);
            if (interact != null)
            {
                if (new MapPoint((short)client.Character.CellId).IsAdjacentTo(new MapPoint((short)interact.CellId), true))
                {
                    interact.Use(client, message.skillInstanceUid);
                }
            }
        }

        [MessageHandler(TeleportRequestMessage.Id)]
        private void HandleTeleportRequestMessage(Client client, TeleportRequestMessage message)
        {
            if (client.Activity != null && client.Activity is ZaapDialog)
            {
                Waypoint wp = InteractivesManager.Instance.GetWaypointByMap(message.mapId);
                if (wp != null)
                {
                    Map newMap = MapsManager.Instance.Get((int)wp.mapId);
                    InteractiveZaap newZaap = newMap.GetZaap() as InteractiveZaap;
                    if (newZaap != null)
                    {
                        uint cellId = (uint)(new MapPoint((short)newZaap.CellId).GetNearestCellInDirection(Common.Protocol.Enums.DirectionsEnum.DIRECTION_SOUTH_EAST).CellId);
                        if (!newMap.IsCellFree((short)cellId))
                        {
                            cellId = (uint)(new MapPoint((short)newZaap.CellId).GetNearestCellInDirection(Common.Protocol.Enums.DirectionsEnum.DIRECTION_SOUTH_WEST).CellId);
                        }
                        client.Activity.Close();
                        client.Teleport((int)wp.mapId, (short)cellId);
                    }
                }
            }
        }

        [MessageHandler(ZaapRespawnSaveRequestMessage.Id)]
        private void HandleZaapRespawnSaveRequestMessage(Client client, ZaapRespawnSaveRequestMessage message)
        {
            IActivity interact = client.Activity;
            if (interact is ZaapDialog)
            {
                if (new MapPoint((short)client.Character.CellId).IsAdjacentTo(new MapPoint((short)(interact as ZaapDialog).Zaap.CellId), true))
                {
                    var waypoint = InteractivesManager.Instance.GetWaypointByMap(client.Character.MapId);
                    if (waypoint != null)
                    {
                        client.Character.ZaapSave = (int)waypoint.mapId;
                        client.Send(new ZaapRespawnUpdatedMessage((int)waypoint.mapId));
                    }
                }
            }
        }
        [MessageHandler(LeaveDialogRequestMessage.Id)]
        private void HandleLeaveDialogRequestMessage(Client client, LeaveDialogRequestMessage msg)
        {
            client.Activity?.Close();
        }
    }
}
