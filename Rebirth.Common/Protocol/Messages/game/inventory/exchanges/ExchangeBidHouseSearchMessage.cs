


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeBidHouseSearchMessage : NetworkMessage
{

public const uint Id = 7962;
public uint MessageId
{
    get { return Id; }
}

public uint objectGID;
        public bool follow;
        

public ExchangeBidHouseSearchMessage()
{
}

public ExchangeBidHouseSearchMessage(uint objectGID, bool follow)
        {
            this.objectGID = objectGID;
            this.follow = follow;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectGID);
            writer.WriteBoolean(follow);
            

}

public void Deserialize(IDataReader reader)
{

objectGID = reader.ReadVarUhInt();
            follow = reader.ReadBoolean();
            

}


}


}