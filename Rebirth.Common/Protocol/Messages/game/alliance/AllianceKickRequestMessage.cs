


















// Generated on 01/30/2023 13:09:09
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AllianceKickRequestMessage : NetworkMessage
{

public const uint Id = 4496;
public uint MessageId
{
    get { return Id; }
}

public uint kickedId;
        

public AllianceKickRequestMessage()
{
}

public AllianceKickRequestMessage(uint kickedId)
        {
            this.kickedId = kickedId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)kickedId);
            

}

public void Deserialize(IDataReader reader)
{

kickedId = reader.ReadVarUhInt();
            

}


}


}