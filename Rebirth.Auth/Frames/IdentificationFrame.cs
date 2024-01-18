using Rebirth.Auth.Managers;
using Rebirth.Auth.Models;
using Rebirth.Common.Dispatcher;
using Rebirth.Common.Extensions;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rebirth.Auth.Frames
{
    public class IdentificationFrame
    {
        [MessageHandler(IdentificationMessage.Id)]
        private void HandleIdentificationMessage(Client client, IdentificationMessage msg)
        {
            //var ban = client.IsBan();
            //if(ban > 0)
            //{
            //    client.Send(new IdentificationFailedBannedMessage((sbyte)IdentificationFailureReasonEnum.BANNED, ban));
            //    client.Disconnect();
            //    return;
            //}
            //IdentificationManager.Instance.Enter(client, msg);
        }
        [MessageHandler(NicknameChoiceRequestMessage.Id)]
        private void HandleNicknameChoiceRequestMessage(Client client, NicknameChoiceRequestMessage msg)
        {
            if (msg.nickname.ToLower() == client.Account.Login.ToLower())
            {
                client.Send(new NicknameRefusedMessage((sbyte)NicknameErrorEnum.SAME_AS_LOGIN));
                return;
            }

            Regex RgxUrl = new Regex("[^a-zA-Z0-9]");
            if (RgxUrl.IsMatch(msg.nickname))
            {
                client.Send(new NicknameRefusedMessage((sbyte)NicknameErrorEnum.INVALID_NICK));
                return;
            }

            if (IdentificationManager.Instance.Exist(msg.nickname))
            {
                client.Send(new NicknameRefusedMessage((sbyte)NicknameErrorEnum.ALREADY_USED));
                return;
            }

            try
            {
                client.Account.Username = msg.nickname;
                Starter.Database.Save(client.Account);

                client.Send(new NicknameAcceptedMessage());

                client.Send(new IdentificationSuccessMessage(client.Account.IsAdmin, client.Account.IsAdmin, false, false, client.Account.Login, new Common.Protocol.Types.AccountTagInformation(client.Account.Username, "8534"), client.Account.Id, 0, client.Account.CreationDate, client.Account.SubscriptionEndDate, 0));

                client.RemoveFrame(typeof(IdentificationFrame));
                ServersManager.Instance.Send(client);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Auth.IdentificationFrame.NicknameChoiceRequestMessage] {ex.Message}");
                client.Send(new NicknameRefusedMessage((sbyte)NicknameErrorEnum.ALREADY_USED));
            }

        }
        
    }
}
