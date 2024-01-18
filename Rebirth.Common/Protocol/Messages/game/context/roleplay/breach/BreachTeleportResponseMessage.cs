


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BreachTeleportResponseMessage : NetworkMessage
{

public const uint Id = 8020;
public uint MessageId
{
    get { return Id; }
}

public bool teleported;
        

public BreachTeleportResponseMessage()
{
}

public BreachTeleportResponseMessage(bool teleported)
        {
            this.teleported = teleported;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(teleported);
            

}

public void Deserialize(IDataReader reader)
{

teleported = reader.ReadBoolean();
            

}


}


}