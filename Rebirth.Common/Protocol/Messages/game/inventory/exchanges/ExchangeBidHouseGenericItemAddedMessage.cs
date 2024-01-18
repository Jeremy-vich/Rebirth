


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeBidHouseGenericItemAddedMessage : NetworkMessage
{

public const uint Id = 2496;
public uint MessageId
{
    get { return Id; }
}

public uint objGenericId;
        

public ExchangeBidHouseGenericItemAddedMessage()
{
}

public ExchangeBidHouseGenericItemAddedMessage(uint objGenericId)
        {
            this.objGenericId = objGenericId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objGenericId);
            

}

public void Deserialize(IDataReader reader)
{

objGenericId = reader.ReadVarUhInt();
            

}


}


}