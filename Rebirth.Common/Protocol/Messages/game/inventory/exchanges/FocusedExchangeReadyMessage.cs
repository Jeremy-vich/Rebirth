


















// Generated on 01/30/2023 13:09:26
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class FocusedExchangeReadyMessage : ExchangeReadyMessage
{

public const uint Id = 6757;
public uint MessageId
{
    get { return Id; }
}

public uint focusActionId;
        

public FocusedExchangeReadyMessage()
{
}

public FocusedExchangeReadyMessage(bool ready, uint step, uint focusActionId)
         : base(ready, step)
        {
            this.focusActionId = focusActionId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)focusActionId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            focusActionId = reader.ReadVarUhInt();
            

}


}


}