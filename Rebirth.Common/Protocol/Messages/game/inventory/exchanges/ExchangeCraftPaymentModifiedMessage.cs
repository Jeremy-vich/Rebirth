


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeCraftPaymentModifiedMessage : NetworkMessage
{

public const uint Id = 9672;
public uint MessageId
{
    get { return Id; }
}

public double goldSum;
        

public ExchangeCraftPaymentModifiedMessage()
{
}

public ExchangeCraftPaymentModifiedMessage(double goldSum)
        {
            this.goldSum = goldSum;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(goldSum);
            

}

public void Deserialize(IDataReader reader)
{

goldSum = reader.ReadVarUhLong();
            

}


}


}