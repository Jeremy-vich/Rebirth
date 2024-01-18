


















// Generated on 01/30/2023 13:09:25
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeStartedWithMultiTabStorageMessage : ExchangeStartedMessage
{

public const uint Id = 3711;
public uint MessageId
{
    get { return Id; }
}

public uint storageMaxSlot;
        public uint tabNumber;
        

public ExchangeStartedWithMultiTabStorageMessage()
{
}

public ExchangeStartedWithMultiTabStorageMessage(sbyte exchangeType, uint storageMaxSlot, uint tabNumber)
         : base(exchangeType)
        {
            this.storageMaxSlot = storageMaxSlot;
            this.tabNumber = tabNumber;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)storageMaxSlot);
            writer.WriteVarInt((int)tabNumber);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            storageMaxSlot = reader.ReadVarUhInt();
            tabNumber = reader.ReadVarUhInt();
            

}


}


}