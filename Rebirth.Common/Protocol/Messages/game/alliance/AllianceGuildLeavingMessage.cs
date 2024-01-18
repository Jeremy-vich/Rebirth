


















// Generated on 01/30/2023 13:09:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AllianceGuildLeavingMessage : NetworkMessage
{

public const uint Id = 1732;
public uint MessageId
{
    get { return Id; }
}

public bool kicked;
        public uint guildId;
        

public AllianceGuildLeavingMessage()
{
}

public AllianceGuildLeavingMessage(bool kicked, uint guildId)
        {
            this.kicked = kicked;
            this.guildId = guildId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(kicked);
            writer.WriteVarInt((int)guildId);
            

}

public void Deserialize(IDataReader reader)
{

kicked = reader.ReadBoolean();
            guildId = reader.ReadVarUhInt();
            

}


}


}