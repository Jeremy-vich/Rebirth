using Rebirth.Auth.Frames;
using Rebirth.Auth.Managers;
using Rebirth.Common.Extensions;
using Rebirth.Common.Network;
using Rebirth.Common.Protocol.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.Auth.Models
{
    public class Client : IClient
    {
        public Account Account { get; set; }
        public sbyte[] Key { get; set; } = new sbyte[32];
        public string Salt { get; set; } = new Random().RandomString(32);

        public Client(Socket sock) : base(sock)
        {
            AddFrame(typeof(BasicFrame));
            AddFrame(typeof(IdentificationFrame));

            Send(new ProtocolRequired("1.0.3+6dde4e8"));
            Send(new HelloConnectMessage(Salt, Key));
        }

        public override void Disconnect()
        {
            base.Disconnect();
            ClientsManager.Instance.Remove(this);
        }

        public virtual double IsBan()
        {
            if (Account == null)
            {
                var ip = Starter.Database.SingleOrDefault<IpBan>("WHERE Ip = @0", IP);
                if (ip != null && DateTime.Now.Ticks < ip.BanEndDate.Ticks)
                    return ip.BanEndDate.DateTimeToUnixTimestamp();
            }
            else
                if (DateTime.Now.Ticks < Account.BanEndDate.Ticks)
                    return Account.BanEndDate.DateTimeToUnixTimestamp();
            return 0;
        }
    }
}
