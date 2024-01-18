


















// Generated on 01/30/2023 13:09:30
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ServerSessionConstantString : ServerSessionConstant
{

public const short Id = 8495;
public override short TypeId
{
    get { return Id; }
}

public string value;
        

public ServerSessionConstantString()
{
}

public ServerSessionConstantString(uint id, string value)
         : base(id)
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