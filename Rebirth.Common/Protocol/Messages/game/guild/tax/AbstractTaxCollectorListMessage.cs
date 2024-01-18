


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AbstractTaxCollectorListMessage : NetworkMessage
{

public const uint Id = 5610;
public uint MessageId
{
    get { return Id; }
}

public Types.TaxCollectorInformations[] informations;
        

public AbstractTaxCollectorListMessage()
{
}

public AbstractTaxCollectorListMessage(Types.TaxCollectorInformations[] informations)
        {
            this.informations = informations;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)informations.Length);
            foreach (var entry in informations)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            informations = new Types.TaxCollectorInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 informations[i] = ProtocolTypeManager.GetInstance<Types.TaxCollectorInformations>(reader.ReadUShort());
                 informations[i].Deserialize(reader);
            }
            

}


}


}