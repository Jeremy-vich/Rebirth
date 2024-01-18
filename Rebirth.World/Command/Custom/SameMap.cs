using Rebirth.Common.GameData.D2O;
using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Command.Custom
{
    [CommandAttribute(new[] { "samemap" }, "Liste les maps dans la même subarea et sur la même position.", CharacterRoleEnum.Moderator, true)]
    internal class SameMap : InGameCommand
    {
        public SameMap()
        {
        }

        public override void Execute()
        {
            var maps = ObjectDataManager.GetAll<MapPosition>().FindAll(x => x.posX == Author.Character.Map.Position.posX && x.posY == Author.Character.Map.Position.posY);
            var text = "";
            foreach (var map in maps)
            {
                if(map.id == Author.Character.Map.Template.Id)
                    text += $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#f1c40f").ToArgb():X}\">\n    <b>{map.id} | {map.subAreaId}</b></font>";
                else
                    text += $"\n    {map.id} | {map.subAreaId}";
            }
            Author.Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 0, new string[]
            {
                $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#d35400").ToArgb():X}\">Liste des maps : <b>{text}</b></font>"
            }));
        }
    }
}
