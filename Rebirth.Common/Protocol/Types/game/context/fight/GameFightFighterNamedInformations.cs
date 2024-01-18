


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameFightFighterNamedInformations : GameFightFighterInformations
{

public const short Id = 6988;
public override short TypeId
{
    get { return Id; }
}

public string name;
        public Types.PlayerStatus status;
        public int leagueId;
        public int ladderPosition;
        public bool hiddenInPrefight;
        

public GameFightFighterNamedInformations()
{
}

public GameFightFighterNamedInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, Types.GameContextBasicSpawnInformation spawnInfo, sbyte wave, Types.GameFightCharacteristics stats, uint[] previousPositions, string name, Types.PlayerStatus status, int leagueId, int ladderPosition, bool hiddenInPrefight)
         : base(contextualId, disposition, look, spawnInfo, wave, stats, previousPositions)
        {
            this.name = name;
            this.status = status;
            this.leagueId = leagueId;
            this.ladderPosition = ladderPosition;
            this.hiddenInPrefight = hiddenInPrefight;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            status.Serialize(writer);
            writer.WriteVarShort((int)leagueId);
            writer.WriteInt(ladderPosition);
            writer.WriteBoolean(hiddenInPrefight);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            status = new Types.PlayerStatus();
            status.Deserialize(reader);
            leagueId = reader.ReadVarShort();
            ladderPosition = reader.ReadInt();
            hiddenInPrefight = reader.ReadBoolean();
            

}


}


}