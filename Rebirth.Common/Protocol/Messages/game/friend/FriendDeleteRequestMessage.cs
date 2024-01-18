


















// Generated on 01/30/2023 13:09:20
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class FriendDeleteRequestMessage : NetworkMessage
{

public const uint Id = 6293;
public uint MessageId
{
    get { return Id; }
}

public int accountId;
        

public FriendDeleteRequestMessage()
{
}

public FriendDeleteRequestMessage(int accountId)
        {
            this.accountId = accountId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(accountId);
            

}

public void Deserialize(IDataReader reader)
{

accountId = reader.ReadInt();
            

}


}


}