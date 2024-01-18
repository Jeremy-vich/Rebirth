


















// Generated on 01/30/2023 13:09:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BasicPingMessage : NetworkMessage
{

public const uint Id = 311;
public uint MessageId
{
    get { return Id; }
}

public bool quiet;
        

public BasicPingMessage()
{
}

public BasicPingMessage(bool quiet)
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