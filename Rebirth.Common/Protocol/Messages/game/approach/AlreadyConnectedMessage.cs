


















// Generated on 01/30/2023 13:09:09
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AlreadyConnectedMessage : NetworkMessage
{

public const uint Id = 1701;
public uint MessageId
{
    get { return Id; }
}



public AlreadyConnectedMessage()
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