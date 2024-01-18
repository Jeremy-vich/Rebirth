


















// Generated on 01/30/2023 13:09:26
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeStartOkNpcTradeMessage : NetworkMessage
{

public const uint Id = 8770;
public uint MessageId
{
    get { return Id; }
}

public double npcId;
        

public ExchangeStartOkNpcTradeMessage()
{
}

public ExchangeStartOkNpcTradeMessage(double npcId)
        {
            this.npcId = npcId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(npcId);
            

}

public void Deserialize(IDataReader reader)
{

npcId = reader.ReadDouble();
            

}


}


}