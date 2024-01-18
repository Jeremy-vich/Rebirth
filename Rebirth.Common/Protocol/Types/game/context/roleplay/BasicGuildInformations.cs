


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class BasicGuildInformations : AbstractSocialGroupInfos
{

public const short Id = 3099;
public override short TypeId
{
    get { return Id; }
}

public uint guildId;
        public string guildName;
        public byte guildLevel;
        

public BasicGuildInformations()
{
}

public BasicGuildInformations(uint guildId, string guildName, byte guildLevel)
        {
            this.guildId = guildId;
            this.guildName = guildName;
            this.guildLevel = guildLevel;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)guildId);
            writer.WriteUTF(guildName);
            writer.WriteByte(guildLevel);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            guildId = reader.ReadVarUhInt();
            guildName = reader.ReadUTF();
            guildLevel = reader.ReadByte();
            

}


}


}