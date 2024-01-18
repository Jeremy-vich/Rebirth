﻿using Rebirth.Common.Protocol.Enums;
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
    [CommandAttribute(new[] { "jail" }, "Mets en prison un joueur.", CharacterRoleEnum.Moderator, true)]
    internal class Jail : InGameCommand
    {
        public Jail()
        {
            AddParameter(new Parameter("Temps", false));
            AddParameter(new Parameter("Target", false));
        }

        public override void Execute()
        {
            double time = GetParameter<int>("Temps");
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
                            Target.Account.UnJail = DateTime.Now.AddMinutes(time);
                            AccountManager.Instance.Save(Target.Account);
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
            if (time == 0)
            {
                Target.Account.UnJail = null;
                Target.UnJail();
            }
            else
            {
                Target.Account.UnJail = DateTime.Now.AddMinutes(time);
                Target.Jail();
            }

            AccountManager.Instance.Save(Target.Account);
            

        }
    }
}
