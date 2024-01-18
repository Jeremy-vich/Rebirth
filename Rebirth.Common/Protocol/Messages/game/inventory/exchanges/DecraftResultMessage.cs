


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class DecraftResultMessage : NetworkMessage
{

public const uint Id = 5645;
public uint MessageId
{
    get { return Id; }
}

public Types.DecraftedItemStackInfo[] results;
        

public DecraftResultMessage()
{
}

public DecraftResultMessage(Types.DecraftedItemStackInfo[] results)
        {
            this.results = results;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)results.Length);
            foreach (var entry in results)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            results = new Types.DecraftedItemStackInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 results[i] = new Types.DecraftedItemStackInfo();
                 results[i].Deserialize(reader);
            }
            

}


}


}