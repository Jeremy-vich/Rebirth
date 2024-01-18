


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BreachSavedMessage : NetworkMessage
{

public const uint Id = 6598;
public uint MessageId
{
    get { return Id; }
}

public bool saved;
        

public BreachSavedMessage()
{
}

public BreachSavedMessage(bool saved)
        {
            this.saved = saved;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(saved);
            

}

public void Deserialize(IDataReader reader)
{

saved = reader.ReadBoolean();
            

}


}


}