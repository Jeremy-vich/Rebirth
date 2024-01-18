


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class MountEmoteIconUsedOkMessage : NetworkMessage
{

public const uint Id = 4509;
public uint MessageId
{
    get { return Id; }
}

public int mountId;
        public sbyte reactionType;
        

public MountEmoteIconUsedOkMessage()
{
}

public MountEmoteIconUsedOkMessage(int mountId, sbyte reactionType)
        {
            this.mountId = mountId;
            this.reactionType = reactionType;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)mountId);
            writer.WriteSbyte(reactionType);
            

}

public void Deserialize(IDataReader reader)
{

mountId = reader.ReadVarInt();
            reactionType = reader.ReadSbyte();
            

}


}


}