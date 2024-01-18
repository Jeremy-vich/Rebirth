


















// Generated on 01/30/2023 13:09:09
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BasicLatencyStatsMessage : NetworkMessage
{

public const uint Id = 8383;
public uint MessageId
{
    get { return Id; }
}

public ushort latency;
        public uint sampleCount;
        public uint max;
        

public BasicLatencyStatsMessage()
{
}

public BasicLatencyStatsMessage(ushort latency, uint sampleCount, uint max)
        {
            this.latency = latency;
            this.sampleCount = sampleCount;
            this.max = max;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort(latency);
            writer.WriteVarShort((int)sampleCount);
            writer.WriteVarShort((int)max);
            

}

public void Deserialize(IDataReader reader)
{

latency = reader.ReadUShort();
            sampleCount = reader.ReadVarUhShort();
            max = reader.ReadVarUhShort();
            

}


}


}