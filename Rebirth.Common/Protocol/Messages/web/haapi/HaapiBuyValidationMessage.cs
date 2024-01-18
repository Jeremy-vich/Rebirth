


















// Generated on 01/30/2023 13:09:29
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class HaapiBuyValidationMessage : HaapiValidationMessage
{

public const uint Id = 9166;
public uint MessageId
{
    get { return Id; }
}

public double amount;
        public string email;
        

public HaapiBuyValidationMessage()
{
}

public HaapiBuyValidationMessage(sbyte action, sbyte code, double amount, string email)
         : base(action, code)
        {
            this.amount = amount;
            this.email = email;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(amount);
            writer.WriteUTF(email);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            amount = reader.ReadVarUhLong();
            email = reader.ReadUTF();
            

}


}


}