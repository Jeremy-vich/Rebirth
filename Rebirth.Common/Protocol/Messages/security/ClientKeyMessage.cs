


















// Generated on 01/30/2023 13:09:29
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ClientKeyMessage : NetworkMessage
{

public const uint Id = 9962;
public uint MessageId
{
    get { return Id; }
}

public string key;
        

public ClientKeyMessage()
{
}

public ClientKeyMessage(string key)
        {
            this.key = key;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(key);
            

}

public void Deserialize(IDataReader reader)
{

key = reader.ReadUTF();
            

}


}


}