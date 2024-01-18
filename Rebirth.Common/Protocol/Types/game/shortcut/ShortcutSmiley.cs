


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ShortcutSmiley : Shortcut
{

public const short Id = 5066;
public override short TypeId
{
    get { return Id; }
}

public uint smileyId;
        

public ShortcutSmiley()
{
}

public ShortcutSmiley(sbyte slot, uint smileyId)
         : base(slot)
        {
            this.smileyId = smileyId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)smileyId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            smileyId = reader.ReadVarUhShort();
            

}


}


}