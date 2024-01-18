


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeMoneyMovementInformationMessage : NetworkMessage
{

public const uint Id = 5803;
public uint MessageId
{
    get { return Id; }
}

public double limit;
        

public ExchangeMoneyMovementInformationMessage()
{
}

public ExchangeMoneyMovementInformationMessage(double limit)
        {
            this.limit = limit;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(limit);
            

}

public void Deserialize(IDataReader reader)
{

limit = reader.ReadVarUhLong();
            

}


}


}