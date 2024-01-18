


















// Generated on 01/30/2023 13:09:17
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PaddockPropertiesMessage : NetworkMessage
{

public const uint Id = 6829;
public uint MessageId
{
    get { return Id; }
}

public Types.PaddockInstancesInformations properties;
        

public PaddockPropertiesMessage()
{
}

public PaddockPropertiesMessage(Types.PaddockInstancesInformations properties)
        {
            this.properties = properties;
        }
        

public void Serialize(IDataWriter writer)
{

properties.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

properties = new Types.PaddockInstancesInformations();
            properties.Deserialize(reader);
            

}


}


}