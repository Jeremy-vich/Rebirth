


















// Generated on 01/30/2023 13:09:33
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class HumanOptionAlliance : HumanOption
{

public const short Id = 6815;
public override short TypeId
{
    get { return Id; }
}

public Types.AllianceInformations allianceInformations;
        public sbyte aggressable;
        

public HumanOptionAlliance()
{
}

public HumanOptionAlliance(Types.AllianceInformations allianceInformations, sbyte aggressable)
        {
            this.allianceInformations = allianceInformations;
            this.aggressable = aggressable;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            allianceInformations.Serialize(writer);
            writer.WriteSbyte(aggressable);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            allianceInformations = new Types.AllianceInformations();
            allianceInformations.Deserialize(reader);
            aggressable = reader.ReadSbyte();
            

}


}


}