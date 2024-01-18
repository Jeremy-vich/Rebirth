


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class EvolutiveObjectRecycleResultMessage : NetworkMessage
{

public const uint Id = 5075;
public uint MessageId
{
    get { return Id; }
}

public Types.RecycledItem[] recycledItems;
        

public EvolutiveObjectRecycleResultMessage()
{
}

public EvolutiveObjectRecycleResultMessage(Types.RecycledItem[] recycledItems)
        {
            this.recycledItems = recycledItems;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)recycledItems.Length);
            foreach (var entry in recycledItems)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            recycledItems = new Types.RecycledItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 recycledItems[i] = new Types.RecycledItem();
                 recycledItems[i].Deserialize(reader);
            }
            

}


}


}