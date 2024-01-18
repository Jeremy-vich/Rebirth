


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildRanksMessage : NetworkMessage
{

public const uint Id = 1814;
public uint MessageId
{
    get { return Id; }
}

public Types.GuildRankInformation[] ranks;
        

public GuildRanksMessage()
{
}

public GuildRanksMessage(Types.GuildRankInformation[] ranks)
        {
            this.ranks = ranks;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)ranks.Length);
            foreach (var entry in ranks)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            ranks = new Types.GuildRankInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 ranks[i] = new Types.GuildRankInformation();
                 ranks[i].Deserialize(reader);
            }
            

}


}


}