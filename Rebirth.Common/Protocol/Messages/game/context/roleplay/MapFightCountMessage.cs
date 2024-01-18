


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class MapFightCountMessage : NetworkMessage
{

public const uint Id = 5031;
public uint MessageId
{
    get { return Id; }
}

public uint fightCount;
        

public MapFightCountMessage()
{
}

public MapFightCountMessage(uint fightCount)
        {
            this.fightCount = fightCount;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)fightCount);
            

}

public void Deserialize(IDataReader reader)
{

fightCount = reader.ReadVarUhShort();
            

}


}


}