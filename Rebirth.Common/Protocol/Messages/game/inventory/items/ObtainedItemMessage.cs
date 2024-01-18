


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ObtainedItemMessage : NetworkMessage
{

public const uint Id = 9033;
public uint MessageId
{
    get { return Id; }
}

public uint genericId;
        public uint baseQuantity;
        

public ObtainedItemMessage()
{
}

public ObtainedItemMessage(uint genericId, uint baseQuantity)
        {
            this.genericId = genericId;
            this.baseQuantity = baseQuantity;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)genericId);
            writer.WriteVarInt((int)baseQuantity);
            

}

public void Deserialize(IDataReader reader)
{

genericId = reader.ReadVarUhInt();
            baseQuantity = reader.ReadVarUhInt();
            

}


}


}