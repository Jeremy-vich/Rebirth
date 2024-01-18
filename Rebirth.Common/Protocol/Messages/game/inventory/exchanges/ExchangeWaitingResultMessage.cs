


















// Generated on 01/30/2023 13:09:26
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeWaitingResultMessage : NetworkMessage
{

public const uint Id = 134;
public uint MessageId
{
    get { return Id; }
}

public bool bwait;
        

public ExchangeWaitingResultMessage()
{
}

public ExchangeWaitingResultMessage(bool bwait)
        {
            this.bwait = bwait;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(bwait);
            

}

public void Deserialize(IDataReader reader)
{

bwait = reader.ReadBoolean();
            

}


}


}