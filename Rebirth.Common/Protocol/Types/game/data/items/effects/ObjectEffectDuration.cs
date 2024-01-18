


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ObjectEffectDuration : ObjectEffect
{

public const short Id = 5181;
public override short TypeId
{
    get { return Id; }
}

public uint days;
        public sbyte hours;
        public sbyte minutes;
        

public ObjectEffectDuration()
{
}

public ObjectEffectDuration(uint actionId, uint days, sbyte hours, sbyte minutes)
         : base(actionId)
        {
            this.days = days;
            this.hours = hours;
            this.minutes = minutes;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)days);
            writer.WriteSbyte(hours);
            writer.WriteSbyte(minutes);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            days = reader.ReadVarUhShort();
            hours = reader.ReadSbyte();
            minutes = reader.ReadSbyte();
            

}


}


}