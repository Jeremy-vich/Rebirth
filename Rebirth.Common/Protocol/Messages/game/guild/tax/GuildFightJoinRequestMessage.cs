


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildFightJoinRequestMessage : NetworkMessage
{

public const uint Id = 1426;
public uint MessageId
{
    get { return Id; }
}

public double taxCollectorId;
        

public GuildFightJoinRequestMessage()
{
}

public GuildFightJoinRequestMessage(double taxCollectorId)
        {
            this.taxCollectorId = taxCollectorId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(taxCollectorId);
            

}

public void Deserialize(IDataReader reader)
{

taxCollectorId = reader.ReadDouble();
            

}


}


}