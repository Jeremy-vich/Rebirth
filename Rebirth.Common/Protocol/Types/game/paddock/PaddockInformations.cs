


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class PaddockInformations
{

public const short Id = 8948;
public virtual short TypeId
{
    get { return Id; }
}

public uint maxOutdoorMount;
        public uint maxItems;
        

public PaddockInformations()
{
}

public PaddockInformations(uint maxOutdoorMount, uint maxItems)
        {
            this.maxOutdoorMount = maxOutdoorMount;
            this.maxItems = maxItems;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)maxOutdoorMount);
            writer.WriteVarShort((int)maxItems);
            

}

public virtual void Deserialize(IDataReader reader)
{

maxOutdoorMount = reader.ReadVarUhShort();
            maxItems = reader.ReadVarUhShort();
            

}


}


}