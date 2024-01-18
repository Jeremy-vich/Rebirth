


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class UpdateGuildRightsMessage : NetworkMessage
{

public const uint Id = 4414;
public uint MessageId
{
    get { return Id; }
}

public uint rankId;
        public uint[] rights;
        

public UpdateGuildRightsMessage()
{
}

public UpdateGuildRightsMessage(uint rankId, uint[] rights)
        {
            this.rankId = rankId;
            this.rights = rights;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)rankId);
            writer.WriteShort((short)rights.Length);
            foreach (var entry in rights)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

rankId = reader.ReadVarUhInt();
            var limit = (ushort)reader.ReadUShort();
            rights = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 rights[i] = reader.ReadVarUhInt();
            }
            

}


}


}