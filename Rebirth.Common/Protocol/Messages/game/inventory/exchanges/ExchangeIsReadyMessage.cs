


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeIsReadyMessage : NetworkMessage
{

public const uint Id = 8027;
public uint MessageId
{
    get { return Id; }
}

public double id;
        public bool ready;
        

public ExchangeIsReadyMessage()
{
}

public ExchangeIsReadyMessage(double id, bool ready)
        {
            this.id = id;
            this.ready = ready;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(id);
            writer.WriteBoolean(ready);
            

}

public void Deserialize(IDataReader reader)
{

id = reader.ReadDouble();
            ready = reader.ReadBoolean();
            

}


}


}