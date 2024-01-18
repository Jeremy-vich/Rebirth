


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class FriendInformations : AbstractContactInformations
{

public const short Id = 5744;
public override short TypeId
{
    get { return Id; }
}

public sbyte playerState;
        public uint lastConnection;
        public int achievementPoints;
        public int leagueId;
        public int ladderPosition;
        

public FriendInformations()
{
}

public FriendInformations(int accountId, Types.AccountTagInformation accountTag, sbyte playerState, uint lastConnection, int achievementPoints, int leagueId, int ladderPosition)
         : base(accountId, accountTag)
        {
            this.playerState = playerState;
            this.lastConnection = lastConnection;
            this.achievementPoints = achievementPoints;
            this.leagueId = leagueId;
            this.ladderPosition = ladderPosition;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(playerState);
            writer.WriteVarShort((int)lastConnection);
            writer.WriteInt(achievementPoints);
            writer.WriteVarShort((int)leagueId);
            writer.WriteInt(ladderPosition);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            playerState = reader.ReadSbyte();
            lastConnection = reader.ReadVarUhShort();
            achievementPoints = reader.ReadInt();
            leagueId = reader.ReadVarShort();
            ladderPosition = reader.ReadInt();
            

}


}


}