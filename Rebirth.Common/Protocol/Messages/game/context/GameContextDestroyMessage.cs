


















// Generated on 01/30/2023 13:09:11
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameContextDestroyMessage : NetworkMessage
{

public const uint Id = 668;
public uint MessageId
{
    get { return Id; }
}



public GameContextDestroyMessage()
{
}



public void Serialize(IDataWriter writer)
{



}

public void Deserialize(IDataReader reader)
{



}


}


}