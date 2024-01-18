


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class FightLoot
{

public const short Id = 6118;
public virtual short TypeId
{
    get { return Id; }
}

public Types.FightLootObject[] objects;
        public double kamas;
        

public FightLoot()
{
}

public FightLoot(Types.FightLootObject[] objects, double kamas)
        {
            this.objects = objects;
            this.kamas = kamas;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteShort((short)objects.Length);
            foreach (var entry in objects)
            {
                 entry.Serialize(writer);
            }
            writer.WriteVarLong(kamas);
            

}

public virtual void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            objects = new Types.FightLootObject[limit];
            for (int i = 0; i < limit; i++)
            {
                 objects[i] = new Types.FightLootObject();
                 objects[i].Deserialize(reader);
            }
            kamas = reader.ReadVarUhLong();
            

}


}


}