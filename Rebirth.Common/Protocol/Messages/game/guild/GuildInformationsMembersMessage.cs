


















// Generated on 01/30/2023 13:09:21
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildInformationsMembersMessage : NetworkMessage
{

public const uint Id = 1109;
public uint MessageId
{
    get { return Id; }
}

public Types.GuildMember[] members;
        

public GuildInformationsMembersMessage()
{
}

public GuildInformationsMembersMessage(Types.GuildMember[] members)
        {
            this.members = members;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)members.Length);
            foreach (var entry in members)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            members = new Types.GuildMember[limit];
            for (int i = 0; i < limit; i++)
            {
                 members[i] = new Types.GuildMember();
                 members[i].Deserialize(reader);
            }
            

}


}


}