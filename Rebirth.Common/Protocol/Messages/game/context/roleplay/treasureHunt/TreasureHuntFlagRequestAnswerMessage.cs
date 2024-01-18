


















// Generated on 01/30/2023 13:09:20
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class TreasureHuntFlagRequestAnswerMessage : NetworkMessage
{

public const uint Id = 4502;
public uint MessageId
{
    get { return Id; }
}

public sbyte questType;
        public sbyte result;
        public sbyte index;
        

public TreasureHuntFlagRequestAnswerMessage()
{
}

public TreasureHuntFlagRequestAnswerMessage(sbyte questType, sbyte result, sbyte index)
        {
            this.questType = questType;
            this.result = result;
            this.index = index;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(questType);
            writer.WriteSbyte(result);
            writer.WriteSbyte(index);
            

}

public void Deserialize(IDataReader reader)
{

questType = reader.ReadSbyte();
            result = reader.ReadSbyte();
            index = reader.ReadSbyte();
            

}


}


}