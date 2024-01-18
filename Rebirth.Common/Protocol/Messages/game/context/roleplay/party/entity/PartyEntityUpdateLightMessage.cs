


















// Generated on 01/30/2023 13:09:19
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PartyEntityUpdateLightMessage : PartyUpdateLightMessage
{

public const uint Id = 985;
public uint MessageId
{
    get { return Id; }
}

public sbyte indexId;
        

public PartyEntityUpdateLightMessage()
{
}

public PartyEntityUpdateLightMessage(uint partyId, double id, uint lifePoints, uint maxLifePoints, uint prospecting, byte regenRate, sbyte indexId)
         : base(partyId, id, lifePoints, maxLifePoints, prospecting, regenRate)
        {
            this.indexId = indexId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(indexId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            indexId = reader.ReadSbyte();
            

}


}


}