


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PrismsListMessage : NetworkMessage
{

public const uint Id = 8518;
public uint MessageId
{
    get { return Id; }
}

public Types.PrismSubareaEmptyInfo[] prisms;
        

public PrismsListMessage()
{
}

public PrismsListMessage(Types.PrismSubareaEmptyInfo[] prisms)
        {
            this.prisms = prisms;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)prisms.Length);
            foreach (var entry in prisms)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            prisms = new Types.PrismSubareaEmptyInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 prisms[i] = ProtocolTypeManager.GetInstance<Types.PrismSubareaEmptyInfo>(reader.ReadUShort());
                 prisms[i].Deserialize(reader);
            }
            

}


}


}