


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildSummaryMessage : PaginationAnswerAbstractMessage
{

public const uint Id = 6194;
public uint MessageId
{
    get { return Id; }
}

public Types.GuildFactSheetInformations[] guilds;
        

public GuildSummaryMessage()
{
}

public GuildSummaryMessage(double offset, uint count, uint total, Types.GuildFactSheetInformations[] guilds)
         : base(offset, count, total)
        {
            this.guilds = guilds;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)guilds.Length);
            foreach (var entry in guilds)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            guilds = new Types.GuildFactSheetInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 guilds[i] = new Types.GuildFactSheetInformations();
                 guilds[i].Deserialize(reader);
            }
            

}


}


}