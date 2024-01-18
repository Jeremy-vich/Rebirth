


















// Generated on 01/30/2023 13:09:25
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeStartedMessage : NetworkMessage
{

public const uint Id = 6209;
public uint MessageId
{
    get { return Id; }
}

public sbyte exchangeType;
        

public ExchangeStartedMessage()
{
}

public ExchangeStartedMessage(sbyte exchangeType)
        {
            this.exchangeType = exchangeType;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(exchangeType);
            

}

public void Deserialize(IDataReader reader)
{

exchangeType = reader.ReadSbyte();
            

}


}


}