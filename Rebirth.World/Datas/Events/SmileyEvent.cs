using Rebirth.Common.Extensions;
using Rebirth.Common.GameData.D2O;
using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.World.Managers;
using Rebirth.World.Models;
using System.Timers;

namespace Rebirth.World.Datas.Events
{
    public class SmileyEvent
    {
        private uint _smiley = 0;
        private System.Timers.Timer _timer = new System.Timers.Timer(20000);
        private System.Timers.Timer _timerStart = new System.Timers.Timer(10000);
        private Client _modo;

        public SmileyEvent(Client client) {
            _modo = client;
            var smileys = ObjectDataManager.GetAll<Smiley>();
            _smiley = smileys[new Random().Next(1, smileys.Count)].id;
            _timer.Elapsed += Send;
            _timer.Start();
            ClientsManager.Instance.Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 0, new string[]
            {
                    $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#8e44ad").ToArgb():X}\">Lancement d'un event smiley sur la map [{_modo.Character.Map?.Position.posX}/{_modo.Character.Map?.Position.posY}] dans 30 secondes.\nVous pouvez taper <b>.event</b> pour accèder automatiquement à la map.</font>"
            }));
        }

        private void Send(object sender, ElapsedEventArgs args)
        {
            _timer.Stop();
            _modo.Character.Map?.Send(new ChatServerMessage((sbyte)ChatChannelsMultiEnum.CHANNEL_GLOBAL, $"Regardez bien au dessus de ma tête. Lancement dans 10s", DateTime.Now.DateTimeToUnixTimestampSeconds(), "", _modo.Character.Id, _modo.Character.Name, _modo.Account.Id));
            _timerStart.Elapsed += Start;
            _timerStart.Start();
        }

        public void Start(object sender, ElapsedEventArgs args)
        {
            _timerStart.Stop();
            _modo.Character.Map?.Send(new ChatSmileyMessage(_modo.Character.Id, _smiley, _modo.Account.Id));
        }

        public bool Execute(Client client, uint smileyId)
        {
            if(smileyId == _smiley)
            {
                ClientsManager.Instance.Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 0, new string[]
                {
                    $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#2980b9").ToArgb():X}\">Félicitation à <b>{client.Character.Name}</b> qui remporte 500 kamas</font>"
                }));
                client.Character.Kamas += 500;
                CharacterManager.Instance.Save(client.Character);
                client.Send(new KamasUpdateMessage(client.Character.Kamas));
                return true;
            }
            return false;
        }
    }
}
