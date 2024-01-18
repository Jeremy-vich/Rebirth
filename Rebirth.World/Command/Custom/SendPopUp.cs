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
    [CommandAttribute(new[] { "sendpopup" }, "Envoyer un popup à tout les joueurs connectés.", CharacterRoleEnum.Moderator, true)]
    internal class SendPopUp : InGameCommand
    {
        public SendPopUp()
        {
            AddParameter(new Parameter("duration", false));
            AddParameter(new Parameter("Target", true));
            AddParameter(new Parameter("msg", false));
        }

        public override void Execute()
        {
            byte time = GetParameter<byte>("duration");
            string msg = GetParameter<string>("msg");
            string targetName = GetParameter<string>("Target");

            if (string.IsNullOrEmpty(targetName))
            {
                ClientsManager.Instance.Send(new PopupWarningMessage(time, Author.Character.Name, msg));
                return;
            }

            var client = ClientsManager.Instance.Get(targetName);
            if(client is null)
                Author.Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 0, new string[]
                {
                        $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#e74c3c").ToArgb():X}\">Impossible de trouver le joueur <b><font color=\"#{System.Drawing.ColorTranslator.FromHtml("#e74c3c").ToArgb():X}\">{targetName.Substring(1)}</font></b>.</font>"
                }));
            else
                client.Send(new PopupWarningMessage(time, Author.Character.Name, msg));
        }
    }
}
