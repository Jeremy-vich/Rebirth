


















// Generated on 01/30/2023 13:09:26
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeStartOkCraftWithInformationMessage : ExchangeStartOkCraftMessage
{

public const uint Id = 4146;
public uint MessageId
{
    get { return Id; }
}

public uint skillId;
        

public ExchangeStartOkCraftWithInformationMessage()
{
}

public ExchangeStartOkCraftWithInformationMessage(uint skillId)
        {
            this.skillId = skillId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)skillId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            skillId = reader.ReadVarUhInt();
            

}


}


}