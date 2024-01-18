


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayShowActorWithEventMessage : GameRolePlayShowActorMessage
{

public const uint Id = 9569;
public uint MessageId
{
    get { return Id; }
}

public sbyte actorEventId;
        

public GameRolePlayShowActorWithEventMessage()
{
}

public GameRolePlayShowActorWithEventMessage(Types.GameRolePlayActorInformations informations, sbyte actorEventId)
         : base(informations)
        {
            this.actorEventId = actorEventId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(actorEventId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            actorEventId = reader.ReadSbyte();
            

}


}


}