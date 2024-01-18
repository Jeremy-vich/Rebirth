


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ObjectUseMessage : NetworkMessage
{

public const uint Id = 4717;
public uint MessageId
{
    get { return Id; }
}

public uint objectUID;
        

public ObjectUseMessage()
{
}

public ObjectUseMessage(uint objectUID)
        {
            this.objectUID = objectUID;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectUID);
            

}

public void Deserialize(IDataReader reader)
{

objectUID = reader.ReadVarUhInt();
            

}


}


}