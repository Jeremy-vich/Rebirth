


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameFightFighterEntityLightInformation : GameFightFighterLightInformations
{

public const short Id = 9520;
public override short TypeId
{
    get { return Id; }
}

public sbyte entityModelId;
        public double masterId;
        

public GameFightFighterEntityLightInformation()
{
}

public GameFightFighterEntityLightInformation(bool sex, bool alive, double id, sbyte wave, uint level, sbyte breed, sbyte entityModelId, double masterId)
         : base(sex, alive, id, wave, level, breed)
        {
            this.entityModelId = entityModelId;
            this.masterId = masterId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(entityModelId);
            writer.WriteDouble(masterId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            entityModelId = reader.ReadSbyte();
            masterId = reader.ReadDouble();
            

}


}


}