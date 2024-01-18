


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildUpdateApplicationMessage : NetworkMessage
{

public const uint Id = 7375;
public uint MessageId
{
    get { return Id; }
}

public string applyText;
        public uint guildId;
        

public GuildUpdateApplicationMessage()
{
}

public GuildUpdateApplicationMessage(string applyText, uint guildId)
        {
            this.applyText = applyText;
            this.guildId = guildId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(applyText);
            writer.WriteVarInt((int)guildId);
            

}

public void Deserialize(IDataReader reader)
{

applyText = reader.ReadUTF();
            guildId = reader.ReadVarUhInt();
            

}


}


}