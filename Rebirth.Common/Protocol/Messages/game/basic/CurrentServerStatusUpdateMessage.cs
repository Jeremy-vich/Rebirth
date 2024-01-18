


















// Generated on 01/30/2023 13:09:09
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class CurrentServerStatusUpdateMessage : NetworkMessage
{

public const uint Id = 8239;
public uint MessageId
{
    get { return Id; }
}

public sbyte status;
        

public CurrentServerStatusUpdateMessage()
{
}

public CurrentServerStatusUpdateMessage(sbyte status)
        {
            this.status = status;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(status);
            

}

public void Deserialize(IDataReader reader)
{

status = reader.ReadSbyte();
            

}


}


}