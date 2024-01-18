using Rebirth.Auth.Frames;
using Rebirth.Auth.Models;
using Rebirth.Common.Extensions;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.Auth.Managers
{
    public class IdentificationManager : DataManager<IdentificationManager>
    {
        public Account? Get(string username) => Starter.Database.SingleOrDefault<Account>("WHERE LOWER(Username) = @0", username.ToLower());

        public Account? Get(string login, string password)
        {
            var acc = Starter.Database.SingleOrDefault<Account>("WHERE Login = @0 AND Password = @1", login, password);
            if (acc == null)
            {
                var accTest = Starter.Database.Exists<Account>("WHERE Login = @0", login);
                if (!accTest)
                {
                    var newAcc = new Account()
                    {
                        Login = login,
                        Password = password,
                        SecretQuestion = "Quel est votre Login ?",
                        SecretAnswer = login,
                        CreationDate = DateTime.Now.DateTimeToUnixTimestamp(),
                        SubscriptionEndDate = DateTime.Now.AddYears(7).DateTimeToUnixTimestamp(),
                        IsAdmin = false
                    };
                    Starter.Database.Save(newAcc);
                    
                    return newAcc;
                }
                else 
                    return null;
            }
            return acc;
        }

        public bool Exist(string nickname) => Starter.Database.Exists<Account>("WHERE LOWER(Username) = @0", nickname.ToLower());

        public void Enter(Client client, AuthenticationTicketMessage msg)
        {
            //var creds = msg.credentials.Split('|');
            //var acc = Get(creds[0], creds[1]);
            //if (acc == null)
            //{
            //    client.Send(new IdentificationFailedMessage((sbyte)IdentificationFailureReasonEnum.WRONG_CREDENTIALS));
            //    return;
            //}

            //client.Account = acc;

            //var ban = client.IsBan();
            //if (ban > 0)
            //{
            //    client.Send(new IdentificationFailedBannedMessage((sbyte)IdentificationFailureReasonEnum.BANNED, ban));
            //    client.Disconnect();
            //    return;
            //}

            //if (string.IsNullOrEmpty(acc.Username))
            //{
            //    client.Send(new NicknameRegistrationMessage());
            //}
            //else
            //{
            //    client.Send(new IdentificationSuccessMessage(acc.IsAdmin, false, acc.Login, acc.Username, acc.Id, 0, acc.SecretQuestion, acc.CreationDate, acc.SubscriptionEndDate - DateTime.Now.DateTimeToUnixTimestamp(), acc.SubscriptionEndDate, 0));

            //    client.RemoveFrame(typeof(IdentificationFrame));

            //    ServersManager.Instance.Send(client);
            //}
        }
    }
}
