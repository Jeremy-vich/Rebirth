


















// Generated on 01/30/2023 13:09:25
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeRequestedTradeMessage : ExchangeRequestedMessage
{

public const uint Id = 5307;
public uint MessageId
{
    get { return Id; }
}

public double source;
        public double target;
        

public ExchangeRequestedTradeMessage()
{
}

public ExchangeRequestedTradeMessage(sbyte exchangeType, double source, double target)
         : base(exchangeType)
        {
            this.source = source;
            this.target = target;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(source);
            writer.WriteVarLong(target);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            source = reader.ReadVarUhLong();
            target = reader.ReadVarUhLong();
            

}


}


}