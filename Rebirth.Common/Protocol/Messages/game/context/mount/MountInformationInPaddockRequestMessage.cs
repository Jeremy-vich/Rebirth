


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class MountInformationInPaddockRequestMessage : NetworkMessage
{

public const uint Id = 9236;
public uint MessageId
{
    get { return Id; }
}

public int mapRideId;
        

public MountInformationInPaddockRequestMessage()
{
}

public MountInformationInPaddockRequestMessage(int mapRideId)
        {
            this.mapRideId = mapRideId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)mapRideId);
            

}

public void Deserialize(IDataReader reader)
{

mapRideId = reader.ReadVarInt();
            

}


}


}