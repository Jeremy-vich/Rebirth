


















// Generated on 01/30/2023 13:09:20
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class FriendDeleteResultMessage : NetworkMessage
{

public const uint Id = 4536;
public uint MessageId
{
    get { return Id; }
}

public bool success;
        public Types.AccountTagInformation tag;
        

public FriendDeleteResultMessage()
{
}

public FriendDeleteResultMessage(bool success, Types.AccountTagInformation tag)
        {
            this.success = success;
            this.tag = tag;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(success);
            tag.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

success = reader.ReadBoolean();
            tag = new Types.AccountTagInformation();
            tag.Deserialize(reader);
            

}


}


}