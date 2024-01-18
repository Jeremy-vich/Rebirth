using Rebirth.Common.IStructures;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Interactives.Dialogs
{
    public class PaddockDialog : IActivity
    {
        public DialogTypeEnum DialogType
        {
            get
            {
                return DialogTypeEnum.DIALOG_EXCHANGE;
            }
        }

        public Client Client
        {
            get;
            private set;
        }
        public virtual void Open()
        {
            //Client.State = PlayerState.In_Paddock_Panel;
            Client.Activity = this;
        }

        public PaddockDialog(Client client, int skillId)
        {
            Client = client;
        }

        public void Close()
        {
            //this.Character.State = PlayerState.Available;
            Client.Activity = null;
            Client.Send(new ExchangeLeaveMessage((sbyte)DialogType, true));
        }
    }
}
