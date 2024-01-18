using Rebirth.Common.IStructures;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Interactives.Dialogs
{
    public class BookDialog : IActivity
    {
        public DialogTypeEnum DialogType
        {
            get
            {
                return DialogTypeEnum.DIALOG_BOOK;
            }
        }
        public Client Client
        {
            get;
            private set;
        }

        public uint BookId
        {
            get;
            private set;
        }

        public BookDialog(Client client, uint BookId)
        {
            Client = client;
            this.BookId = BookId;
            Open();
        }
        public virtual void Open()
        {
            //Client.State = PlayerState.Available;
            Client.Activity = this;
            Client.Send(new DocumentReadingBeginMessage(BookId));

        }
        public virtual void Close()
        {
            //Client.State = PlayerState.Available;
            Client.Send(new LeaveDialogMessage((sbyte)this.DialogType));
            Client.Activity = null;
        }
    }
}
