


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class CharactersListRequestMessage : NetworkMessage
{

public const uint Id = 1659;
public uint MessageId
{
    get { return Id; }
}



public CharactersListRequestMessage()
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