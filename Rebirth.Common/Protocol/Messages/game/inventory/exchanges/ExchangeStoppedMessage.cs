


















// Generated on 01/30/2023 13:09:26
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeStoppedMessage : NetworkMessage
{

public const uint Id = 9964;
public uint MessageId
{
    get { return Id; }
}

public double id;
        

public ExchangeStoppedMessage()
{
}

public ExchangeStoppedMessage(double id)
        {
            this.id = id;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(id);
            

}

public void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhLong();
            

}


}


}