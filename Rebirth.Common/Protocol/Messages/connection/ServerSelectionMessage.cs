


















// Generated on 01/30/2023 13:09:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ServerSelectionMessage : NetworkMessage
{

public const uint Id = 4450;
public uint MessageId
{
    get { return Id; }
}

public uint serverId;
        

public ServerSelectionMessage()
{
}

public ServerSelectionMessage(uint serverId)
        {
            this.serverId = serverId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)serverId);
            

}

public void Deserialize(IDataReader reader)
{

serverId = reader.ReadVarUhShort();
            

}


}


}