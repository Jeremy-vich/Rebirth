


















// Generated on 01/30/2023 13:09:25
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeStartedTaxCollectorShopMessage : NetworkMessage
{

public const uint Id = 8837;
public uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem[] objects;
        public double kamas;
        

public ExchangeStartedTaxCollectorShopMessage()
{
}

public ExchangeStartedTaxCollectorShopMessage(Types.ObjectItem[] objects, double kamas)
        {
            this.objects = objects;
            this.kamas = kamas;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)objects.Length);
            foreach (var entry in objects)
            {
                 entry.Serialize(writer);
            }
            writer.WriteVarLong(kamas);
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            objects = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 objects[i] = new Types.ObjectItem();
                 objects[i].Deserialize(reader);
            }
            kamas = reader.ReadVarUhLong();
            

}


}


}