


















// Generated on 01/30/2023 13:09:25
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeObjectMoveKamaMessage : NetworkMessage
{

public const uint Id = 1808;
public uint MessageId
{
    get { return Id; }
}

public double quantity;
        

public ExchangeObjectMoveKamaMessage()
{
}

public ExchangeObjectMoveKamaMessage(double quantity)
        {
            this.quantity = quantity;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(quantity);
            

}

public void Deserialize(IDataReader reader)
{

quantity = reader.ReadVarLong();
            

}


}


}