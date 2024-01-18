


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class BasicNamedAllianceInformations : BasicAllianceInformations
{

public const short Id = 1895;
public override short TypeId
{
    get { return Id; }
}

public string allianceName;
        

public BasicNamedAllianceInformations()
{
}

public BasicNamedAllianceInformations(uint allianceId, string allianceTag, string allianceName)
         : base(allianceId, allianceTag)
        {
            this.allianceName = allianceName;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(allianceName);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            allianceName = reader.ReadUTF();
            

}


}


}