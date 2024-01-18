


















// Generated on 01/30/2023 13:09:33
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ArenaRankInfos
{

public const short Id = 9362;
public virtual short TypeId
{
    get { return Id; }
}

public Types.ArenaRanking ranking;
        public Types.ArenaLeagueRanking leagueRanking;
        public uint victoryCount;
        public uint fightcount;
        public short numFightNeededForLadder;
        

public ArenaRankInfos()
{
}

public ArenaRankInfos(Types.ArenaRanking ranking, Types.ArenaLeagueRanking leagueRanking, uint victoryCount, uint fightcount, short numFightNeededForLadder)
        {
            this.ranking = ranking;
            this.leagueRanking = leagueRanking;
            this.victoryCount = victoryCount;
            this.fightcount = fightcount;
            this.numFightNeededForLadder = numFightNeededForLadder;
        }
        

public virtual void Serialize(IDataWriter writer)
{

ranking.Serialize(writer);
            leagueRanking.Serialize(writer);
            writer.WriteVarShort((int)victoryCount);
            writer.WriteVarShort((int)fightcount);
            writer.WriteShort(numFightNeededForLadder);
            

}

public virtual void Deserialize(IDataReader reader)
{

ranking = new Types.ArenaRanking();
            ranking.Deserialize(reader);
            leagueRanking = new Types.ArenaLeagueRanking();
            leagueRanking.Deserialize(reader);
            victoryCount = reader.ReadVarUhShort();
            fightcount = reader.ReadVarUhShort();
            numFightNeededForLadder = reader.ReadShort();
            

}


}


}