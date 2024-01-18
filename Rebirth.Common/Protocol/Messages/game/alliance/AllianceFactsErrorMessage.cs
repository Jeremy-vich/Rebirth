


















// Generated on 01/30/2023 13:09:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AllianceFactsErrorMessage : NetworkMessage
{

public const uint Id = 9996;
public uint MessageId
{
    get { return Id; }
}

public uint allianceId;
        

public AllianceFactsErrorMessage()
{
}

public AllianceFactsErrorMessage(uint allianceId)
        {
            this.allianceId = allianceId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)allianceId);
            

}

public void Deserialize(IDataReader reader)
{

allianceId = reader.ReadVarUhInt();
            

}


}


}