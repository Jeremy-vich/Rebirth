


















// Generated on 01/30/2023 13:09:26
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeMultiCraftCrafterCanUseHisRessourcesMessage : NetworkMessage
{

public const uint Id = 2230;
public uint MessageId
{
    get { return Id; }
}

public bool allowed;
        

public ExchangeMultiCraftCrafterCanUseHisRessourcesMessage()
{
}

public ExchangeMultiCraftCrafterCanUseHisRessourcesMessage(bool allowed)
        {
            this.allowed = allowed;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(allowed);
            

}

public void Deserialize(IDataReader reader)
{

allowed = reader.ReadBoolean();
            

}


}


}