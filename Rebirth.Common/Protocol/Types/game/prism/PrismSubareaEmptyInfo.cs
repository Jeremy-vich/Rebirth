


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class PrismSubareaEmptyInfo
{

public const short Id = 2190;
public virtual short TypeId
{
    get { return Id; }
}

public uint subAreaId;
        public uint allianceId;
        

public PrismSubareaEmptyInfo()
{
}

public PrismSubareaEmptyInfo(uint subAreaId, uint allianceId)
        {
            this.subAreaId = subAreaId;
            this.allianceId = allianceId;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)subAreaId);
            writer.WriteVarInt((int)allianceId);
            

}

public virtual void Deserialize(IDataReader reader)
{

subAreaId = reader.ReadVarUhShort();
            allianceId = reader.ReadVarUhInt();
            

}


}


}