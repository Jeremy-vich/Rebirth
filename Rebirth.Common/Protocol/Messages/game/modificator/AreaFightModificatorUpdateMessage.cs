


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AreaFightModificatorUpdateMessage : NetworkMessage
{

public const uint Id = 7135;
public uint MessageId
{
    get { return Id; }
}

public int spellPairId;
        

public AreaFightModificatorUpdateMessage()
{
}

public AreaFightModificatorUpdateMessage(int spellPairId)
        {
            this.spellPairId = spellPairId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(spellPairId);
            

}

public void Deserialize(IDataReader reader)
{

spellPairId = reader.ReadInt();
            

}


}


}