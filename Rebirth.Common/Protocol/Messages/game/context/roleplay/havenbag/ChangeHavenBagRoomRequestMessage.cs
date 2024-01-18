


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ChangeHavenBagRoomRequestMessage : NetworkMessage
{

public const uint Id = 9860;
public uint MessageId
{
    get { return Id; }
}

public sbyte roomId;
        

public ChangeHavenBagRoomRequestMessage()
{
}

public ChangeHavenBagRoomRequestMessage(sbyte roomId)
        {
            this.roomId = roomId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(roomId);
            

}

public void Deserialize(IDataReader reader)
{

roomId = reader.ReadSbyte();
            

}


}


}