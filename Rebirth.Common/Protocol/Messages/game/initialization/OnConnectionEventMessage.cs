


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class OnConnectionEventMessage : NetworkMessage
{

public const uint Id = 1917;
public uint MessageId
{
    get { return Id; }
}

public sbyte eventType;
        

public OnConnectionEventMessage()
{
}

public OnConnectionEventMessage(sbyte eventType)
        {
            this.eventType = eventType;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(eventType);
            

}

public void Deserialize(IDataReader reader)
{

eventType = reader.ReadSbyte();
            

}


}


}