


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class MountEquipedErrorMessage : NetworkMessage
{

public const uint Id = 5572;
public uint MessageId
{
    get { return Id; }
}

public sbyte errorType;
        

public MountEquipedErrorMessage()
{
}

public MountEquipedErrorMessage(sbyte errorType)
        {
            this.errorType = errorType;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(errorType);
            

}

public void Deserialize(IDataReader reader)
{

errorType = reader.ReadSbyte();
            

}


}


}