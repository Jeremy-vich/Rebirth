


















// Generated on 01/30/2023 13:09:21
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class CreateGuildRankRequestMessage : NetworkMessage
{

public const uint Id = 5961;
public uint MessageId
{
    get { return Id; }
}

public uint parentRankId;
        public uint gfxId;
        public string name;
        

public CreateGuildRankRequestMessage()
{
}

public CreateGuildRankRequestMessage(uint parentRankId, uint gfxId, string name)
        {
            this.parentRankId = parentRankId;
            this.gfxId = gfxId;
            this.name = name;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)parentRankId);
            writer.WriteVarInt((int)gfxId);
            writer.WriteUTF(name);
            

}

public void Deserialize(IDataReader reader)
{

parentRankId = reader.ReadVarUhInt();
            gfxId = reader.ReadVarUhInt();
            name = reader.ReadUTF();
            

}


}


}