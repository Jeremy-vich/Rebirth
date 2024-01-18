


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildVersatileInfoListMessage : NetworkMessage
{

public const uint Id = 3841;
public uint MessageId
{
    get { return Id; }
}

public Types.GuildVersatileInformations[] guilds;
        

public GuildVersatileInfoListMessage()
{
}

public GuildVersatileInfoListMessage(Types.GuildVersatileInformations[] guilds)
        {
            this.guilds = guilds;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)guilds.Length);
            foreach (var entry in guilds)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            guilds = new Types.GuildVersatileInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 guilds[i] = ProtocolTypeManager.GetInstance<Types.GuildVersatileInformations>(reader.ReadUShort());
                 guilds[i].Deserialize(reader);
            }
            

}


}


}