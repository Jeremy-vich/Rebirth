


















// Generated on 01/30/2023 13:09:21
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildKickRequestMessage : NetworkMessage
{

public const uint Id = 7155;
public uint MessageId
{
    get { return Id; }
}

public double kickedId;
        

public GuildKickRequestMessage()
{
}

public GuildKickRequestMessage(double kickedId)
        {
            this.kickedId = kickedId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(kickedId);
            

}

public void Deserialize(IDataReader reader)
{

kickedId = reader.ReadVarUhLong();
            

}


}


}