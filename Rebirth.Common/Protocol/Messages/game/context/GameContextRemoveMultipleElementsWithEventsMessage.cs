


















// Generated on 01/30/2023 13:09:12
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameContextRemoveMultipleElementsWithEventsMessage : GameContextRemoveMultipleElementsMessage
{

public const uint Id = 885;
public uint MessageId
{
    get { return Id; }
}

public sbyte[] elementEventIds;
        

public GameContextRemoveMultipleElementsWithEventsMessage()
{
}

public GameContextRemoveMultipleElementsWithEventsMessage(double[] elementsIds, sbyte[] elementEventIds)
         : base(elementsIds)
        {
            this.elementEventIds = elementEventIds;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)(ushort)elementEventIds.Length);
            foreach (var entry in elementEventIds)
            {
                 writer.WriteSbyte(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadVarInt();
            elementEventIds = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 elementEventIds[i] = reader.ReadSbyte();
            }
            

}


}


}