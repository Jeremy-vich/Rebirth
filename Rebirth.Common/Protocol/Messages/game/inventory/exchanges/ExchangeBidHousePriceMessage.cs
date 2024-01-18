


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeBidHousePriceMessage : NetworkMessage
{

public const uint Id = 347;
public uint MessageId
{
    get { return Id; }
}

public uint objectGID;
        

public ExchangeBidHousePriceMessage()
{
}

public ExchangeBidHousePriceMessage(uint objectGID)
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