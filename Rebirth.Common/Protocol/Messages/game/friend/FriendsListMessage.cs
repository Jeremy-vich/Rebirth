


















// Generated on 01/30/2023 13:09:20
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class FriendsListMessage : NetworkMessage
{

public const uint Id = 7934;
public uint MessageId
{
    get { return Id; }
}

public Types.FriendInformations[] friendsList;
        

public FriendsListMessage()
{
}

public FriendsListMessage(Types.FriendInformations[] friendsList)
        {
            this.friendsList = friendsList;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)friendsList.Length);
            foreach (var entry in friendsList)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            friendsList = new Types.FriendInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 friendsList[i] = ProtocolTypeManager.GetInstance<Types.FriendInformations>(reader.ReadUShort());
                 friendsList[i].Deserialize(reader);
            }
            

}


}


}