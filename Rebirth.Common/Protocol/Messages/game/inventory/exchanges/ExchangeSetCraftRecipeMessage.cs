


















// Generated on 01/30/2023 13:09:25
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeSetCraftRecipeMessage : NetworkMessage
{

public const uint Id = 577;
public uint MessageId
{
    get { return Id; }
}

public uint objectGID;
        

public ExchangeSetCraftRecipeMessage()
{
}

public ExchangeSetCraftRecipeMessage(uint objectGID)
        {
            this.objectGID = objectGID;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectGID);
            

}

public void Deserialize(IDataReader reader)
{

objectGID = reader.ReadVarUhInt();
            

}


}


}