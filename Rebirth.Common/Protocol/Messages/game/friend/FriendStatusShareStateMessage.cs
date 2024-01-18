


















// Generated on 01/30/2023 13:09:20
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class FriendStatusShareStateMessage : NetworkMessage
{

public const uint Id = 9395;
public uint MessageId
{
    get { return Id; }
}

public bool share;
        

public FriendStatusShareStateMessage()
{
}

public FriendStatusShareStateMessage(bool share)
        {
            this.share = share;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(share);
            

}

public void Deserialize(IDataReader reader)
{

share = reader.ReadBoolean();
            

}


}


}