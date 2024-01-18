using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Protocol.Types;
using Rebirth.World.Datas.Interactives.Dialogs;
using Rebirth.World.Managers;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Datas.Interactives.Types
{
    internal class InteractiveTeleporter : AbstractInteractive
    {
        public int Type { get { return -1; } }
        public uint[] ActionId { get { return new uint[] { 184 }; } }

        public int Identifier { get; set; }

        public uint CellId
        {
            get;
            set;
        }
        public bool IsOnMap
        {
            get;
            set;
        }
        public int Destination
        {
            get;
            set;
        }
        public int DestCellId
        {
            get;
            set;
        }
        public InteractiveTeleporter(int Identifier, uint cellId, bool onMap, int destination, int destCell)
        {
            this.Identifier = Identifier;
            this.CellId = cellId;
            IsOnMap = onMap;
            Destination = destination;
            DestCellId = destCell;
        }

        public InteractiveElement GetInteractiveElement(Client client)
        {
            return new InteractiveElement(Identifier, Type, (from x in ActionId
                                                             select new InteractiveElementSkill(x, 0)).ToArray(), new InteractiveElementSkill[0], IsOnMap);
        }

        public void Use(Client client, uint skill)
        {
            client.Teleport(Destination, DestCellId);
            client.Send(new InteractiveUsedMessage((uint)client.Character.Id, (uint)Identifier, ActionId[0], 0, true));
        }
    }
}