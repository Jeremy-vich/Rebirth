


















// Generated on 01/30/2023 13:09:11
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ChatCommunityChannelCommunityMessage : NetworkMessage
{

public const uint Id = 9161;
public uint MessageId
{
    get { return Id; }
}

public short communityId;
        

public ChatCommunityChannelCommunityMessage()
{
}

public ChatCommunityChannelCommunityMessage(short communityId)
        {
            this.communityId = communityId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(communityId);
            

}

public void Deserialize(IDataReader reader)
{

communityId = reader.ReadShort();
            

}


}


}