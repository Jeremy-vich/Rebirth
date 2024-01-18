


















// Generated on 01/30/2023 13:09:12
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameContextRefreshEntityLookMessage : NetworkMessage
{

public const uint Id = 3848;
public uint MessageId
{
    get { return Id; }
}

public double id;
        public Types.EntityLook look;
        

public GameContextRefreshEntityLookMessage()
{
}

public GameContextRefreshEntityLookMessage(double id, Types.EntityLook look)
        {
            this.id = id;
            this.look = look;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(id);
            look.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

id = reader.ReadDouble();
            look = new Types.EntityLook();
            look.Deserialize(reader);
            

}


}


}