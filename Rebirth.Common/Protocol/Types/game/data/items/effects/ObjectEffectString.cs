


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ObjectEffectString : ObjectEffect
{

public const short Id = 4073;
public override short TypeId
{
    get { return Id; }
}

public string value;
        

public ObjectEffectString()
{
}

public ObjectEffectString(uint actionId, string value)
         : base(actionId)
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