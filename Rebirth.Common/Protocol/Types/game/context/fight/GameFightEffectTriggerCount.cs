


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameFightEffectTriggerCount
{

public const short Id = 6210;
public virtual short TypeId
{
    get { return Id; }
}

public uint effectId;
        public double targetId;
        public sbyte count;
        

public GameFightEffectTriggerCount()
{
}

public GameFightEffectTriggerCount(uint effectId, double targetId, sbyte count)
        {
            this.effectId = effectId;
            this.targetId = targetId;
            this.count = count;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)effectId);
            writer.WriteDouble(targetId);
            writer.WriteSbyte(count);
            

}

public virtual void Deserialize(IDataReader reader)
{

effectId = reader.ReadVarUhInt();
            targetId = reader.ReadDouble();
            count = reader.ReadSbyte();
            

}


}


}