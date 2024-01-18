


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class JobCrafterDirectoryRemoveMessage : NetworkMessage
{

public const uint Id = 8883;
public uint MessageId
{
    get { return Id; }
}

public sbyte jobId;
        public double playerId;
        

public JobCrafterDirectoryRemoveMessage()
{
}

public JobCrafterDirectoryRemoveMessage(sbyte jobId, double playerId)
        {
            this.jobId = jobId;
            this.playerId = playerId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(jobId);
            writer.WriteVarLong(playerId);
            

}

public void Deserialize(IDataReader reader)
{

jobId = reader.ReadSbyte();
            playerId = reader.ReadVarUhLong();
            

}


}


}