


















// Generated on 01/30/2023 13:09:24
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeBidHouseTypeMessage : NetworkMessage
{

public const uint Id = 2561;
public uint MessageId
{
    get { return Id; }
}

public uint type;
        public bool follow;
        

public ExchangeBidHouseTypeMessage()
{
}

public ExchangeBidHouseTypeMessage(uint type, bool follow)
        {
            this.type = type;
            this.follow = follow;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)type);
            writer.WriteBoolean(follow);
            

}

public void Deserialize(IDataReader reader)
{

type = reader.ReadVarUhInt();
            follow = reader.ReadBoolean();
            

}


}


}