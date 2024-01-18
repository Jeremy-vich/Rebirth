


















// Generated on 01/30/2023 13:09:26
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class RecycleResultMessage : NetworkMessage
{

public const uint Id = 9365;
public uint MessageId
{
    get { return Id; }
}

public uint nuggetsForPrism;
        public uint nuggetsForPlayer;
        

public RecycleResultMessage()
{
}

public RecycleResultMessage(uint nuggetsForPrism, uint nuggetsForPlayer)
        {
            this.nuggetsForPrism = nuggetsForPrism;
            this.nuggetsForPlayer = nuggetsForPlayer;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)nuggetsForPrism);
            writer.WriteVarInt((int)nuggetsForPlayer);
            

}

public void Deserialize(IDataReader reader)
{

nuggetsForPrism = reader.ReadVarUhInt();
            nuggetsForPlayer = reader.ReadVarUhInt();
            

}


}


}