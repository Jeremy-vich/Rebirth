


















// Generated on 01/30/2023 13:09:30
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ClientYouAreDrunkMessage : DebugInClientMessage
{

public const uint Id = 9532;
public uint MessageId
{
    get { return Id; }
}



public ClientYouAreDrunkMessage()
{
}

public ClientYouAreDrunkMessage(sbyte level, string message)
         : base(level, message)
        {
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            

}


}


}