


















// Generated on 01/30/2023 13:09:25
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeObjectMoveToTabMessage : NetworkMessage
{

public const uint Id = 7034;
public uint MessageId
{
    get { return Id; }
}

public uint objectUID;
        public int quantity;
        public uint tabNumber;
        

public ExchangeObjectMoveToTabMessage()
{
}

public ExchangeObjectMoveToTabMessage(uint objectUID, int quantity, uint tabNumber)
        {
            this.objectUID = objectUID;
            this.quantity = quantity;
            this.tabNumber = tabNumber;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectUID);
            writer.WriteVarInt((int)quantity);
            writer.WriteVarInt((int)tabNumber);
            

}

public void Deserialize(IDataReader reader)
{

objectUID = reader.ReadVarUhInt();
            quantity = reader.ReadVarInt();
            tabNumber = reader.ReadVarUhInt();
            

}


}


}