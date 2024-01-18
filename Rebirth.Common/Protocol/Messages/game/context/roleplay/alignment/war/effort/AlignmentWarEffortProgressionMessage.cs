


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AlignmentWarEffortProgressionMessage : NetworkMessage
{

public const uint Id = 1983;
public uint MessageId
{
    get { return Id; }
}

public Types.AlignmentWarEffortInformation[] effortProgressions;
        

public AlignmentWarEffortProgressionMessage()
{
}

public AlignmentWarEffortProgressionMessage(Types.AlignmentWarEffortInformation[] effortProgressions)
        {
            this.effortProgressions = effortProgressions;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)effortProgressions.Length);
            foreach (var entry in effortProgressions)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            effortProgressions = new Types.AlignmentWarEffortInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 effortProgressions[i] = new Types.AlignmentWarEffortInformation();
                 effortProgressions[i].Deserialize(reader);
            }
            

}


}


}