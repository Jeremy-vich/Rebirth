


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeCrafterJobLevelupMessage : NetworkMessage
{

public const uint Id = 6283;
public uint MessageId
{
    get { return Id; }
}

public byte crafterJobLevel;
        

public ExchangeCrafterJobLevelupMessage()
{
}

public ExchangeCrafterJobLevelupMessage(byte crafterJobLevel)
        {
            this.crafterJobLevel = crafterJobLevel;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteByte(crafterJobLevel);
            

}

public void Deserialize(IDataReader reader)
{

crafterJobLevel = reader.ReadByte();
            

}


}


}