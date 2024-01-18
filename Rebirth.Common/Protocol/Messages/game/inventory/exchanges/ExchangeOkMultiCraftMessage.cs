


















// Generated on 01/30/2023 13:09:25
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeOkMultiCraftMessage : NetworkMessage
{

public const uint Id = 6446;
public uint MessageId
{
    get { return Id; }
}

public double initiatorId;
        public double otherId;
        public sbyte role;
        

public ExchangeOkMultiCraftMessage()
{
}

public ExchangeOkMultiCraftMessage(double initiatorId, double otherId, sbyte role)
        {
            this.initiatorId = initiatorId;
            this.otherId = otherId;
            this.role = role;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(initiatorId);
            writer.WriteVarLong(otherId);
            writer.WriteSbyte(role);
            

}

public void Deserialize(IDataReader reader)
{

initiatorId = reader.ReadVarUhLong();
            otherId = reader.ReadVarUhLong();
            role = reader.ReadSbyte();
            

}


}


}