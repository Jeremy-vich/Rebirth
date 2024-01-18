


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GuildRankActivity : GuildLogbookEntryBasicInformation
{

public const short Id = 3613;
public override short TypeId
{
    get { return Id; }
}

public sbyte rankActivityType;
        public Types.GuildRankMinimalInformation guildRankMinimalInfos;
        

public GuildRankActivity()
{
}

public GuildRankActivity(uint id, double date, sbyte rankActivityType, Types.GuildRankMinimalInformation guildRankMinimalInfos)
         : base(id, date)
        {
            this.rankActivityType = rankActivityType;
            this.guildRankMinimalInfos = guildRankMinimalInfos;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(rankActivityType);
            guildRankMinimalInfos.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            rankActivityType = reader.ReadSbyte();
            guildRankMinimalInfos = new Types.GuildRankMinimalInformation();
            guildRankMinimalInfos.Deserialize(reader);
            

}


}


}