


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildFightLeaveRequestMessage : NetworkMessage
{

public const uint Id = 6954;
public uint MessageId
{
    get { return Id; }
}

public double taxCollectorId;
        public double characterId;
        

public GuildFightLeaveRequestMessage()
{
}

public GuildFightLeaveRequestMessage(double taxCollectorId, double characterId)
        {
            this.taxCollectorId = taxCollectorId;
            this.characterId = characterId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(taxCollectorId);
            writer.WriteVarLong(characterId);
            

}

public void Deserialize(IDataReader reader)
{

taxCollectorId = reader.ReadDouble();
            characterId = reader.ReadVarUhLong();
            

}


}


}