


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameFightMonsterWithAlignmentInformations : GameFightMonsterInformations
{

public const short Id = 5161;
public override short TypeId
{
    get { return Id; }
}

public Types.ActorAlignmentInformations alignmentInfos;
        

public GameFightMonsterWithAlignmentInformations()
{
}

public GameFightMonsterWithAlignmentInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, Types.GameContextBasicSpawnInformation spawnInfo, sbyte wave, Types.GameFightCharacteristics stats, uint[] previousPositions, uint creatureGenericId, sbyte creatureGrade, short creatureLevel, Types.ActorAlignmentInformations alignmentInfos)
         : base(contextualId, disposition, look, spawnInfo, wave, stats, previousPositions, creatureGenericId, creatureGrade, creatureLevel)
        {
            this.alignmentInfos = alignmentInfos;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            alignmentInfos.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            alignmentInfos = new Types.ActorAlignmentInformations();
            alignmentInfos.Deserialize(reader);
            

}


}


}