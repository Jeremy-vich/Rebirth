


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ShortcutEmote : Shortcut
{

public const short Id = 6747;
public override short TypeId
{
    get { return Id; }
}

public ushort emoteId;
        

public ShortcutEmote()
{
}

public ShortcutEmote(sbyte slot, ushort emoteId)
         : base(slot)
        {
            this.emoteId = emoteId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort(emoteId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            emoteId = reader.ReadUShort();
            

}


}


}