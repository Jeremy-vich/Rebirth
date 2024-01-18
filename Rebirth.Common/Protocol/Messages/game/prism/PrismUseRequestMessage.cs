


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PrismUseRequestMessage : NetworkMessage
{

public const uint Id = 751;
public uint MessageId
{
    get { return Id; }
}

public sbyte moduleToUse;
        

public PrismUseRequestMessage()
{
}

public PrismUseRequestMessage(sbyte moduleToUse)
        {
            this.moduleToUse = moduleToUse;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(moduleToUse);
            

}

public void Deserialize(IDataReader reader)
{

moduleToUse = reader.ReadSbyte();
            

}


}


}