


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class TeleportHavenBagRequestMessage : NetworkMessage
{

public const uint Id = 3622;
public uint MessageId
{
    get { return Id; }
}

public double guestId;
        

public TeleportHavenBagRequestMessage()
{
}

public TeleportHavenBagRequestMessage(double guestId)
        {
            this.guestId = guestId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(guestId);
            

}

public void Deserialize(IDataReader reader)
{

guestId = reader.ReadVarUhLong();
            

}


}


}