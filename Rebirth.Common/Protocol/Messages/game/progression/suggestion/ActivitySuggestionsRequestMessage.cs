


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ActivitySuggestionsRequestMessage : NetworkMessage
{

public const uint Id = 4176;
public uint MessageId
{
    get { return Id; }
}

public uint minLevel;
        public uint maxLevel;
        public uint areaId;
        public uint activityCategoryId;
        public ushort nbCards;
        

public ActivitySuggestionsRequestMessage()
{
}

public ActivitySuggestionsRequestMessage(uint minLevel, uint maxLevel, uint areaId, uint activityCategoryId, ushort nbCards)
        {
            this.minLevel = minLevel;
            this.maxLevel = maxLevel;
            this.areaId = areaId;
            this.activityCategoryId = activityCategoryId;
            this.nbCards = nbCards;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)minLevel);
            writer.WriteVarShort((int)maxLevel);
            writer.WriteVarShort((int)areaId);
            writer.WriteVarShort((int)activityCategoryId);
            writer.WriteUShort(nbCards);
            

}

public void Deserialize(IDataReader reader)
{

minLevel = reader.ReadVarUhShort();
            maxLevel = reader.ReadVarUhShort();
            areaId = reader.ReadVarUhShort();
            activityCategoryId = reader.ReadVarUhShort();
            nbCards = reader.ReadUShort();
            

}


}


}