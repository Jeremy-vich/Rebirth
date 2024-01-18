


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ActorAlignmentInformations
{

public const short Id = 1577;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte alignmentSide;
        public sbyte alignmentValue;
        public sbyte alignmentGrade;
        public double characterPower;
        

public ActorAlignmentInformations()
{
}

public ActorAlignmentInformations(sbyte alignmentSide, sbyte alignmentValue, sbyte alignmentGrade, double characterPower)
        {
            this.alignmentSide = alignmentSide;
            this.alignmentValue = alignmentValue;
            this.alignmentGrade = alignmentGrade;
            this.characterPower = characterPower;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSbyte(alignmentSide);
            writer.WriteSbyte(alignmentValue);
            writer.WriteSbyte(alignmentGrade);
            writer.WriteDouble(characterPower);
            

}

public virtual void Deserialize(IDataReader reader)
{

alignmentSide = reader.ReadSbyte();
            alignmentValue = reader.ReadSbyte();
            alignmentGrade = reader.ReadSbyte();
            characterPower = reader.ReadDouble();
            

}


}


}