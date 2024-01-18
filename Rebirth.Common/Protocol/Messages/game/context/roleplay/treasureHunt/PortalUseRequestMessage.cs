


















// Generated on 01/30/2023 13:09:19
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PortalUseRequestMessage : NetworkMessage
{

public const uint Id = 4099;
public uint MessageId
{
    get { return Id; }
}

public uint portalId;
        

public PortalUseRequestMessage()
{
}

public PortalUseRequestMessage(uint portalId)
        {
            this.portalId = portalId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)portalId);
            

}

public void Deserialize(IDataReader reader)
{

portalId = reader.ReadVarUhInt();
            

}


}


}