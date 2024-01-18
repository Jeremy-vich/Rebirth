


















// Generated on 01/30/2023 13:09:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AllianceChangeGuildRightsMessage : NetworkMessage
{

public const uint Id = 1555;
public uint MessageId
{
    get { return Id; }
}

public uint guildId;
        public sbyte rights;
        

public AllianceChangeGuildRightsMessage()
{
}

public AllianceChangeGuildRightsMessage(uint guildId, sbyte rights)
        {
            this.guildId = guildId;
            this.rights = rights;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)guildId);
            writer.WriteSbyte(rights);
            

}

public void Deserialize(IDataReader reader)
{

guildId = reader.ReadVarUhInt();
            rights = reader.ReadSbyte();
            

}


}


}