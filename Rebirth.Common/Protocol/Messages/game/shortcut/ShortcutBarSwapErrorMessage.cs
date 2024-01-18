


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ShortcutBarSwapErrorMessage : NetworkMessage
{

public const uint Id = 4705;
public uint MessageId
{
    get { return Id; }
}

public sbyte error;
        

public ShortcutBarSwapErrorMessage()
{
}

public ShortcutBarSwapErrorMessage(sbyte error)
        {
            this.error = error;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(error);
            

}

public void Deserialize(IDataReader reader)
{

error = reader.ReadSbyte();
            

}


}


}