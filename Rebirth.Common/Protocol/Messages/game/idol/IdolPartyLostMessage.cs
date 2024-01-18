


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class IdolPartyLostMessage : NetworkMessage
{

public const uint Id = 6894;
public uint MessageId
{
    get { return Id; }
}

public uint idolId;
        

public IdolPartyLostMessage()
{
}

public IdolPartyLostMessage(uint idolId)
        {
            this.idolId = idolId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)idolId);
            

}

public void Deserialize(IDataReader reader)
{

idolId = reader.ReadVarUhShort();
            

}


}


}