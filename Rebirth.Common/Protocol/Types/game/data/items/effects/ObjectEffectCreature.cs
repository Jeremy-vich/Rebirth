


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ObjectEffectCreature : ObjectEffect
{

public const short Id = 2792;
public override short TypeId
{
    get { return Id; }
}

public uint monsterFamilyId;
        

public ObjectEffectCreature()
{
}

public ObjectEffectCreature(uint actionId, uint monsterFamilyId)
         : base(actionId)
        {
            this.monsterFamilyId = monsterFamilyId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)monsterFamilyId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            monsterFamilyId = reader.ReadVarUhShort();
            

}


}


}