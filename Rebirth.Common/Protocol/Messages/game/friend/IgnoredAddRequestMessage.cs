


















// Generated on 01/30/2023 13:09:20
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class IgnoredAddRequestMessage : NetworkMessage
{

public const uint Id = 1080;
public uint MessageId
{
    get { return Id; }
}

public Types.AbstractPlayerSearchInformation target;
        public bool session;
        

public IgnoredAddRequestMessage()
{
}

public IgnoredAddRequestMessage(Types.AbstractPlayerSearchInformation target, bool session)
        {
            this.target = target;
            this.session = session;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(target.TypeId);
            target.Serialize(writer);
            writer.WriteBoolean(session);
            

}

public void Deserialize(IDataReader reader)
{

target = ProtocolTypeManager.GetInstance<Types.AbstractPlayerSearchInformation>(reader.ReadUShort());
            target.Deserialize(reader);
            session = reader.ReadBoolean();
            

}


}


}