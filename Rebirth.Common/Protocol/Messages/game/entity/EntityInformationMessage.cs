


















// Generated on 01/30/2023 13:09:20
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class EntityInformationMessage : NetworkMessage
{

public const uint Id = 9199;
public uint MessageId
{
    get { return Id; }
}

public Types.EntityInformation entity;
        

public EntityInformationMessage()
{
}

public EntityInformationMessage(Types.EntityInformation entity)
        {
            this.entity = entity;
        }
        

public void Serialize(IDataWriter writer)
{

entity.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

entity = new Types.EntityInformation();
            entity.Deserialize(reader);
            

}


}


}