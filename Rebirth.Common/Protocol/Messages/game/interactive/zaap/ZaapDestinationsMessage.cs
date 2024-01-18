


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ZaapDestinationsMessage : TeleportDestinationsMessage
{

public const uint Id = 5649;
public uint MessageId
{
    get { return Id; }
}

public double spawnMapId;
        

public ZaapDestinationsMessage()
{
}

public ZaapDestinationsMessage(sbyte type, Types.TeleportDestination[] destinations, double spawnMapId)
         : base(type, destinations)
        {
            this.spawnMapId = spawnMapId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(spawnMapId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            spawnMapId = reader.ReadDouble();
            

}


}


}