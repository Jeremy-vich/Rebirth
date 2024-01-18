


















// Generated on 01/30/2023 13:09:26
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class LivingObjectMessageMessage : NetworkMessage
{

public const uint Id = 6479;
public uint MessageId
{
    get { return Id; }
}

public uint msgId;
        public int timeStamp;
        public string owner;
        public uint objectGenericId;
        

public LivingObjectMessageMessage()
{
}

public LivingObjectMessageMessage(uint msgId, int timeStamp, string owner, uint objectGenericId)
        {
            this.msgId = msgId;
            this.timeStamp = timeStamp;
            this.owner = owner;
            this.objectGenericId = objectGenericId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)msgId);
            writer.WriteInt(timeStamp);
            writer.WriteUTF(owner);
            writer.WriteVarInt((int)objectGenericId);
            

}

public void Deserialize(IDataReader reader)
{

msgId = reader.ReadVarUhShort();
            timeStamp = reader.ReadInt();
            owner = reader.ReadUTF();
            objectGenericId = reader.ReadVarUhInt();
            

}


}


}