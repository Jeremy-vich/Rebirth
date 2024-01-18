using Rebirth.Common.GameData.D2I;
using Rebirth.Common.GameData.D2O;
using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Rebirth.World.Command.Custom
{
    [CommandAttribute(new[] { "infosmonsters" }, "Liste les monstres qui peuvent spawn sur la map.", CharacterRoleEnum.Moderator, true)]
    internal class ListeMonsters : InGameCommand
    {
        public ListeMonsters()
        {
        }

        public override void Execute()
        {
            var template = Author.Character.Map?.MonstersMap;
            if (template is null)
                return;
            var text = "";
            foreach (var item in template.Datas.Split(";"))
                if (!string.IsNullOrWhiteSpace(item))
                {
                    var monster = ObjectDataManager.Get<Monster>(uint.Parse(item));
                    text += $"\n        {I18nDataManager.Instance.GetText((int)monster.nameId)} - <b>{item}</b>";
                }
            Author.Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 0, new string[]
            {
                $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#d35400").ToArgb():X}\">Informations de la map :" +
                $"\n    Id: <b>{Author.Character.Map.Template.Id}</b>" +
                $"\n    SubArea: <b>{Author.Character.Map.Template.SubAreaId}</b>" +
                $"\n    Liste des monstres:{text}" +
                $"</font>"
            }));
        }
    }
}
