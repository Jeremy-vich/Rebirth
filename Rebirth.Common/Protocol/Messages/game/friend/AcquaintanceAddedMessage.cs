


















// Generated on 01/30/2023 13:09:20
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AcquaintanceAddedMessage : NetworkMessage
{

public const uint Id = 8361;
public uint MessageId
{
    get { return Id; }
}

public Types.AcquaintanceInformation acquaintanceAdded;
        

public AcquaintanceAddedMessage()
{
}

public AcquaintanceAddedMessage(Types.AcquaintanceInformation acquaintanceAdded)
        {
            this.acquaintanceAdded = acquaintanceAdded;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(acquaintanceAdded.TypeId);
            acquaintanceAdded.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

acquaintanceAdded = ProtocolTypeManager.GetInstance<Types.AcquaintanceInformation>(reader.ReadUShort());
            acquaintanceAdded.Deserialize(reader);
            

}


}


}