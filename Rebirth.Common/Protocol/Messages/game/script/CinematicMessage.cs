


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class CinematicMessage : NetworkMessage
{

public const uint Id = 8039;
public uint MessageId
{
    get { return Id; }
}

public uint cinematicId;
        

public CinematicMessage()
{
}

public CinematicMessage(uint cinematicId)
        {
            this.cinematicId = cinematicId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)cinematicId);
            

}

public void Deserialize(IDataReader reader)
{

cinematicId = reader.ReadVarUhShort();
            

}


}


}