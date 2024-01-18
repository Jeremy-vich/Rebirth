


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class CharacterSelectedForceMessage : NetworkMessage
{

public const uint Id = 3433;
public uint MessageId
{
    get { return Id; }
}

public int id;
        

public CharacterSelectedForceMessage()
{
}

public CharacterSelectedForceMessage(int id)
        {
            this.id = id;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(id);
            

}

public void Deserialize(IDataReader reader)
{

id = reader.ReadInt();
            

}


}


}