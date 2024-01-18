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
    public class ZaapiDialog : IActivity
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
            //Client.State = PlayerState.In_Zaapi_Panel;
            Client.Activity = this;
        }

        public Zaapi Zaap
        {
            get;
            private set;
        }

        public ZaapiDialog(Client character, Zaapi zaap)
        {
            this.Client = character;
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
