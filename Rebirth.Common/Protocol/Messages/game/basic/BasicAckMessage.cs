


















// Generated on 01/30/2023 13:09:09
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BasicAckMessage : NetworkMessage
{

public const uint Id = 4644;
public uint MessageId
{
    get { return Id; }
}

public uint seq;
        public uint lastPacketId;
        

public BasicAckMessage()
{
}

public BasicAckMessage(uint seq, uint lastPacketId)
        {
            this.seq = seq;
            this.lastPacketId = lastPacketId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)seq);
            writer.WriteVarShort((int)lastPacketId);
            

}

public void Deserialize(IDataReader reader)
{

seq = reader.ReadVarUhInt();
            lastPacketId = reader.ReadVarUhShort();
            

}


}


}