using Rebirth.Common.IStructures;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.World.Datas.Interactives.Types;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Interactives.Dialogs
{
    public class ZaapDialog : IActivity
    {
        public DialogTypeEnum DialogType
        {
            get
            {
                return DialogTypeEnum.DIALOG_TELEPORTER;
            }
        }

        public Client Client
        {
            get;
            private set;
        }

        public virtual void Open()
        {
            //this.Character.State = PlayerState.In_Zaap_Panel;
            Client.Activity = this;
        }

        public Zaap Zaap
        {
            get;
            private set;
        }

        public ZaapDialog(Client client, Zaap zaap)
        {
            this.Client = client;
            this.Zaap = zaap;
        }

        public void Close()
        {
            //this.Character.State = PlayerState.Available;
            Client.Activity = null;
            Client.Send(new LeaveDialogMessage((sbyte)DialogType));
        }
    }
}
