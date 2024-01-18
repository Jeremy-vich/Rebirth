


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeBidHouseBuyResultMessage : NetworkMessage
{

public const uint Id = 5746;
public uint MessageId
{
    get { return Id; }
}

public uint uid;
        public bool bought;
        

public ExchangeBidHouseBuyResultMessage()
{
}

public ExchangeBidHouseBuyResultMessage(uint uid, bool bought)
        {
            this.uid = uid;
            this.bought = bought;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)uid);
            writer.WriteBoolean(bought);
            

}

public void Deserialize(IDataReader reader)
{

uid = reader.ReadVarUhInt();
            bought = reader.ReadBoolean();
            

}


}


}