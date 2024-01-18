


















// Generated on 01/30/2023 13:09:30
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class StatisticDataBoolean : StatisticData
{

public const short Id = 2517;
public override short TypeId
{
    get { return Id; }
}

public bool value;
        

public StatisticDataBoolean()
{
}

public StatisticDataBoolean(bool value)
        {
            this.value = value;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(value);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadBoolean();
            

}


}


}