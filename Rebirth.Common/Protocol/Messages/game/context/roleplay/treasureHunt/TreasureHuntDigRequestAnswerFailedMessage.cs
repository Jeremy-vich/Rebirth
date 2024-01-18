


















// Generated on 01/30/2023 13:09:19
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class TreasureHuntDigRequestAnswerFailedMessage : TreasureHuntDigRequestAnswerMessage
{

public const uint Id = 6088;
public uint MessageId
{
    get { return Id; }
}

public sbyte wrongFlagCount;
        

public TreasureHuntDigRequestAnswerFailedMessage()
{
}

public TreasureHuntDigRequestAnswerFailedMessage(sbyte questType, sbyte result, sbyte wrongFlagCount)
         : base(questType, result)
        {
            this.wrongFlagCount = wrongFlagCount;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(wrongFlagCount);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            wrongFlagCount = reader.ReadSbyte();
            

}


}


}