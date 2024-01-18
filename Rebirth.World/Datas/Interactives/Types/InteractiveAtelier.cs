using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Protocol.Types;
using Rebirth.World.Datas.Dialogs;
using Rebirth.World.Managers;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rebirth.World.Datas.Interactives.Types
{
    public class InteractiveAtelier : AbstractInteractive
    {
        public int Type { get; }
        public uint[] ActionId { get; }
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
        public int Identifier { get; set; }

        public uint CellId
        {
            get;
            set;
        }

        public InteractiveAtelier(int Identifier, uint CellId, int Type, uint[] ActionId, int MapId)
        {
            this.Identifier = Identifier;
            this.CellId = CellId;
            this.Type = Type;
            this.ActionId = ActionId;
            this.MapId = MapId;
        }

        public InteractiveElement GetInteractiveElement(Client client)
        {
            return new InteractiveElement(Identifier, Type, (from x in ActionId
                                                             select new InteractiveElementSkill(x, (int)x)).ToArray(), new InteractiveElementSkill[0], true);
        }

        public void Use(Client client, uint skill)
        {
            if (client.Character.Jobs.Any(z => z.Skills.Any(y => y.id == ActionId[0])))
            {
                Map? map = MapsManager.Instance.Get(MapId);
                if (map != null)
                {
                    map.Send(new InteractiveUsedMessage((uint)client.Character.Id, (uint)Identifier, skill, 0, false));
                }
                var dialog = new CraftDialog(client, skill);
                dialog.Open();
            }
            else
            {
                client.Send(new InteractiveUseErrorMessage((uint)Identifier, skill));
            }
        }
    }
}
