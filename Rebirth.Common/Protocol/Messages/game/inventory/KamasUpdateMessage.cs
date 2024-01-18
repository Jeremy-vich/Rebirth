


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class KamasUpdateMessage : NetworkMessage
{

public const uint Id = 4842;
public uint MessageId
{
    get { return Id; }
}

public double kamasTotal;
        

public KamasUpdateMessage()
{
}

public KamasUpdateMessage(double kamasTotal)
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