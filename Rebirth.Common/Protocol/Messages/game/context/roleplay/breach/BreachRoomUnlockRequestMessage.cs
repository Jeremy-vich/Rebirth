


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BreachRoomUnlockRequestMessage : NetworkMessage
{

public const uint Id = 5563;
public uint MessageId
{
    get { return Id; }
}

public sbyte roomId;
        

public BreachRoomUnlockRequestMessage()
{
}

public BreachRoomUnlockRequestMessage(sbyte roomId)
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