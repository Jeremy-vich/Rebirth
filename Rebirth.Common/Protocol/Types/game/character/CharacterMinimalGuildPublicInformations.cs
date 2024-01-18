


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class CharacterMinimalGuildPublicInformations : CharacterMinimalInformations
{

public const short Id = 9695;
public override short TypeId
{
    get { return Id; }
}

public Types.GuildRankPublicInformation rank;
        

public CharacterMinimalGuildPublicInformations()
{
}

public CharacterMinimalGuildPublicInformations(double id, string name, uint level, Types.GuildRankPublicInformation rank)
         : base(id, name, level)
        {
            this.rank = rank;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            rank.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            rank = new Types.GuildRankPublicInformation();
            rank.Deserialize(reader);
            

}


}


}