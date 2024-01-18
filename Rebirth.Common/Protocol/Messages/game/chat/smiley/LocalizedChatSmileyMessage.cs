


















// Generated on 01/30/2023 13:09:11
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class LocalizedChatSmileyMessage : ChatSmileyMessage
{

public const uint Id = 1117;
public uint MessageId
{
    get { return Id; }
}

public uint cellId;
        

public LocalizedChatSmileyMessage()
{
}

public LocalizedChatSmileyMessage(double entityId, uint smileyId, int accountId, uint cellId)
         : base(entityId, smileyId, accountId)
        {
            this.cellId = cellId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)cellId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            cellId = reader.ReadVarUhShort();
            

}


}


}