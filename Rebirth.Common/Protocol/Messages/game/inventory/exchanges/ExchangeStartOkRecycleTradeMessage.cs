


















// Generated on 01/30/2023 13:09:26
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeStartOkRecycleTradeMessage : NetworkMessage
{

public const uint Id = 6135;
public uint MessageId
{
    get { return Id; }
}

public short percentToPrism;
        public short percentToPlayer;
        

public ExchangeStartOkRecycleTradeMessage()
{
}

public ExchangeStartOkRecycleTradeMessage(short percentToPrism, short percentToPlayer)
        {
            this.percentToPrism = percentToPrism;
            this.percentToPlayer = percentToPlayer;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(percentToPrism);
            writer.WriteShort(percentToPlayer);
            

}

public void Deserialize(IDataReader reader)
{

percentToPrism = reader.ReadShort();
            percentToPlayer = reader.ReadShort();
            

}


}


}