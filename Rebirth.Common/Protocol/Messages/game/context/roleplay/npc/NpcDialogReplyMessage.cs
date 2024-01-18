


















// Generated on 01/30/2023 13:09:17
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class NpcDialogReplyMessage : NetworkMessage
{

public const uint Id = 8790;
public uint MessageId
{
    get { return Id; }
}

public uint replyId;
        

public NpcDialogReplyMessage()
{
}

public NpcDialogReplyMessage(uint replyId)
        {
            this.replyId = replyId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)replyId);
            

}

public void Deserialize(IDataReader reader)
{

replyId = reader.ReadVarUhInt();
            

}


}


}