


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BreachExitResponseMessage : NetworkMessage
{

public const uint Id = 4165;
public uint MessageId
{
    get { return Id; }
}

public bool exited;
        

public BreachExitResponseMessage()
{
}

public BreachExitResponseMessage(bool exited)
        {
            this.exited = exited;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(exited);
            

}

public void Deserialize(IDataReader reader)
{

exited = reader.ReadBoolean();
            

}


}


}