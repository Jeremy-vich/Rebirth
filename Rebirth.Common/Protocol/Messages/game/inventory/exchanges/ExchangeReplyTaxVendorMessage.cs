


















// Generated on 01/30/2023 13:09:25
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeReplyTaxVendorMessage : NetworkMessage
{

public const uint Id = 1144;
public uint MessageId
{
    get { return Id; }
}

public double objectValue;
        public double totalTaxValue;
        

public ExchangeReplyTaxVendorMessage()
{
}

public ExchangeReplyTaxVendorMessage(double objectValue, double totalTaxValue)
        {
            this.objectValue = objectValue;
            this.totalTaxValue = totalTaxValue;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(objectValue);
            writer.WriteVarLong(totalTaxValue);
            

}

public void Deserialize(IDataReader reader)
{

objectValue = reader.ReadVarUhLong();
            totalTaxValue = reader.ReadVarUhLong();
            

}


}


}