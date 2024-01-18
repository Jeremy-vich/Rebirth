


















// Generated on 01/30/2023 13:09:12
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameContextRemoveMultipleElementsMessage : NetworkMessage
{

public const uint Id = 3246;
public uint MessageId
{
    get { return Id; }
}

public double[] elementsIds;
        

public GameContextRemoveMultipleElementsMessage()
{
}

public GameContextRemoveMultipleElementsMessage(double[] elementsIds)
        {
            this.elementsIds = elementsIds;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)elementsIds.Length);
            foreach (var entry in elementsIds)
            {
                 writer.WriteDouble(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            elementsIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 elementsIds[i] = reader.ReadDouble();
            }
            

}


}


}