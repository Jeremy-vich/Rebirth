


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeBidHouseUnsoldItemsMessage : NetworkMessage
{

public const uint Id = 4267;
public uint MessageId
{
    get { return Id; }
}

public Types.ObjectItemGenericQuantity[] items;
        

public ExchangeBidHouseUnsoldItemsMessage()
{
}

public ExchangeBidHouseUnsoldItemsMessage(Types.ObjectItemGenericQuantity[] items)
        {
            this.items = items;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)items.Length);
            foreach (var entry in items)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            items = new Types.ObjectItemGenericQuantity[limit];
            for (int i = 0; i < limit; i++)
            {
                 items[i] = new Types.ObjectItemGenericQuantity();
                 items[i].Deserialize(reader);
            }
            

}


}


}