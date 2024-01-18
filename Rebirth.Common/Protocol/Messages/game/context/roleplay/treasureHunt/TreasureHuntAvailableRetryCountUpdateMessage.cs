


















// Generated on 01/30/2023 13:09:19
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class TreasureHuntAvailableRetryCountUpdateMessage : NetworkMessage
{

public const uint Id = 7523;
public uint MessageId
{
    get { return Id; }
}

public sbyte questType;
        public int availableRetryCount;
        

public TreasureHuntAvailableRetryCountUpdateMessage()
{
}

public TreasureHuntAvailableRetryCountUpdateMessage(sbyte questType, int availableRetryCount)
        {
            this.questType = questType;
            this.availableRetryCount = availableRetryCount;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(questType);
            writer.WriteInt(availableRetryCount);
            

}

public void Deserialize(IDataReader reader)
{

questType = reader.ReadSbyte();
            availableRetryCount = reader.ReadInt();
            

}


}


}