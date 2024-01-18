


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ContactLookErrorMessage : NetworkMessage
{

public const uint Id = 9005;
public uint MessageId
{
    get { return Id; }
}

public uint requestId;
        

public ContactLookErrorMessage()
{
}

public ContactLookErrorMessage(uint requestId)
        {
            this.requestId = requestId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)requestId);
            

}

public void Deserialize(IDataReader reader)
{

requestId = reader.ReadVarUhInt();
            

}


}


}