


















// Generated on 01/30/2023 13:09:20
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class IgnoredGetListMessage : NetworkMessage
{

public const uint Id = 1190;
public uint MessageId
{
    get { return Id; }
}



public IgnoredGetListMessage()
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