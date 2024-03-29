﻿using Rebirth.Common.Protocol.Enums;
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
    public class InteractivePaddock : AbstractInteractive
    {
        public int Type { get; }
        public uint[] ActionId { get; }
        public int MapId
        {
            get;
            set;
        }

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
        public InteractivePaddock(int Identifier, uint CellId, int Type, uint[] ActionId, int MapId, bool isOnMap)
        {
            this.Identifier = Identifier;
            this.CellId = CellId;
            this.Type = Type;
            this.ActionId = ActionId;
            this.MapId = MapId;
            IsOnMap = IsOnMap;
        }

        public InteractiveElement GetInteractiveElement(Client client)
        {
            return new InteractiveElement(Identifier, Type, (from x in ActionId
                                                             select new InteractiveElementSkill(x, (int)x)).ToArray(), new InteractiveElementSkill[0], true);
        }

        public void Use(Client client, uint skill)
        {
            if (ActionId.Contains(skill))
            {
                Map map = MapsManager.Instance.Get(MapId);
                if (map != null)
                {
                    map.Send(new InteractiveUsedMessage((uint)client.Character.Id, (uint)Identifier, ActionId[0], 0, false));
                    client.Send(new PaddockPropertiesMessage(new PaddockInstancesInformations(10, 10, new List<PaddockBuyableInformations>())));
                    client.Send(new ExchangeStartOkMountWithOutPaddockMessage(new MountClientData[0]));
                }
                var dialog = new PaddockDialog(client, (int)skill);
                dialog.Open();
            }
        }
    }
}
