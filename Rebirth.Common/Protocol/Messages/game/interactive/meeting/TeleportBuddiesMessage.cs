


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class TeleportBuddiesMessage : NetworkMessage
{

public const uint Id = 5762;
public uint MessageId
{
    get { return Id; }
}

public uint dungeonId;
        

public TeleportBuddiesMessage()
{
}

public TeleportBuddiesMessage(uint dungeonId)
        {
            this.dungeonId = dungeonId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)dungeonId);
            

}

public void Deserialize(IDataReader reader)
{

dungeonId = reader.ReadVarUhShort();
            

}


}


}