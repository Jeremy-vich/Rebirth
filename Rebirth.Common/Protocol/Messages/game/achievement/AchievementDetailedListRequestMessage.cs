


















// Generated on 01/30/2023 13:09:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AchievementDetailedListRequestMessage : NetworkMessage
{

public const uint Id = 4355;
public uint MessageId
{
    get { return Id; }
}

public uint categoryId;
        

public AchievementDetailedListRequestMessage()
{
}

public AchievementDetailedListRequestMessage(uint categoryId)
        {
            this.categoryId = categoryId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)categoryId);
            

}

public void Deserialize(IDataReader reader)
{

categoryId = reader.ReadVarUhShort();
            

}


}


}