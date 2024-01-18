


















// Generated on 01/30/2023 13:09:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AllianceCreationResultMessage : NetworkMessage
{

public const uint Id = 5395;
public uint MessageId
{
    get { return Id; }
}

public sbyte result;
        

public AllianceCreationResultMessage()
{
}

public AllianceCreationResultMessage(sbyte result)
        {
            this.result = result;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(result);
            

}

public void Deserialize(IDataReader reader)
{

result = reader.ReadSbyte();
            

}


}


}