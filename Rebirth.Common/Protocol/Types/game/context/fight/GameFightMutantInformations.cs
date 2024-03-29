


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameFightMutantInformations : GameFightFighterNamedInformations
{

public const short Id = 5030;
public override short TypeId
{
    get { return Id; }
}

public sbyte powerLevel;
        

public GameFightMutantInformations()
{
}

public GameFightMutantInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, Types.GameContextBasicSpawnInformation spawnInfo, sbyte wave, Types.GameFightCharacteristics stats, uint[] previousPositions, string name, Types.PlayerStatus status, int leagueId, int ladderPosition, bool hiddenInPrefight, sbyte powerLevel)
         : base(contextualId, disposition, look, spawnInfo, wave, stats, previousPositions, name, status, leagueId, ladderPosition, hiddenInPrefight)
        {
            this.powerLevel = powerLevel;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(powerLevel);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            powerLevel = reader.ReadSbyte();
            

}


}


}