


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AlterationsMessage : NetworkMessage
{

public const uint Id = 2960;
public uint MessageId
{
    get { return Id; }
}

public Types.AlterationInfo[] alterations;
        

public AlterationsMessage()
{
}

public AlterationsMessage(Types.AlterationInfo[] alterations)
        {
            this.alterations = alterations;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)alterations.Length);
            foreach (var entry in alterations)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            alterations = new Types.AlterationInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 alterations[i] = new Types.AlterationInfo();
                 alterations[i].Deserialize(reader);
            }
            

}


}


}