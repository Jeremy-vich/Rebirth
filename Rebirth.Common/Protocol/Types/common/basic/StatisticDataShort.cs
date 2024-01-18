


















// Generated on 01/30/2023 13:09:30
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class StatisticDataShort : StatisticData
{

public const short Id = 603;
public override short TypeId
{
    get { return Id; }
}

public short value;
        

public StatisticDataShort()
{
}

public StatisticDataShort(short value)
        {
            this.value = value;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(value);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadShort();
            

}


}


}