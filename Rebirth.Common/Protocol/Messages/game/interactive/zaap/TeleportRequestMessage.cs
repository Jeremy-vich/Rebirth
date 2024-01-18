


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class TeleportRequestMessage : NetworkMessage
{

public const uint Id = 8454;
public uint MessageId
{
    get { return Id; }
}

public sbyte sourceType;
        public sbyte destinationType;
        public double mapId;
        

public TeleportRequestMessage()
{
}

public TeleportRequestMessage(sbyte sourceType, sbyte destinationType, double mapId)
        {
            this.sourceType = sourceType;
            this.destinationType = destinationType;
            this.mapId = mapId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(sourceType);
            writer.WriteSbyte(destinationType);
            writer.WriteDouble(mapId);
            

}

public void Deserialize(IDataReader reader)
{

sourceType = reader.ReadSbyte();
            destinationType = reader.ReadSbyte();
            mapId = reader.ReadDouble();
            

}


}


}