using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Command.Custom
{
    [CommandAttribute(new[] { "monsterdel" }, "Supprime un monstre de la liste.", CharacterRoleEnum.Moderator, false)]
    internal class RemoveMonster : InGameCommand
    {
        public RemoveMonster()
        {
            AddParameter(new Parameter("Id", true));
        }

        public override void Execute()
        {
            string id = GetParameter<string>("Id");
            var template = Author.Character.Map.MonstersMap;
            if (string.IsNullOrEmpty(id))
                template.Datas = "";
            else
                template.Datas = template.Datas.Replace($"{id};", "");
            Starter.DatabaseWorld.Save(template);
            Author.Character.Map.UpdateMonsters();
        }
    }
}
