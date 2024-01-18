


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class RemoveListenerOnSynchronizedStorageMessage : NetworkMessage
{

public const uint Id = 2455;
public uint MessageId
{
    get { return Id; }
}

public string player;
        

public RemoveListenerOnSynchronizedStorageMessage()
{
}

public RemoveListenerOnSynchronizedStorageMessage(string player)
        {
            this.player = player;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(player);
            

}

public void Deserialize(IDataReader reader)
{

player = reader.ReadUTF();
            

}


}


}