


















// Generated on 01/30/2023 13:09:26
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeStartOkMulticraftCustomerMessage : NetworkMessage
{

public const uint Id = 3687;
public uint MessageId
{
    get { return Id; }
}

public uint skillId;
        public byte crafterJobLevel;
        

public ExchangeStartOkMulticraftCustomerMessage()
{
}

public ExchangeStartOkMulticraftCustomerMessage(uint skillId, byte crafterJobLevel)
        {
            this.skillId = skillId;
            this.crafterJobLevel = crafterJobLevel;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)skillId);
            writer.WriteByte(crafterJobLevel);
            

}

public void Deserialize(IDataReader reader)
{

skillId = reader.ReadVarUhInt();
            crafterJobLevel = reader.ReadByte();
            

}


}


}