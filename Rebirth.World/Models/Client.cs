using Rebirth.Common.Extensions;
using Rebirth.Common.IStructures;
using Rebirth.Common.Network;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.World.Datas;
using Rebirth.World.Frames;
using Rebirth.World.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Models
{
    public class Client : IClient
    {
        public Account Account { get; set; }
        public Character Character { get; set; }
        public IActivity? Activity { get; set; } = null;
        public Party? Party { get; set; } = null;
        public Client(Socket sock) : base(sock)
        {
            AddFrame(typeof(ApproachFrame));
            AddFrame(typeof(BasicFrame));
            Send(new HelloGameMessage());
        }

        public override void Disconnect()
        {
            base.Disconnect();
            ClientsManager.Instance.Remove(this);
        }

        public void Teleport(int mapId, int cellId)
        {
            Character.Map.Exit(this);
            Character.MapId = mapId;
            Character.CellId = cellId;
            Character.Map.Enter(this);
            CharacterManager.Instance.Save(Character);
        }

        public virtual double IsMute()
        {
            if (DateTime.Now.Ticks < Account.UnMuteDate.Ticks)
                return Account.UnMuteDate.DateTimeToUnixTimestamp();
            return 0;
        }

        public void Jail()
        {
            if (!JailManager.Instance.IsInJail(Character.MapId))
            {
                var jailMap = JailManager.Instance.GetMap();
                Teleport(jailMap.Item1, jailMap.Item2);
            }
            Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 0, new string[]
            {
                $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#e74c3c").ToArgb():X}\">Bienvenue en prison.\nVotre libération est prévue pour le : <b><font color=\"#{System.Drawing.ColorTranslator.FromHtml("#f1c40f").ToArgb():X}\">{IsJail().UnixTimestampToDateTime():G}</font></b></font>"
            }));
        }

        public void UnJail()
        {
            Teleport(84674563, 315);
            Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 0, new string[]
            {
                $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#e74c3c").ToArgb():X}\">Vous êtes maintenant libre, profitez de votre liberté sans faire de vague.</font>"
            }));
        }

        public virtual double IsJail()
        {
            if (DateTime.Now.Ticks < Account.UnJail?.Ticks)
                return Account.UnJail.DateTimeToUnixTimestamp();
            return 0;
        }
    }
}
