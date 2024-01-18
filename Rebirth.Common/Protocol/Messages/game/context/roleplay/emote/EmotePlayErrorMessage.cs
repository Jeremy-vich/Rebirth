


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class EmotePlayErrorMessage : NetworkMessage
{

public const uint Id = 5335;
public uint MessageId
{
    get { return Id; }
}

public ushort emoteId;
        

public EmotePlayErrorMessage()
{
}

public EmotePlayErrorMessage(ushort emoteId)
        {
            this.emoteId = emoteId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort(emoteId);
            

}

public void Deserialize(IDataReader reader)
{

emoteId = reader.ReadUShort();
            

}


}


}