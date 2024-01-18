


















// Generated on 01/30/2023 13:09:25
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangePlayerRequestMessage : ExchangeRequestMessage
{

public const uint Id = 6471;
public uint MessageId
{
    get { return Id; }
}

public double target;
        

public ExchangePlayerRequestMessage()
{
}

public ExchangePlayerRequestMessage(sbyte exchangeType, double target)
         : base(exchangeType)
        {
            this.target = target;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(target);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            target = reader.ReadVarUhLong();
            

}


}


}