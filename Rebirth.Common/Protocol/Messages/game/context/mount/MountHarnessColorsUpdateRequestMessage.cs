


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class MountHarnessColorsUpdateRequestMessage : NetworkMessage
{

public const uint Id = 285;
public uint MessageId
{
    get { return Id; }
}

public bool useHarnessColors;
        

public MountHarnessColorsUpdateRequestMessage()
{
}

public MountHarnessColorsUpdateRequestMessage(bool useHarnessColors)
        {
            this.useHarnessColors = useHarnessColors;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(useHarnessColors);
            

}

public void Deserialize(IDataReader reader)
{

useHarnessColors = reader.ReadBoolean();
            

}


}


}