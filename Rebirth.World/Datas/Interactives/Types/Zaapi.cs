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
    public abstract class Zaapi : AbstractInteractive
    {
        public abstract uint[] ActionId
        {
            get;
        }

        public uint CellId
        {
            get;
            set;
        }

        public int SubArea
        {
            get;
            set;
        }

        public int MapId
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
                var dialog = new ZaapiDialog(client, this);
                dialog.Open();
                client.Send(new InteractiveUsedMessage((uint)client.Character.Id, (uint)Identifier, ActionId[0], 0, false));
                List<Zaapi> wp = new(); //MapsManager.Instance.GetZaapiBySub(SubArea);
                client.Send(new TeleportDestinationsListMessage(1, (from x in wp
                                                                              select x.MapId).ToArray(), (from x in wp
                                                                                                               select (uint)x.SubArea).ToArray(), new uint[wp.Count()], new sbyte[0]));
            }
        }
    }
}
