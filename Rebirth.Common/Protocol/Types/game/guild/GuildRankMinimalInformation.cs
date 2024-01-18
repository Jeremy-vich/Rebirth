


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GuildRankMinimalInformation
{

public const short Id = 9298;
public virtual short TypeId
{
    get { return Id; }
}

public uint id;
        public string name;
        

public GuildRankMinimalInformation()
{
}

public GuildRankMinimalInformation(uint id, string name)
        {
            this.id = id;
            this.name = name;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)id);
            writer.WriteUTF(name);
            

}

public virtual void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhInt();
            name = reader.ReadUTF();
            

}


}


}