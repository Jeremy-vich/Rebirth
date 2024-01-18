


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class SpawnCompanionInformation : SpawnInformation
{

public const short Id = 2297;
public override short TypeId
{
    get { return Id; }
}

public sbyte modelId;
        public uint level;
        public double summonerId;
        public double ownerId;
        

public SpawnCompanionInformation()
{
}

public SpawnCompanionInformation(sbyte modelId, uint level, double summonerId, double ownerId)
        {
            this.modelId = modelId;
            this.level = level;
            this.summonerId = summonerId;
            this.ownerId = ownerId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(modelId);
            writer.WriteVarShort((int)level);
            writer.WriteDouble(summonerId);
            writer.WriteDouble(ownerId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            modelId = reader.ReadSbyte();
            level = reader.ReadVarUhShort();
            summonerId = reader.ReadDouble();
            ownerId = reader.ReadDouble();
            

}


}


}