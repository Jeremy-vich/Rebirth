


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ObjectUseMultipleMessage : ObjectUseMessage
{

public const uint Id = 4566;
public uint MessageId
{
    get { return Id; }
}

public uint quantity;
        

public ObjectUseMultipleMessage()
{
}

public ObjectUseMultipleMessage(uint objectUID, uint quantity)
         : base(objectUID)
        {
            this.quantity = quantity;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)quantity);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            quantity = reader.ReadVarUhInt();
            

}


}


}