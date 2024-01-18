


















// Generated on 01/30/2023 13:09:09
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class CompassUpdateMessage : NetworkMessage
{

public const uint Id = 7989;
public uint MessageId
{
    get { return Id; }
}

public sbyte type;
        public Types.MapCoordinates coords;
        

public CompassUpdateMessage()
{
}

public CompassUpdateMessage(sbyte type, Types.MapCoordinates coords)
        {
            this.type = type;
            this.coords = coords;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(type);
            writer.WriteShort(coords.TypeId);
            coords.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

type = reader.ReadSbyte();
            coords = ProtocolTypeManager.GetInstance<Types.MapCoordinates>(reader.ReadUShort());
            coords.Deserialize(reader);
            

}


}


}