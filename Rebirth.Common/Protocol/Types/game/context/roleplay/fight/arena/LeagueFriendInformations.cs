


















// Generated on 01/30/2023 13:09:33
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class LeagueFriendInformations : AbstractContactInformations
{

public const short Id = 8986;
public override short TypeId
{
    get { return Id; }
}

public double playerId;
        public string playerName;
        public sbyte breed;
        public bool sex;
        public uint level;
        public int leagueId;
        public int totalLeaguePoints;
        public int ladderPosition;
        

public LeagueFriendInformations()
{
}

public LeagueFriendInformations(int accountId, Types.AccountTagInformation accountTag, double playerId, string playerName, sbyte breed, bool sex, uint level, int leagueId, int totalLeaguePoints, int ladderPosition)
         : base(accountId, accountTag)
        {
            this.playerId = playerId;
            this.playerName = playerName;
            this.breed = breed;
            this.sex = sex;
            this.level = level;
            this.leagueId = leagueId;
            this.totalLeaguePoints = totalLeaguePoints;
            this.ladderPosition = ladderPosition;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(playerId);
            writer.WriteUTF(playerName);
            writer.WriteSbyte(breed);
            writer.WriteBoolean(sex);
            writer.WriteVarShort((int)level);
            writer.WriteVarShort((int)leagueId);
            writer.WriteVarShort((int)totalLeaguePoints);
            writer.WriteInt(ladderPosition);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
            playerName = reader.ReadUTF();
            breed = reader.ReadSbyte();
            sex = reader.ReadBoolean();
            level = reader.ReadVarUhShort();
            leagueId = reader.ReadVarShort();
            totalLeaguePoints = reader.ReadVarShort();
            ladderPosition = reader.ReadInt();
            

}


}


}