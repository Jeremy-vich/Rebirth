


















// Generated on 01/30/2023 13:09:29
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class OrnamentSelectRequestMessage : NetworkMessage
{

public const uint Id = 1968;
public uint MessageId
{
    get { return Id; }
}

public uint ornamentId;
        

public OrnamentSelectRequestMessage()
{
}

public OrnamentSelectRequestMessage(uint ornamentId)
        {
            this.ornamentId = ornamentId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)ornamentId);
            

}

public void Deserialize(IDataReader reader)
{

ornamentId = reader.ReadVarUhShort();
            

}


}


}