


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class SpawnScaledMonsterInformation : BaseSpawnMonsterInformation
{

public const short Id = 5733;
public override short TypeId
{
    get { return Id; }
}

public short creatureLevel;
        

public SpawnScaledMonsterInformation()
{
}

public SpawnScaledMonsterInformation(uint creatureGenericId, short creatureLevel)
         : base(creatureGenericId)
        {
            this.creatureLevel = creatureLevel;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(creatureLevel);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            creatureLevel = reader.ReadShort();
            

}


}


}