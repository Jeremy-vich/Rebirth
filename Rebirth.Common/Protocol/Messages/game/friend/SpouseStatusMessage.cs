


















// Generated on 01/30/2023 13:09:20
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class SpouseStatusMessage : NetworkMessage
{

public const uint Id = 1835;
public uint MessageId
{
    get { return Id; }
}

public bool hasSpouse;
        

public SpouseStatusMessage()
{
}

public SpouseStatusMessage(bool hasSpouse)
        {
            this.hasSpouse = hasSpouse;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(hasSpouse);
            

}

public void Deserialize(IDataReader reader)
{

hasSpouse = reader.ReadBoolean();
            

}


}


}