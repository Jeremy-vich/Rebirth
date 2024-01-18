


















// Generated on 01/30/2023 13:09:20
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AcquaintancesListMessage : NetworkMessage
{

public const uint Id = 6359;
public uint MessageId
{
    get { return Id; }
}

public Types.AcquaintanceInformation[] acquaintanceList;
        

public AcquaintancesListMessage()
{
}

public AcquaintancesListMessage(Types.AcquaintanceInformation[] acquaintanceList)
        {
            this.acquaintanceList = acquaintanceList;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)acquaintanceList.Length);
            foreach (var entry in acquaintanceList)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            acquaintanceList = new Types.AcquaintanceInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 acquaintanceList[i] = ProtocolTypeManager.GetInstance<Types.AcquaintanceInformation>(reader.ReadUShort());
                 acquaintanceList[i].Deserialize(reader);
            }
            

}


}


}