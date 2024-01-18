


















// Generated on 01/30/2023 13:09:33
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class AlignmentWarEffortInformation
{

public const short Id = 9859;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte alignmentSide;
        public double alignmentWarEffort;
        

public AlignmentWarEffortInformation()
{
}

public AlignmentWarEffortInformation(sbyte alignmentSide, double alignmentWarEffort)
        {
            this.alignmentSide = alignmentSide;
            this.alignmentWarEffort = alignmentWarEffort;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSbyte(alignmentSide);
            writer.WriteVarLong(alignmentWarEffort);
            

}

public virtual void Deserialize(IDataReader reader)
{

alignmentSide = reader.ReadSbyte();
            alignmentWarEffort = reader.ReadVarUhLong();
            

}


}


}