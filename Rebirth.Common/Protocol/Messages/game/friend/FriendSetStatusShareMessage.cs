


















// Generated on 01/30/2023 13:09:20
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class FriendSetStatusShareMessage : NetworkMessage
{

public const uint Id = 4480;
public uint MessageId
{
    get { return Id; }
}

public bool share;
        

public FriendSetStatusShareMessage()
{
}

public FriendSetStatusShareMessage(bool share)
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