


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class SpellItem : Item
{

public const short Id = 2784;
public override short TypeId
{
    get { return Id; }
}

public int spellId;
        public short spellLevel;
        

public SpellItem()
{
}

public SpellItem(int spellId, short spellLevel)
        {
            this.spellId = spellId;
            this.spellLevel = spellLevel;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(spellId);
            writer.WriteShort(spellLevel);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            spellId = reader.ReadInt();
            spellLevel = reader.ReadShort();
            

}


}


}