


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class KnownZaapListMessage : NetworkMessage
{

public const uint Id = 2113;
public uint MessageId
{
    get { return Id; }
}

public double[] destinations;
        

public KnownZaapListMessage()
{
}

public KnownZaapListMessage(double[] destinations)
        {
            this.destinations = destinations;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)destinations.Length);
            foreach (var entry in destinations)
            {
                 writer.WriteDouble(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            destinations = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 destinations[i] = reader.ReadDouble();
            }
            

}


}


}