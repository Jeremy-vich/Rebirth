


















// Generated on 01/30/2023 13:09:26
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeStartOkMulticraftCrafterMessage : NetworkMessage
{

public const uint Id = 341;
public uint MessageId
{
    get { return Id; }
}

public uint skillId;
        

public ExchangeStartOkMulticraftCrafterMessage()
{
}

public ExchangeStartOkMulticraftCrafterMessage(uint skillId)
        {
            this.skillId = skillId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)skillId);
            

}

public void Deserialize(IDataReader reader)
{

skillId = reader.ReadVarUhInt();
            

}


}


}