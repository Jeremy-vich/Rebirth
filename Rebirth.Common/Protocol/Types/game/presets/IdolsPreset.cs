


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class IdolsPreset : Preset
{

public const short Id = 9110;
public override short TypeId
{
    get { return Id; }
}

public short iconId;
        public uint[] idolIds;
        

public IdolsPreset()
{
}

public IdolsPreset(short id, short iconId, uint[] idolIds)
         : base(id)
        {
            this.iconId = iconId;
            this.idolIds = idolIds;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(iconId);
            writer.WriteShort((short)idolIds.Length);
            foreach (var entry in idolIds)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            iconId = reader.ReadShort();
            var limit = (ushort)reader.ReadUShort();
            idolIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 idolIds[i] = reader.ReadVarUhShort();
            }
            

}


}


}