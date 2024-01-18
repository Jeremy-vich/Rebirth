


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameFightSpellCooldown
{

public const short Id = 6738;
public virtual short TypeId
{
    get { return Id; }
}

public int spellId;
        public sbyte cooldown;
        

public GameFightSpellCooldown()
{
}

public GameFightSpellCooldown(int spellId, sbyte cooldown)
        {
            this.spellId = spellId;
            this.cooldown = cooldown;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteInt(spellId);
            writer.WriteSbyte(cooldown);
            

}

public virtual void Deserialize(IDataReader reader)
{

spellId = reader.ReadInt();
            cooldown = reader.ReadSbyte();
            

}


}


}