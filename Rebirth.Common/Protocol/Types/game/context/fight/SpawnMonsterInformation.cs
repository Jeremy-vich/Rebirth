


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class SpawnMonsterInformation : BaseSpawnMonsterInformation
{

public const short Id = 9613;
public override short TypeId
{
    get { return Id; }
}

public sbyte creatureGrade;
        

public SpawnMonsterInformation()
{
}

public SpawnMonsterInformation(uint creatureGenericId, sbyte creatureGrade)
         : base(creatureGenericId)
        {
            this.creatureGrade = creatureGrade;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(creatureGrade);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            creatureGrade = reader.ReadSbyte();
            

}


}


}