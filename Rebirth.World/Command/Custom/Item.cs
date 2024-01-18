using Rebirth.Common.GameData.D2O;
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
    [CommandAttribute(new[] { "item" }, "Add Item à un joueur.", CharacterRoleEnum.Moderator, true)]
    public class Item : InGameCommand
    {
        public Item()
        {
            AddParameter(new Parameter("Gid", false));
            AddParameter(new Parameter("Amount", false));
            AddParameter(new Parameter("Max", false));
            AddParameter(new Parameter("Target", true));
        }

        public override void Execute()
        {
            int gid = GetParameter<int>("Gid");
            int Amount = GetParameter<int>("Amount");
            bool Max = GetParameter<bool>("Max");
            string targetName = GetParameter<string>("Target");

            if (targetName != null)
            {
                Target = ClientsManager.Instance.Get(targetName);
                if (Target == null && targetName.First() == '$')
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
                        var acc = AccountManager.Instance.Get(Character.AccountId);
                        if (acc != null)
                        {
                            for (int i = 0; i < Amount; i++)
                                Character.AddItem(gid, 1, Max);
                        }
                        else
                            Author.Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 0, new string[]
                            {
                                $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#e74c3c").ToArgb():X}\">Le joueur <b><font color=\"#{System.Drawing.ColorTranslator.FromHtml("#e74c3c").ToArgb():X}\">{targetName}</font></b> n'est relié à aucun compte.</font>"
                            }));
                        return;
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

            for (int i = 0; i < Amount; i++)
            {
                var datas = Target.Character.AddItem(gid, 1, Max);
                if(datas.Item1)
                    Target.Send(new ObjectAddedMessage(datas.Item2.ObjectItem));
                else
                    Target.Send(new ObjectModifiedMessage(datas.Item2.ObjectItem));
            }
            Target.Send(new InventoryWeightMessage(Target.Character.Pods, Target.Character.MaxPod));
        }
    }
}
