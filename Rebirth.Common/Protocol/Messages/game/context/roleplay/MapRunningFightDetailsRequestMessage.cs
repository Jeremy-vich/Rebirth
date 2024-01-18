


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class MapRunningFightDetailsRequestMessage : NetworkMessage
{

public const uint Id = 1031;
public uint MessageId
{
    get { return Id; }
}

public uint fightId;
        

public MapRunningFightDetailsRequestMessage()
{
}

public MapRunningFightDetailsRequestMessage(uint fightId)
        {
            this.fightId = fightId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)fightId);
            

}

public void Deserialize(IDataReader reader)
{

fightId = reader.ReadVarUhShort();
            

}


}


}