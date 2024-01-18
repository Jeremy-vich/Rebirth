


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ChallengeTargetsListMessage : NetworkMessage
{

public const uint Id = 1950;
public uint MessageId
{
    get { return Id; }
}

public double[] targetIds;
        public short[] targetCells;
        

public ChallengeTargetsListMessage()
{
}

public ChallengeTargetsListMessage(double[] targetIds, short[] targetCells)
        {
            this.targetIds = targetIds;
            this.targetCells = targetCells;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)targetIds.Length);
            foreach (var entry in targetIds)
            {
                 writer.WriteDouble(entry);
            }
            writer.WriteShort((short)targetCells.Length);
            foreach (var entry in targetCells)
            {
                 writer.WriteShort(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            targetIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 targetIds[i] = reader.ReadDouble();
            }
            limit = (ushort)reader.ReadUShort();
            targetCells = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 targetCells[i] = reader.ReadShort();
            }
            

}


}


}