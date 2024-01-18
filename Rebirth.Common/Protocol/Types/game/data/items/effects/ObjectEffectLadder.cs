


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ObjectEffectLadder : ObjectEffectCreature
{

public const short Id = 9939;
public override short TypeId
{
    get { return Id; }
}

public uint monsterCount;
        

public ObjectEffectLadder()
{
}

public ObjectEffectLadder(uint actionId, uint monsterFamilyId, uint monsterCount)
         : base(actionId, monsterFamilyId)
        {
            this.monsterCount = monsterCount;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)monsterCount);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            monsterCount = reader.ReadVarUhInt();
            

}


}


}