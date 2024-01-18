


















// Generated on 01/30/2023 13:09:20
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class FriendUpdateMessage : NetworkMessage
{

public const uint Id = 6696;
public uint MessageId
{
    get { return Id; }
}

public Types.FriendInformations friendUpdated;
        

public FriendUpdateMessage()
{
}

public FriendUpdateMessage(Types.FriendInformations friendUpdated)
        {
            this.friendUpdated = friendUpdated;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(friendUpdated.TypeId);
            friendUpdated.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

friendUpdated = ProtocolTypeManager.GetInstance<Types.FriendInformations>(reader.ReadUShort());
            friendUpdated.Deserialize(reader);
            

}


}


}