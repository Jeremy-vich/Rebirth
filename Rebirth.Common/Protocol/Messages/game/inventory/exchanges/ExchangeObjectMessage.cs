


















// Generated on 01/30/2023 13:09:25
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeObjectMessage : NetworkMessage
{

public const uint Id = 7057;
public uint MessageId
{
    get { return Id; }
}

public bool remote;
        

public ExchangeObjectMessage()
{
}

public ExchangeObjectMessage(bool remote)
        {
            this.remote = remote;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(remote);
            

}

public void Deserialize(IDataReader reader)
{

remote = reader.ReadBoolean();
            

}


}


}