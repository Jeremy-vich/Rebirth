


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class SymbioticObjectAssociatedMessage : NetworkMessage
{

public const uint Id = 287;
public uint MessageId
{
    get { return Id; }
}

public uint hostUID;
        

public SymbioticObjectAssociatedMessage()
{
}

public SymbioticObjectAssociatedMessage(uint hostUID)
        {
            this.hostUID = hostUID;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)hostUID);
            

}

public void Deserialize(IDataReader reader)
{

hostUID = reader.ReadVarUhInt();
            

}


}


}