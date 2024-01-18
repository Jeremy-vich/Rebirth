


















// Generated on 01/30/2023 13:09:26
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage : NetworkMessage
{

public const uint Id = 3047;
public uint MessageId
{
    get { return Id; }
}

public bool allow;
        

public ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage()
{
}

public ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage(bool allow)
        {
            this.allow = allow;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(allow);
            

}

public void Deserialize(IDataReader reader)
{

allow = reader.ReadBoolean();
            

}


}


}