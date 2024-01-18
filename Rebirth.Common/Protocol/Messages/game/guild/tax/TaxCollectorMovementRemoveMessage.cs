


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class TaxCollectorMovementRemoveMessage : NetworkMessage
{

public const uint Id = 4860;
public uint MessageId
{
    get { return Id; }
}

public double collectorId;
        

public TaxCollectorMovementRemoveMessage()
{
}

public TaxCollectorMovementRemoveMessage(double collectorId)
        {
            this.collectorId = collectorId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(collectorId);
            

}

public void Deserialize(IDataReader reader)
{

collectorId = reader.ReadDouble();
            

}


}


}