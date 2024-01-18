


















// Generated on 01/30/2023 13:09:33
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ForgettableSpellItem : SpellItem
{

public const short Id = 650;
public override short TypeId
{
    get { return Id; }
}

public bool available;
        

public ForgettableSpellItem()
{
}

public ForgettableSpellItem(int spellId, short spellLevel, bool available)
         : base(spellId, spellLevel)
        {
            this.available = available;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(available);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            available = reader.ReadBoolean();
            

}


}


}