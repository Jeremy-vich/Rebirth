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
    [CommandAttribute(new[] { "update" }, "Mets à jours la liste des interactives objects sur la map.", CharacterRoleEnum.Moderator, true)]
    internal class UpdateInteractive : InGameCommand
    {
        public UpdateInteractive()
        {
        }

        public override void Execute()
        {
            Author.Character.Map.UpdateInteractives();
        }
    }
}
