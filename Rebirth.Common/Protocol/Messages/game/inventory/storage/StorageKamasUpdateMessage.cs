


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class StorageKamasUpdateMessage : NetworkMessage
{

public const uint Id = 5514;
public uint MessageId
{
    get { return Id; }
}

public double kamasTotal;
        

public StorageKamasUpdateMessage()
{
}

public StorageKamasUpdateMessage(double kamasTotal)
        {
            this.kamasTotal = kamasTotal;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(kamasTotal);
            

}

public void Deserialize(IDataReader reader)
{

kamasTotal = reader.ReadVarUhLong();
            

}


}


}