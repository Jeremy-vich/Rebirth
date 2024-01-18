


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class EmoteListMessage : NetworkMessage
{

public const uint Id = 2677;
public uint MessageId
{
    get { return Id; }
}

public uint[] emoteIds;
        

public EmoteListMessage()
{
}

public EmoteListMessage(uint[] emoteIds)
        {
            this.emoteIds = emoteIds;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)emoteIds.Length);
            foreach (var entry in emoteIds)
            {
                writer.WriteShort((short)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{


            

}


}


}