


















// Generated on 01/30/2023 13:09:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BasicPongMessage : NetworkMessage
{

public const uint Id = 7692;
public uint MessageId
{
    get { return Id; }
}

public bool quiet;
        

public BasicPongMessage()
{
}

public BasicPongMessage(bool quiet)
        {
            this.quiet = quiet;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(quiet);
            

}

public void Deserialize(IDataReader reader)
{

quiet = reader.ReadBoolean();
            

}


}


}