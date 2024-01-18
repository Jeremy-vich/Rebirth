


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ShortcutBarRemoveErrorMessage : NetworkMessage
{

public const uint Id = 5877;
public uint MessageId
{
    get { return Id; }
}

public sbyte error;
        

public ShortcutBarRemoveErrorMessage()
{
}

public ShortcutBarRemoveErrorMessage(sbyte error)
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