


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class BasicAllianceInformations : AbstractSocialGroupInfos
{

public const short Id = 2850;
public override short TypeId
{
    get { return Id; }
}

public uint allianceId;
        public string allianceTag;
        

public BasicAllianceInformations()
{
}

public BasicAllianceInformations(uint allianceId, string allianceTag)
        {
            this.allianceId = allianceId;
            this.allianceTag = allianceTag;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)allianceId);
            writer.WriteUTF(allianceTag);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            allianceId = reader.ReadVarUhInt();
            allianceTag = reader.ReadUTF();
            

}


}


}