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
using System.Threading.Tasks;

namespace Rebirth.World.Datas.Interactives.Types
{
    public class InteractiveBook : AbstractInteractive
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
        public int BookId
        {
            get;
            set;
        }
        public InteractiveBook(int Identifier, uint cellId, bool onMap, int bookId)
        {
            this.Identifier = Identifier;
            this.CellId = cellId;
            IsOnMap = onMap;
            BookId = bookId;
        }

        public InteractiveElement GetInteractiveElement(Client client)
        {
            return new InteractiveElement(Identifier, Type, (from x in ActionId
                                                             select new InteractiveElementSkill(x, 0)).ToArray(), new InteractiveElementSkill[0], IsOnMap);
        }

        public void Use(Client client, uint skill)
        {
            client.Activity = new BookDialog(client, (uint)BookId);
            client.Send(new InteractiveUsedMessage((uint)client.Character.Id, (uint)Identifier, ActionId[0], 0, false));
        }
    }
}
