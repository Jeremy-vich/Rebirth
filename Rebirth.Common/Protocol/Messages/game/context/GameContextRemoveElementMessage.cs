


















// Generated on 01/30/2023 13:09:12
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameContextRemoveElementMessage : NetworkMessage
{

public const uint Id = 2866;
public uint MessageId
{
    get { return Id; }
}

public double id;
        

public GameContextRemoveElementMessage()
{
}

public GameContextRemoveElementMessage(double id)
        {
            this.id = id;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(id);
            

}

public void Deserialize(IDataReader reader)
{

id = reader.ReadDouble();
            

}


}


}