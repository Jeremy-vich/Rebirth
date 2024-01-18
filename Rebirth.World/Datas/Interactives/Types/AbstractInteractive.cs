using Rebirth.Common.Protocol.Types;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Interactives.Types
{
    public interface AbstractInteractive
    {
        int Type { get; }
        uint CellId { get; set; }
        uint[] ActionId { get; }
        int Identifier { get; set; }
        bool IsOnMap { get; set; }
        InteractiveElement GetInteractiveElement(Client client);
        void Use(Client client, uint actionId);
    }
}
