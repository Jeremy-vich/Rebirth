


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class TeleportPlayerCloseMessage : NetworkMessage
{

public const uint Id = 3576;
public uint MessageId
{
    get { return Id; }
}

public double mapId;
        public double requesterId;
        

public TeleportPlayerCloseMessage()
{
}

public TeleportPlayerCloseMessage(double mapId, double requesterId)
        {
            this.mapId = mapId;
            this.requesterId = requesterId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(mapId);
            writer.WriteVarLong(requesterId);
            

}

public void Deserialize(IDataReader reader)
{

mapId = reader.ReadDouble();
            requesterId = reader.ReadVarUhLong();
            

}


}


}