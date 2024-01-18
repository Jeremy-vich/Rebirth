


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeCraftPaymentModificationRequestMessage : NetworkMessage
{

public const uint Id = 1214;
public uint MessageId
{
    get { return Id; }
}

public double quantity;
        

public ExchangeCraftPaymentModificationRequestMessage()
{
}

public ExchangeCraftPaymentModificationRequestMessage(double quantity)
        {
            this.quantity = quantity;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(quantity);
            

}

public void Deserialize(IDataReader reader)
{

quantity = reader.ReadVarUhLong();
            

}


}


}