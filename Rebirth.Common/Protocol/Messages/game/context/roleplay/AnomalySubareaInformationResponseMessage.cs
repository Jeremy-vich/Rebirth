


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AnomalySubareaInformationResponseMessage : NetworkMessage
{

public const uint Id = 8160;
public uint MessageId
{
    get { return Id; }
}

public Types.AnomalySubareaInformation[] subareas;
        

public AnomalySubareaInformationResponseMessage()
{
}

public AnomalySubareaInformationResponseMessage(Types.AnomalySubareaInformation[] subareas)
        {
            this.subareas = subareas;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)subareas.Length);
            foreach (var entry in subareas)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            subareas = new Types.AnomalySubareaInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 subareas[i] = new Types.AnomalySubareaInformation();
                 subareas[i].Deserialize(reader);
            }
            

}


}


}