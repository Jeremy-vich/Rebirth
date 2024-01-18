


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BreachKickRequestMessage : NetworkMessage
{

public const uint Id = 1343;
public uint MessageId
{
    get { return Id; }
}

public double target;
        

public BreachKickRequestMessage()
{
}

public BreachKickRequestMessage(double target)
        {
            this.target = target;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(target);
            

}

public void Deserialize(IDataReader reader)
{

target = reader.ReadVarUhLong();
            

}


}


}