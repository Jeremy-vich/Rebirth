


















// Generated on 01/30/2023 13:09:09
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BasicWhoAmIRequestMessage : NetworkMessage
{

public const uint Id = 4263;
public uint MessageId
{
    get { return Id; }
}

public bool verbose;
        

public BasicWhoAmIRequestMessage()
{
}

public BasicWhoAmIRequestMessage(bool verbose)
        {
            this.verbose = verbose;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(verbose);
            

}

public void Deserialize(IDataReader reader)
{

verbose = reader.ReadBoolean();
            

}


}


}