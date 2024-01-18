


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class HouseSellRequestMessage : NetworkMessage
{

public const uint Id = 2707;
public uint MessageId
{
    get { return Id; }
}

public int instanceId;
        public double amount;
        public bool forSale;
        

public HouseSellRequestMessage()
{
}

public HouseSellRequestMessage(int instanceId, double amount, bool forSale)
        {
            this.instanceId = instanceId;
            this.amount = amount;
            this.forSale = forSale;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(instanceId);
            writer.WriteVarLong(amount);
            writer.WriteBoolean(forSale);
            

}

public void Deserialize(IDataReader reader)
{

instanceId = reader.ReadInt();
            amount = reader.ReadVarUhLong();
            forSale = reader.ReadBoolean();
            

}


}


}