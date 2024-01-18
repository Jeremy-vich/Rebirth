


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildPaddockTeleportRequestMessage : NetworkMessage
{

public const uint Id = 991;
public uint MessageId
{
    get { return Id; }
}

public double paddockId;
        

public GuildPaddockTeleportRequestMessage()
{
}

public GuildPaddockTeleportRequestMessage(double paddockId)
        {
            this.paddockId = paddockId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(paddockId);
            

}

public void Deserialize(IDataReader reader)
{

paddockId = reader.ReadDouble();
            

}


}


}