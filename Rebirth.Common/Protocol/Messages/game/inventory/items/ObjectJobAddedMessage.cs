


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ObjectJobAddedMessage : NetworkMessage
{

public const uint Id = 7894;
public uint MessageId
{
    get { return Id; }
}

public sbyte jobId;
        

public ObjectJobAddedMessage()
{
}

public ObjectJobAddedMessage(sbyte jobId)
        {
            this.jobId = jobId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(jobId);
            

}

public void Deserialize(IDataReader reader)
{

jobId = reader.ReadSbyte();
            

}


}


}