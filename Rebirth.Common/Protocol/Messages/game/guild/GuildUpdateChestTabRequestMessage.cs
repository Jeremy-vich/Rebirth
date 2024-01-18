


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildUpdateChestTabRequestMessage : NetworkMessage
{

public const uint Id = 5668;
public uint MessageId
{
    get { return Id; }
}

public Types.UpdatedStorageTabInformation tab;
        

public GuildUpdateChestTabRequestMessage()
{
}

public GuildUpdateChestTabRequestMessage(Types.UpdatedStorageTabInformation tab)
        {
            this.tab = tab;
        }
        

public void Serialize(IDataWriter writer)
{

tab.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

tab = new Types.UpdatedStorageTabInformation();
            tab.Deserialize(reader);
            

}


}


}