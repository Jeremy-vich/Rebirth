


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class TeleportDestinationsMessage : NetworkMessage
{

public const uint Id = 1545;
public uint MessageId
{
    get { return Id; }
}

public sbyte type;
        public Types.TeleportDestination[] destinations;
        

public TeleportDestinationsMessage()
{
}

public TeleportDestinationsMessage(sbyte type, Types.TeleportDestination[] destinations)
        {
            this.type = type;
            this.destinations = destinations;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(type);
            writer.WriteShort((short)destinations.Length);
            foreach (var entry in destinations)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

type = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            destinations = new Types.TeleportDestination[limit];
            for (int i = 0; i < limit; i++)
            {
                 destinations[i] = new Types.TeleportDestination();
                 destinations[i].Deserialize(reader);
            }
            

}


}


}