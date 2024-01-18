


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class UpdateGuildRankRequestMessage : NetworkMessage
{

public const uint Id = 7592;
public uint MessageId
{
    get { return Id; }
}

public Types.GuildRankInformation rank;
        

public UpdateGuildRankRequestMessage()
{
}

public UpdateGuildRankRequestMessage(Types.GuildRankInformation rank)
        {
            this.rank = rank;
        }
        

public void Serialize(IDataWriter writer)
{

rank.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

rank = new Types.GuildRankInformation();
            rank.Deserialize(reader);
            

}


}


}