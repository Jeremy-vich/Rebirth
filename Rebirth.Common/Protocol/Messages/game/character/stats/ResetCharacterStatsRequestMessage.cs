


















// Generated on 01/30/2023 13:09:11
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ResetCharacterStatsRequestMessage : NetworkMessage
{

public const uint Id = 3704;
public uint MessageId
{
    get { return Id; }
}



public ResetCharacterStatsRequestMessage()
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