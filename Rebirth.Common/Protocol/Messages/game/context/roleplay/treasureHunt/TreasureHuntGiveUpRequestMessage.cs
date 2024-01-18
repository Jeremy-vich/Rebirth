


















// Generated on 01/30/2023 13:09:20
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class TreasureHuntGiveUpRequestMessage : NetworkMessage
{

public const uint Id = 4343;
public uint MessageId
{
    get { return Id; }
}

public sbyte questType;
        

public TreasureHuntGiveUpRequestMessage()
{
}

public TreasureHuntGiveUpRequestMessage(sbyte questType)
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