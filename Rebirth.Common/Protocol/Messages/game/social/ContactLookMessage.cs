


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ContactLookMessage : NetworkMessage
{

public const uint Id = 2519;
public uint MessageId
{
    get { return Id; }
}

public uint requestId;
        public string playerName;
        public double playerId;
        public Types.EntityLook look;
        

public ContactLookMessage()
{
}

public ContactLookMessage(uint requestId, string playerName, double playerId, Types.EntityLook look)
        {
            this.requestId = requestId;
            this.playerName = playerName;
            this.playerId = playerId;
            this.look = look;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)requestId);
            writer.WriteUTF(playerName);
            writer.WriteVarLong(playerId);
            look.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

requestId = reader.ReadVarUhInt();
            playerName = reader.ReadUTF();
            playerId = reader.ReadVarUhLong();
            look = new Types.EntityLook();
            look.Deserialize(reader);
            

}


}


}