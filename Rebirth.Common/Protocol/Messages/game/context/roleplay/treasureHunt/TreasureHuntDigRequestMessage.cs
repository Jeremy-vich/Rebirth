


















// Generated on 01/30/2023 13:09:19
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class TreasureHuntDigRequestMessage : NetworkMessage
{

public const uint Id = 2025;
public uint MessageId
{
    get { return Id; }
}

public sbyte questType;
        

public TreasureHuntDigRequestMessage()
{
}

public TreasureHuntDigRequestMessage(sbyte questType)
        {
            this.questType = questType;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(questType);
            

}

public void Deserialize(IDataReader reader)
{

questType = reader.ReadSbyte();
            

}


}


}