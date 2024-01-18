


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildSelectChestTabRequestMessage : NetworkMessage
{

public const uint Id = 2236;
public uint MessageId
{
    get { return Id; }
}

public uint tabNumber;
        

public GuildSelectChestTabRequestMessage()
{
}

public GuildSelectChestTabRequestMessage(uint tabNumber)
        {
            this.tabNumber = tabNumber;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)tabNumber);
            

}

public void Deserialize(IDataReader reader)
{

tabNumber = reader.ReadVarUhInt();
            

}


}


}