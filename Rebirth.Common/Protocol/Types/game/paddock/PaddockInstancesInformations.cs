


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class PaddockInstancesInformations : PaddockInformations
{

public const short Id = 2666;
public override short TypeId
{
    get { return Id; }
}

public Types.PaddockBuyableInformations[] paddocks;
        

public PaddockInstancesInformations()
{
}

public PaddockInstancesInformations(uint maxOutdoorMount, uint maxItems, Types.PaddockBuyableInformations[] paddocks)
         : base(maxOutdoorMount, maxItems)
        {
            this.paddocks = paddocks;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)paddocks.Length);
            foreach (var entry in paddocks)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            paddocks = new Types.PaddockBuyableInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 paddocks[i] = ProtocolTypeManager.GetInstance<Types.PaddockBuyableInformations>(reader.ReadUShort());
                 paddocks[i].Deserialize(reader);
            }
            

}


}


}