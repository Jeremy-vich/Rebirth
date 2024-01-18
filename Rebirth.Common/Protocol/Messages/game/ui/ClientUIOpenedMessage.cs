


















// Generated on 01/30/2023 13:09:29
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ClientUIOpenedMessage : NetworkMessage
{

public const uint Id = 4724;
public uint MessageId
{
    get { return Id; }
}

public sbyte type;
        

public ClientUIOpenedMessage()
{
}

public ClientUIOpenedMessage(sbyte type)
        {
            this.type = type;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(type);
            

}

public void Deserialize(IDataReader reader)
{

type = reader.ReadSbyte();
            

}


}


}