


















// Generated on 01/30/2023 13:09:21
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildListMessage : NetworkMessage
{

public const uint Id = 4090;
public uint MessageId
{
    get { return Id; }
}

public Types.GuildInformations[] guilds;
        

public GuildListMessage()
{
}

public GuildListMessage(Types.GuildInformations[] guilds)
        {
            this.guilds = guilds;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)guilds.Length);
            foreach (var entry in guilds)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            guilds = new Types.GuildInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 guilds[i] = new Types.GuildInformations();
                 guilds[i].Deserialize(reader);
            }
            

}


}


}