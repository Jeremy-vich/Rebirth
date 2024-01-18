


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class MultiTabStorageMessage : NetworkMessage
{

public const uint Id = 3832;
public uint MessageId
{
    get { return Id; }
}

public Types.StorageTabInformation[] tabs;
        

public MultiTabStorageMessage()
{
}

public MultiTabStorageMessage(Types.StorageTabInformation[] tabs)
        {
            this.tabs = tabs;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)tabs.Length);
            foreach (var entry in tabs)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            tabs = new Types.StorageTabInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 tabs[i] = new Types.StorageTabInformation();
                 tabs[i].Deserialize(reader);
            }
            

}


}


}