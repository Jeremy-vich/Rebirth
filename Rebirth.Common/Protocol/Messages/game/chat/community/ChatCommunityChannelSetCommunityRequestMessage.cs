


















// Generated on 01/30/2023 13:09:11
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ChatCommunityChannelSetCommunityRequestMessage : NetworkMessage
{

public const uint Id = 8434;
public uint MessageId
{
    get { return Id; }
}

public short communityId;
        

public ChatCommunityChannelSetCommunityRequestMessage()
{
}

public ChatCommunityChannelSetCommunityRequestMessage(short communityId)
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