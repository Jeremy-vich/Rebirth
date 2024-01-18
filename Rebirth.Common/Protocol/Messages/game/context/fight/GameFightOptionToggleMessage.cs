


















// Generated on 01/30/2023 13:09:12
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightOptionToggleMessage : NetworkMessage
{

public const uint Id = 7548;
public uint MessageId
{
    get { return Id; }
}

public sbyte option;
        

public GameFightOptionToggleMessage()
{
}

public GameFightOptionToggleMessage(sbyte option)
        {
            this.option = option;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(option);
            

}

public void Deserialize(IDataReader reader)
{

option = reader.ReadSbyte();
            

}


}


}