


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class LifePointsRegenBeginMessage : NetworkMessage
{

public const uint Id = 5704;
public uint MessageId
{
    get { return Id; }
}

public byte regenRate;
        

public LifePointsRegenBeginMessage()
{
}

public LifePointsRegenBeginMessage(byte regenRate)
        {
            this.regenRate = regenRate;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteByte(regenRate);
            

}

public void Deserialize(IDataReader reader)
{

regenRate = reader.ReadByte();
            

}


}


}