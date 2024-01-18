


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class UpdateSelfAgressableStatusMessage : NetworkMessage
{

public const uint Id = 9898;
public uint MessageId
{
    get { return Id; }
}

public sbyte status;
        public int probationTime;
        

public UpdateSelfAgressableStatusMessage()
{
}

public UpdateSelfAgressableStatusMessage(sbyte status, int probationTime)
        {
            this.status = status;
            this.probationTime = probationTime;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(status);
            writer.WriteInt(probationTime);
            

}

public void Deserialize(IDataReader reader)
{

status = reader.ReadSbyte();
            probationTime = reader.ReadInt();
            

}


}


}