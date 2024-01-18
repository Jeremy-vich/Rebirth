using Rebirth.Common.GameData.D2O;
using Rebirth.Common.Protocol.Data;
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
    [CommandAttribute(new[] { "moveto" }, "Teleporte un joueur sur la map.", CharacterRoleEnum.Moderator, true)]
    public class MoveTo : InGameCommand
    {
        public MoveTo()
        {
            AddParameter(new Parameter("MapId", false));
            AddParameter(new Parameter("Target", true));
        }

        public override void Execute()
        {
            int compressed = GetParameter<int>("MapId");
            string targetName = GetParameter<string>("Target");

            if(targetName != null)
            {
                Target = ClientsManager.Instance.Get(targetName);
                if(Target == null && targetName.First() == '$')
                {
                    Character = CharacterManager.Instance.Get(targetName.Substring(1));
                    if (Character == null)
                    {
                        Author.Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 0, new string[]
                        {
                        $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#e74c3c").ToArgb():X}\">Impossible de trouver le joueur <b><font color=\"#{System.Drawing.ColorTranslator.FromHtml("#e74c3c").ToArgb():X}\">{targetName.Substring(1)}</font></b> même hors ligne.</font>"
                        }));
                        return;
                    }
                    else
                    {
                        var mapC = MapsManager.Instance.Get(compressed);
                        if (mapC == null)
                            return;
                        var mapsC = ObjectDataManager.GetAll<MapPosition>().FindAll(z => z.posX == mapC.Position.posX && z.posY == mapC.Position.posY);
                        var indexOfC = mapsC.FindIndex(x => x.id == Author.Character.MapId) + 1;
                        var nPosC = mapsC[indexOfC >= mapsC.Count ? 0 : indexOfC];
                        var nMapC = MapsManager.Instance.Get(nPosC.id);

                        if (nMapC == null)
                        {
                            Character.MapId = mapC.Template.Id;
                            Character.CellId = Author.Character.Map.Template.Cells.First(x => x.Mov).Id;
                            CharacterManager.Instance.Save(Character);
                        }
                        else
                        {
                            Character.MapId = nMapC.Template.Id;
                            Character.CellId = Author.Character.Map.Template.Cells.First(x => x.Mov).Id;
                            CharacterManager.Instance.Save(Character);
                        }
                    }
                }
                else if (Target == null)
                {
                    Author.Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 0, new string[]
                    {
                    $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#e74c3c").ToArgb():X}\">Impossible de trouver le joueur <b><font color=\"#{System.Drawing.ColorTranslator.FromHtml("#e74c3c").ToArgb():X}\">{targetName}</font></b>.\nVous pouvez ajouter le caractère <b>$</b> avant le nom pour éxécuter la commande même si le joueur est déconnecté.</font>"
                    }));
                    return;
                }
            }

            var map = MapsManager.Instance.Get(compressed);
            if (map == null)
                return;
            var maps = ObjectDataManager.GetAll<MapPosition>().FindAll(z => z.posX == map.Position.posX && z.posY == map.Position.posY);
            var indexOf = maps.FindIndex(x => x.id == Author.Character.MapId) + 1;
            var nPos = maps[indexOf >= maps.Count ? 0 : indexOf];
            var nMap = MapsManager.Instance.Get(nPos.id);

            if (nMap == null)
            {
                Target.Character.Map.Exit(Target);
                Target.Character.MapId = map.Template.Id;
                Target.Character.CellId = Target.Character.Map.Template.Cells.First(x => x.Mov).Id;
                Target.Character.Map.Enter(Target);
            }
            else
            {
                Target.Character.Map.Exit(Target);
                Target.Character.MapId = nMap.Template.Id;
                Target.Character.CellId = Target.Character.Map.Template.Cells.First(x => x.Mov).Id;
                Target.Character.Map.Enter(Target);
            }
        }
    }
}
