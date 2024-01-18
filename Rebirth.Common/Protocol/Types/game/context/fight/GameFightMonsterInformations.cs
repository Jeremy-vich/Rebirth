


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameFightMonsterInformations : GameFightAIInformations
{

public const short Id = 5931;
public override short TypeId
{
    get { return Id; }
}

public uint creatureGenericId;
        public sbyte creatureGrade;
        public short creatureLevel;
        

public GameFightMonsterInformations()
{
}

public GameFightMonsterInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, Types.GameContextBasicSpawnInformation spawnInfo, sbyte wave, Types.GameFightCharacteristics stats, uint[] previousPositions, uint creatureGenericId, sbyte creatureGrade, short creatureLevel)
         : base(contextualId, disposition, look, spawnInfo, wave, stats, previousPositions)
        {
            this.creatureGenericId = creatureGenericId;
            this.creatureGrade = creatureGrade;
            this.creatureLevel = creatureLevel;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)creatureGenericId);
            writer.WriteSbyte(creatureGrade);
            writer.WriteShort(creatureLevel);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            creatureGenericId = reader.ReadVarUhShort();
            creatureGrade = reader.ReadSbyte();
            creatureLevel = reader.ReadShort();
            

}


}


}