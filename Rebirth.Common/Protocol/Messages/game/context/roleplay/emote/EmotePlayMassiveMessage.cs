


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class EmotePlayMassiveMessage : EmotePlayAbstractMessage
{

public const uint Id = 77;
public uint MessageId
{
    get { return Id; }
}

public double[] actorIds;
        

public EmotePlayMassiveMessage()
{
}

public EmotePlayMassiveMessage(ushort emoteId, double emoteStartTime, double[] actorIds)
         : base(emoteId, emoteStartTime)
        {
            this.actorIds = actorIds;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)actorIds.Length);
            foreach (var entry in actorIds)
            {
                 writer.WriteDouble(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            actorIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 actorIds[i] = reader.ReadDouble();
            }
            

}


}


}