


















// Generated on 01/30/2023 13:09:29
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class OrnamentLostMessage : NetworkMessage
{

public const uint Id = 7671;
public uint MessageId
{
    get { return Id; }
}

public short ornamentId;
        

public OrnamentLostMessage()
{
}

public OrnamentLostMessage(short ornamentId)
        {
            this.ornamentId = ornamentId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(ornamentId);
            

}

public void Deserialize(IDataReader reader)
{

ornamentId = reader.ReadShort();
            

}


}


}