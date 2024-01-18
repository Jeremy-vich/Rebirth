


















// Generated on 01/30/2023 13:09:12
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameMapChangeOrientationRequestMessage : NetworkMessage
{

public const uint Id = 5516;
public uint MessageId
{
    get { return Id; }
}

public sbyte direction;
        

public GameMapChangeOrientationRequestMessage()
{
}

public GameMapChangeOrientationRequestMessage(sbyte direction)
        {
            this.direction = direction;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(direction);
            

}

public void Deserialize(IDataReader reader)
{

direction = reader.ReadSbyte();
            

}


}


}