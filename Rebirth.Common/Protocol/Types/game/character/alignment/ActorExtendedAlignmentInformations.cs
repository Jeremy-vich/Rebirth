


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ActorExtendedAlignmentInformations : ActorAlignmentInformations
{

public const short Id = 7183;
public override short TypeId
{
    get { return Id; }
}

public uint honor;
        public uint honorGradeFloor;
        public uint honorNextGradeFloor;
        public sbyte aggressable;
        

public ActorExtendedAlignmentInformations()
{
}

public ActorExtendedAlignmentInformations(sbyte alignmentSide, sbyte alignmentValue, sbyte alignmentGrade, double characterPower, uint honor, uint honorGradeFloor, uint honorNextGradeFloor, sbyte aggressable)
         : base(alignmentSide, alignmentValue, alignmentGrade, characterPower)
        {
            this.honor = honor;
            this.honorGradeFloor = honorGradeFloor;
            this.honorNextGradeFloor = honorNextGradeFloor;
            this.aggressable = aggressable;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)honor);
            writer.WriteVarShort((int)honorGradeFloor);
            writer.WriteVarShort((int)honorNextGradeFloor);
            writer.WriteSbyte(aggressable);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            honor = reader.ReadVarUhShort();
            honorGradeFloor = reader.ReadVarUhShort();
            honorNextGradeFloor = reader.ReadVarUhShort();
            aggressable = reader.ReadSbyte();
            

}


}


}