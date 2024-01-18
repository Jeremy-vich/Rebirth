


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameContextBasicSpawnInformation
{

public const short Id = 9317;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte teamId;
        public bool alive;
        public Types.GameContextActorPositionInformations informations;
        

public GameContextBasicSpawnInformation()
{
}

public GameContextBasicSpawnInformation(sbyte teamId, bool alive, Types.GameContextActorPositionInformations informations)
        {
            this.teamId = teamId;
            this.alive = alive;
            this.informations = informations;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSbyte(teamId);
            writer.WriteBoolean(alive);
            writer.WriteShort(informations.TypeId);
            informations.Serialize(writer);
            

}

public virtual void Deserialize(IDataReader reader)
{

teamId = reader.ReadSbyte();
            alive = reader.ReadBoolean();
            informations = ProtocolTypeManager.GetInstance<Types.GameContextActorPositionInformations>(reader.ReadUShort());
            informations.Deserialize(reader);
            

}


}


}