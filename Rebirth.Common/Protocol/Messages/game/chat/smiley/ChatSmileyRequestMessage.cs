


















// Generated on 01/30/2023 13:09:11
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ChatSmileyRequestMessage : NetworkMessage
{

public const uint Id = 5949;
public uint MessageId
{
    get { return Id; }
}

public uint smileyId;
        

public ChatSmileyRequestMessage()
{
}

public ChatSmileyRequestMessage(uint smileyId)
        {
            this.smileyId = smileyId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)smileyId);
            

}

public void Deserialize(IDataReader reader)
{

smileyId = reader.ReadVarUhShort();
            

}


}


}