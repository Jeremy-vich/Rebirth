using Rebirth.Common.Dispatcher;
using Rebirth.Common.Extensions;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.World.Managers;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Frames
{
    public class ChatFrame
    {
        [MessageHandler(ChatClientPrivateMessage.Id)]
        private void HandleChatClientPrivateMessage(Client client, ChatClientPrivateMessage msg)
        {
            var d = client.IsMute();
            if (d > 0)
            {
                client.Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 0, new string[]
                {
                    $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#e74c3c").ToArgb():X}\">Vous ne pouvez pas parler suite à un mute.\nCette restriction sera levée le <b><font color=\"#{System.Drawing.ColorTranslator.FromHtml("#f1c40f").ToArgb():X}\">{d.UnixTimestampToDateTime().ToString("G")}</font></b></font>"
                }));
                return;
            }

            var dest = ClientsManager.Instance.Get(msg.receiver);
            if(dest is null)
            {
                // TODO : Envoyer le bon message
                return;
            }

            client.Send(new ChatServerCopyMessage((sbyte)ChatActivableChannelsEnum.PSEUDO_CHANNEL_PRIVATE, msg.content, System.DateTime.Now.DateTimeToUnixTimestampSeconds(), "", (uint)dest.Character.Id, dest.Character.Name));
            dest.Send(new ChatServerMessage((sbyte)ChatActivableChannelsEnum.PSEUDO_CHANNEL_PRIVATE, msg.content, DateTime.Now.DateTimeToUnixTimestampSeconds(), "", client.Character.Id, client.Character.Name, client.Character.AccountId));
        }

        [MessageHandler(ChatClientMultiMessage.Id)]
        private void HandleChatAbstractClientMessage(Client client, ChatClientMultiMessage msg)
        {
            var d = client.IsMute();
            if (d > 0)
            {
                client.Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 0, new string[]
                {
                    $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#e74c3c").ToArgb():X}\">Vous ne pouvez pas parler suite à un mute.\nCette restriction sera levée le <b><font color=\"#{System.Drawing.ColorTranslator.FromHtml("#f1c40f").ToArgb():X}\">{d.UnixTimestampToDateTime().ToString("G")}</font></b></font>"
                }));
                return;
            }
            switch ((ChatChannelsMultiEnum)msg.channel)
            {
                case ChatChannelsMultiEnum.CHANNEL_GLOBAL:
                    client.Character.Map.Send(new ChatServerMessage(msg.channel, msg.content, DateTime.Now.DateTimeToUnixTimestampSeconds(), "", client.Character.Id, client.Character.Name, client.Account.Id));
                    break;
                case ChatChannelsMultiEnum.CHANNEL_TEAM:
                    break;
                case ChatChannelsMultiEnum.CHANNEL_GUILD:
                    if(client.IsJail() > 0)
                    {
                        client.Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 0, new string[]
                        {
                            $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#f1c40f").ToArgb():X}\">En prison on ne communique pas avec l'extérieur.</font>"
                        }));
                        return;
                    }
                    break;
                case ChatChannelsMultiEnum.CHANNEL_ALLIANCE:
                    if (client.IsJail() > 0)
                    {
                        client.Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 0, new string[]
                        {
                            $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#f1c40f").ToArgb():X}\">En prison on ne communique pas avec l'extérieur.</font>"
                        }));
                        return;
                    }
                    break;
                case ChatChannelsMultiEnum.CHANNEL_PARTY:
                    if (client.IsJail() > 0)
                    {
                        client.Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 0, new string[]
                        {
                            $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#f1c40f").ToArgb():X}\">En prison on ne communique pas avec l'extérieur.</font>"
                        }));
                        return;
                    }
                    break;
                case ChatChannelsMultiEnum.CHANNEL_SALES:
                    if (client.IsJail() > 0)
                    {
                        client.Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 0, new string[]
                        {
                            $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#f1c40f").ToArgb():X}\">En prison on ne communique pas avec l'extérieur.</font>"
                        }));
                        return;
                    }
                    break;
                case ChatChannelsMultiEnum.CHANNEL_SEEK:
                    if (client.IsJail() > 0)
                    {
                        client.Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 0, new string[]
                        {
                            $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#f1c40f").ToArgb():X}\">En prison on ne communique pas avec l'extérieur.</font>"
                        }));
                        return;
                    }
                    break;
                case ChatChannelsMultiEnum.CHANNEL_NOOB:
                    if (client.IsJail() > 0)
                    {
                        client.Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 0, new string[]
                        {
                            $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#f1c40f").ToArgb():X}\">En prison on ne communique pas avec l'extérieur.</font>"
                        }));
                        return;
                    }
                    break;
                case ChatChannelsMultiEnum.CHANNEL_ADMIN:
                    break;
                case ChatChannelsMultiEnum.CHANNEL_ADS:
                    if (client.IsJail() > 0)
                    {
                        client.Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 0, new string[]
                        {
                            $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#f1c40f").ToArgb():X}\">En prison on ne communique pas avec l'extérieur.</font>"
                        }));
                        return;
                    }
                    break;
                case ChatChannelsMultiEnum.CHANNEL_ARENA:
                    if (client.IsJail() > 0)
                    {
                        client.Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 0, new string[]
                        {
                            $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#f1c40f").ToArgb():X}\">En prison on ne communique pas avec l'extérieur.</font>"
                        }));
                        return;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
