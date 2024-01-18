


















// Generated on 01/30/2023 13:09:20
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class FriendAddRequestMessage : NetworkMessage
{

public const uint Id = 5133;
public uint MessageId
{
    get { return Id; }
}

public Types.AbstractPlayerSearchInformation target;
        

public FriendAddRequestMessage()
{
}

public FriendAddRequestMessage(Types.AbstractPlayerSearchInformation target)
        {
            this.target = target;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(target.TypeId);
            target.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

target = ProtocolTypeManager.GetInstance<Types.AbstractPlayerSearchInformation>(reader.ReadUShort());
            target.Deserialize(reader);
            

}


}


}