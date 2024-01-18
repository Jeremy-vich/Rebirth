


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BreachBudgetMessage : NetworkMessage
{

public const uint Id = 9185;
public uint MessageId
{
    get { return Id; }
}

public uint bugdet;
        

public BreachBudgetMessage()
{
}

public BreachBudgetMessage(uint bugdet)
        {
            this.bugdet = bugdet;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)bugdet);
            

}

public void Deserialize(IDataReader reader)
{

bugdet = reader.ReadVarUhInt();
            

}


}


}