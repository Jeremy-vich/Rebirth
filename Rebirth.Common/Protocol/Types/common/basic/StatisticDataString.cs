


















// Generated on 01/30/2023 13:09:30
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class StatisticDataString : StatisticData
{

public const short Id = 6817;
public override short TypeId
{
    get { return Id; }
}

public string value;
        

public StatisticDataString()
{
}

public StatisticDataString(string value)
        {
            this.value = value;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(value);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadUTF();
            

}


}


}