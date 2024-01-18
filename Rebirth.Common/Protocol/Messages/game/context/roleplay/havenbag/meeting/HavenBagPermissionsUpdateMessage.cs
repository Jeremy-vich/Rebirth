


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class HavenBagPermissionsUpdateMessage : NetworkMessage
{

public const uint Id = 4297;
public uint MessageId
{
    get { return Id; }
}

public int permissions;
        

public HavenBagPermissionsUpdateMessage()
{
}

public HavenBagPermissionsUpdateMessage(int permissions)
        {
            this.permissions = permissions;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(permissions);
            

}

public void Deserialize(IDataReader reader)
{

permissions = reader.ReadInt();
            

}


}


}