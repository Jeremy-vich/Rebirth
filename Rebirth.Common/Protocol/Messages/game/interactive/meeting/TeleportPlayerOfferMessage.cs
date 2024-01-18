


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class TeleportPlayerOfferMessage : NetworkMessage
{

public const uint Id = 7570;
public uint MessageId
{
    get { return Id; }
}

public double mapId;
        public string message;
        public uint timeLeft;
        public double requesterId;
        

public TeleportPlayerOfferMessage()
{
}

public TeleportPlayerOfferMessage(double mapId, string message, uint timeLeft, double requesterId)
        {
            this.mapId = mapId;
            this.message = message;
            this.timeLeft = timeLeft;
            this.requesterId = requesterId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(mapId);
            writer.WriteUTF(message);
            writer.WriteVarInt((int)timeLeft);
            writer.WriteVarLong(requesterId);
            

}

public void Deserialize(IDataReader reader)
{

mapId = reader.ReadDouble();
            message = reader.ReadUTF();
            timeLeft = reader.ReadVarUhInt();
            requesterId = reader.ReadVarUhLong();
            

}


}


}