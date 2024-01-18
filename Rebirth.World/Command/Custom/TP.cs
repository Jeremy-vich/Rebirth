using Rebirth.Common.GameData.D2O;
using Rebirth.Common.GameData.Maps;
using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.World.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Command.Custom
{
    [CommandAttribute(new[] { "tp" }, "Téléporte sur la map donnée.", CharacterRoleEnum.Moderator, true)]
    internal class TP : InGameCommand
    {
        public TP()
        {
            AddParameter(new Parameter("MapId", false));
            AddParameter(new Parameter("CellId", true));
        }

        public override void Execute()
        {
            int mapid = GetParameter<int>("MapId");
            int cellid = GetParameter<int>("CellId");
            var map  = Managers.MapsManager.Instance.Get(mapid);
            if(map is not null )
            {
                Author.Teleport(mapid, cellid > 0 ? cellid :(int)map.GetRandomCell());
            }
        }
    }
}
