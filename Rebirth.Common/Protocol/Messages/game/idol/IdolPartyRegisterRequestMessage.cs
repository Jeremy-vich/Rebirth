


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class IdolPartyRegisterRequestMessage : NetworkMessage
{

public const uint Id = 2560;
public uint MessageId
{
    get { return Id; }
}

public bool register;
        

public IdolPartyRegisterRequestMessage()
{
}

public IdolPartyRegisterRequestMessage(bool register)
        {
            this.register = register;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(register);
            

}

public void Deserialize(IDataReader reader)
{

register = reader.ReadBoolean();
            

}


}


}