


















// Generated on 01/30/2023 13:09:09
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ServerOptionalFeaturesMessage : NetworkMessage
{

public const uint Id = 2590;
public uint MessageId
{
    get { return Id; }
}

public int[] features;
        

public ServerOptionalFeaturesMessage()
{
}

public ServerOptionalFeaturesMessage(int[] features)
        {
            this.features = features;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)features.Length);
            foreach (var entry in features)
            {
                 writer.WriteInt(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            features = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 features[i] = reader.ReadInt();
            }
            

}


}


}