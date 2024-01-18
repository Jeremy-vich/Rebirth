


















// Generated on 01/30/2023 13:09:25
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeReadyMessage : NetworkMessage
{

public const uint Id = 8296;
public uint MessageId
{
    get { return Id; }
}

public bool ready;
        public uint step;
        

public ExchangeReadyMessage()
{
}

public ExchangeReadyMessage(bool ready, uint step)
        {
            this.ready = ready;
            this.step = step;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(ready);
            writer.WriteVarShort((int)step);
            

}

public void Deserialize(IDataReader reader)
{

ready = reader.ReadBoolean();
            step = reader.ReadVarUhShort();
            

}


}


}