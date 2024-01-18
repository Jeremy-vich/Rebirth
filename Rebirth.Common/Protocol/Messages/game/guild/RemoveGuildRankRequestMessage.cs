


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class RemoveGuildRankRequestMessage : NetworkMessage
{

public const uint Id = 7055;
public uint MessageId
{
    get { return Id; }
}

public uint rankId;
        public uint newRankId;
        

public RemoveGuildRankRequestMessage()
{
}

public RemoveGuildRankRequestMessage(uint rankId, uint newRankId)
        {
            this.rankId = rankId;
            this.newRankId = newRankId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)rankId);
            writer.WriteVarInt((int)newRankId);
            

}

public void Deserialize(IDataReader reader)
{

rankId = reader.ReadVarUhInt();
            newRankId = reader.ReadVarUhInt();
            

}


}


}