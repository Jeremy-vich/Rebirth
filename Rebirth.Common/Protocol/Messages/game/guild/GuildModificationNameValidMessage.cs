


















// Generated on 01/30/2023 13:09:21
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildModificationNameValidMessage : NetworkMessage
{

public const uint Id = 3560;
public uint MessageId
{
    get { return Id; }
}

public string guildName;
        

public GuildModificationNameValidMessage()
{
}

public GuildModificationNameValidMessage(string guildName)
        {
            this.guildName = guildName;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(guildName);
            

}

public void Deserialize(IDataReader reader)
{

guildName = reader.ReadUTF();
            

}


}


}