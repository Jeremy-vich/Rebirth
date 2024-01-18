


















// Generated on 01/30/2023 13:09:36
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GuildVersatileInformations
{

public const short Id = 1609;
public virtual short TypeId
{
    get { return Id; }
}

public uint guildId;
        public double leaderId;
        public byte guildLevel;
        public byte nbMembers;
        

public GuildVersatileInformations()
{
}

public GuildVersatileInformations(uint guildId, double leaderId, byte guildLevel, byte nbMembers)
        {
            this.guildId = guildId;
            this.leaderId = leaderId;
            this.guildLevel = guildLevel;
            this.nbMembers = nbMembers;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)guildId);
            writer.WriteVarLong(leaderId);
            writer.WriteByte(guildLevel);
            writer.WriteByte(nbMembers);
            

}

public virtual void Deserialize(IDataReader reader)
{

guildId = reader.ReadVarUhInt();
            leaderId = reader.ReadVarUhLong();
            guildLevel = reader.ReadByte();
            nbMembers = reader.ReadByte();
            

}


}


}