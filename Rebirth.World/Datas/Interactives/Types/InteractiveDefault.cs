using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Protocol.Types;
using Rebirth.World.Datas.Interactives.Dialogs;
using Rebirth.World.Managers;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rebirth.World.Datas.Interactives.Types
{
    public class InteractiveDefault : AbstractInteractive
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
        public InteractiveDefault(int Identifier, uint cellId, bool onMap)
        {
            this.Identifier = Identifier;
            this.CellId = cellId;
            IsOnMap = onMap;
        }

        public InteractiveElement GetInteractiveElement(Client client)
        {
            return new InteractiveElement(Identifier, Type, (from x in ActionId
                                                             select new InteractiveElementSkill(x, 0)).ToArray(), new InteractiveElementSkill[0], IsOnMap);
        }

        public void Use(Client client, uint skill)
        {
            if (client.Account.IsAdmin)
                client.Send(new ChatServerMessage((sbyte)ChatActivableChannelsEnum.PSEUDO_CHANNEL_INFO, "Interactive = " + Identifier, 0, "", 0, "Server", 0));
            client.Send(new InteractiveUseErrorMessage((uint)Identifier, ActionId[0]));
        }
    }
}
