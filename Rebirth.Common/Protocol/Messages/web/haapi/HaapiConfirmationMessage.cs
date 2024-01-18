


















// Generated on 01/30/2023 13:09:29
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class HaapiConfirmationMessage : NetworkMessage
{

public const uint Id = 7027;
public uint MessageId
{
    get { return Id; }
}

public double kamas;
        public double amount;
        public uint rate;
        public sbyte action;
        public string transaction;
        

public HaapiConfirmationMessage()
{
}

public HaapiConfirmationMessage(double kamas, double amount, uint rate, sbyte action, string transaction)
        {
            this.kamas = kamas;
            this.amount = amount;
            this.rate = rate;
            this.action = action;
            this.transaction = transaction;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(kamas);
            writer.WriteVarLong(amount);
            writer.WriteVarShort((int)rate);
            writer.WriteSbyte(action);
            writer.WriteUTF(transaction);
            

}

public void Deserialize(IDataReader reader)
{

kamas = reader.ReadVarUhLong();
            amount = reader.ReadVarUhLong();
            rate = reader.ReadVarUhShort();
            action = reader.ReadSbyte();
            transaction = reader.ReadUTF();
            

}


}


}