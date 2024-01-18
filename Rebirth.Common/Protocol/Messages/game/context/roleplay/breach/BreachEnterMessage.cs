


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BreachEnterMessage : NetworkMessage
{

public const uint Id = 6288;
public uint MessageId
{
    get { return Id; }
}

public double owner;
        

public BreachEnterMessage()
{
}

public BreachEnterMessage(double owner)
        {
            this.owner = owner;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(owner);
            

}

public void Deserialize(IDataReader reader)
{

owner = reader.ReadVarUhLong();
            

}


}


}