


















// Generated on 01/30/2023 13:09:25
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeOfflineSoldItemsMessage : NetworkMessage
{

public const uint Id = 4323;
public uint MessageId
{
    get { return Id; }
}

public Types.ObjectItemQuantityPriceDateEffects[] bidHouseItems;
        public Types.ObjectItemQuantityPriceDateEffects[] merchantItems;
        

public ExchangeOfflineSoldItemsMessage()
{
}

public ExchangeOfflineSoldItemsMessage(Types.ObjectItemQuantityPriceDateEffects[] bidHouseItems, Types.ObjectItemQuantityPriceDateEffects[] merchantItems)
        {
            this.bidHouseItems = bidHouseItems;
            this.merchantItems = merchantItems;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)bidHouseItems.Length);
            foreach (var entry in bidHouseItems)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)merchantItems.Length);
            foreach (var entry in merchantItems)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            bidHouseItems = new Types.ObjectItemQuantityPriceDateEffects[limit];
            for (int i = 0; i < limit; i++)
            {
                 bidHouseItems[i] = new Types.ObjectItemQuantityPriceDateEffects();
                 bidHouseItems[i].Deserialize(reader);
            }
            limit = (ushort)reader.ReadUShort();
            merchantItems = new Types.ObjectItemQuantityPriceDateEffects[limit];
            for (int i = 0; i < limit; i++)
            {
                 merchantItems[i] = new Types.ObjectItemQuantityPriceDateEffects();
                 merchantItems[i].Deserialize(reader);
            }
            

}


}


}