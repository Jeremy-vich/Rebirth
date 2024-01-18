using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.World.Managers;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Command.Custom
{
    [CommandAttribute(new[] { "event" }, "Lance un event automatique.", CharacterRoleEnum.Moderator, true)]
    internal class Event : InGameCommand
    {
        public Event()
        {
            AddParameter(new Parameter("Type", false));        }

        public override void Execute()
        {
            string type = GetParameter<string>("Type");
            switch (type)
            {
                case "smiley":
                    Author.Character.Map?.AddSmileyEvent(Author);
                    break;
                default:
                    break;
            }
        }
    }
}
