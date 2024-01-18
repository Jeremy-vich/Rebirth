


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ObjectEffectMinMax : ObjectEffect
{

public const short Id = 8669;
public override short TypeId
{
    get { return Id; }
}

public uint min;
        public uint max;
        

public ObjectEffectMinMax()
{
}

public ObjectEffectMinMax(uint actionId, uint min, uint max)
         : base(actionId)
        {
            this.min = min;
            this.max = max;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)min);
            writer.WriteVarInt((int)max);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            min = reader.ReadVarUhInt();
            max = reader.ReadVarUhInt();
            

}


}


}