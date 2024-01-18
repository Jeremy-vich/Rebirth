using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Command.Custom
{
    [CommandAttribute(new[] { "monsteradd" }, "Ajoute un monstre de la liste.", CharacterRoleEnum.Moderator, true)]
    internal class AddMonster : InGameCommand
    {
        public AddMonster()
        {
            AddParameter(new Parameter("Id", false));
        }

        public override void Execute()
        {
            string id = GetParameter<string>("Id");
            var template = Author.Character.Map?.MonstersMap;
            if (!string.IsNullOrEmpty(id) && template is not null)
            {
                template.Datas += $"{id};";
                Starter.DatabaseWorld.Save(template);
                Author.Character.Map?.UpdateMonsters();
            }
        }
    }
}
