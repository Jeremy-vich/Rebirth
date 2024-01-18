


















// Generated on 01/30/2023 13:09:20
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class TreasureHuntLegendaryRequestMessage : NetworkMessage
{

public const uint Id = 9060;
public uint MessageId
{
    get { return Id; }
}

public uint legendaryId;
        

public TreasureHuntLegendaryRequestMessage()
{
}

public TreasureHuntLegendaryRequestMessage(uint legendaryId)
        {
            this.legendaryId = legendaryId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)legendaryId);
            

}

public void Deserialize(IDataReader reader)
{

legendaryId = reader.ReadVarUhShort();
            

}


}


}