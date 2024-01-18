


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class HavenBagFurnituresMessage : NetworkMessage
{

public const uint Id = 7743;
public uint MessageId
{
    get { return Id; }
}

public Types.HavenBagFurnitureInformation[] furnituresInfos;
        

public HavenBagFurnituresMessage()
{
}

public HavenBagFurnituresMessage(Types.HavenBagFurnitureInformation[] furnituresInfos)
        {
            this.furnituresInfos = furnituresInfos;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)furnituresInfos.Length);
            foreach (var entry in furnituresInfos)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            furnituresInfos = new Types.HavenBagFurnitureInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 furnituresInfos[i] = new Types.HavenBagFurnitureInformation();
                 furnituresInfos[i].Deserialize(reader);
            }
            

}


}


}