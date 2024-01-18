


















// Generated on 01/30/2023 13:09:11
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class UpdateLifePointsMessage : NetworkMessage
{

public const uint Id = 6350;
public uint MessageId
{
    get { return Id; }
}

public uint lifePoints;
        public uint maxLifePoints;
        

public UpdateLifePointsMessage()
{
}

public UpdateLifePointsMessage(uint lifePoints, uint maxLifePoints)
        {
            this.lifePoints = lifePoints;
            this.maxLifePoints = maxLifePoints;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)lifePoints);
            writer.WriteVarInt((int)maxLifePoints);
            

}

public void Deserialize(IDataReader reader)
{

lifePoints = reader.ReadVarUhInt();
            maxLifePoints = reader.ReadVarUhInt();
            

}


}


}