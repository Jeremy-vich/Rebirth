


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameFightEntityInformation : GameFightFighterInformations
{

public const short Id = 2308;
public override short TypeId
{
    get { return Id; }
}

public sbyte entityModelId;
        public uint level;
        public double masterId;
        

public GameFightEntityInformation()
{
}

public GameFightEntityInformation(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, Types.GameContextBasicSpawnInformation spawnInfo, sbyte wave, Types.GameFightCharacteristics stats, uint[] previousPositions, sbyte entityModelId, uint level, double masterId)
         : base(contextualId, disposition, look, spawnInfo, wave, stats, previousPositions)
        {
            this.entityModelId = entityModelId;
            this.level = level;
            this.masterId = masterId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(entityModelId);
            writer.WriteVarShort((int)level);
            writer.WriteDouble(masterId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            entityModelId = reader.ReadSbyte();
            level = reader.ReadVarUhShort();
            masterId = reader.ReadDouble();
            

}


}


}