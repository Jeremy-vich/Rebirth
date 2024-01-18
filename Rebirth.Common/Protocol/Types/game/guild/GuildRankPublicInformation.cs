


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GuildRankPublicInformation : GuildRankMinimalInformation
{

public const short Id = 8341;
public override short TypeId
{
    get { return Id; }
}

public uint order;
        public uint gfxId;
        

public GuildRankPublicInformation()
{
}

public GuildRankPublicInformation(uint id, string name, uint order, uint gfxId)
         : base(id, name)
        {
            this.order = order;
            this.gfxId = gfxId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)order);
            writer.WriteVarInt((int)gfxId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            order = reader.ReadVarUhInt();
            gfxId = reader.ReadVarUhInt();
            

}


}


}