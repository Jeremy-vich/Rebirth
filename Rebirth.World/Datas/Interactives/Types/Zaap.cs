using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Protocol.Types;
using Rebirth.World.Datas.Interactives.Dialogs;
using Rebirth.World.Frames;
using Rebirth.World.Managers;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rebirth.World.Datas.Interactives.Types
{
    public abstract class Zaap : AbstractInteractive
    {
        public abstract uint[] ActionId
        {
            get;
        }

        public abstract uint CellId
        {
            get;
            set;
        }
        public bool IsOnMap
        {
            get;
            set;
        }
        public abstract int Identifier
        {
            get;
            set;
        }

        public abstract int Type
        {
            get;
        }

        public abstract InteractiveElement GetInteractiveElement(Client client);

        public void Use(Client client, uint skill)
        {
            if (ActionId.Contains(skill))
            {
                var dialog = new ZaapDialog(client, this);
                dialog.Open();
                client.Send(new InteractiveUsedMessage((uint)client.Character.Id, (uint)Identifier, ActionId[0], 0, false));
                Waypoint[] wp = InteractivesManager.Instance.GetAllWaypointExcept(client.Character.MapId);
                client.Send(new ZaapListMessage(0, (from x in wp
                                                              select (int)x.mapId).ToArray(), (from x in wp
                                                                                               select x.subAreaId).ToArray(), new uint[wp.Count()], new sbyte[wp.Count()], 503316480));
            }
        }
    }
}
