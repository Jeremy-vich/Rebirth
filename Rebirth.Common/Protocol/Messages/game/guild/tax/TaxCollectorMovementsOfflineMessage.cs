


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class TaxCollectorMovementsOfflineMessage : NetworkMessage
{

public const uint Id = 7174;
public uint MessageId
{
    get { return Id; }
}

public Types.TaxCollectorMovement[] movements;
        

public TaxCollectorMovementsOfflineMessage()
{
}

public TaxCollectorMovementsOfflineMessage(Types.TaxCollectorMovement[] movements)
        {
            this.movements = movements;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)movements.Length);
            foreach (var entry in movements)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            movements = new Types.TaxCollectorMovement[limit];
            for (int i = 0; i < limit; i++)
            {
                 movements[i] = new Types.TaxCollectorMovement();
                 movements[i].Deserialize(reader);
            }
            

}


}


}