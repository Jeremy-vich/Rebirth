


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayArenaLeagueRewardsMessage : NetworkMessage
{

public const uint Id = 1870;
public uint MessageId
{
    get { return Id; }
}

public uint seasonId;
        public uint leagueId;
        public int ladderPosition;
        public bool endSeasonReward;
        

public GameRolePlayArenaLeagueRewardsMessage()
{
}

public GameRolePlayArenaLeagueRewardsMessage(uint seasonId, uint leagueId, int ladderPosition, bool endSeasonReward)
        {
            this.seasonId = seasonId;
            this.leagueId = leagueId;
            this.ladderPosition = ladderPosition;
            this.endSeasonReward = endSeasonReward;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)seasonId);
            writer.WriteVarShort((int)leagueId);
            writer.WriteInt(ladderPosition);
            writer.WriteBoolean(endSeasonReward);
            

}

public void Deserialize(IDataReader reader)
{

seasonId = reader.ReadVarUhShort();
            leagueId = reader.ReadVarUhShort();
            ladderPosition = reader.ReadInt();
            endSeasonReward = reader.ReadBoolean();
            

}


}


}