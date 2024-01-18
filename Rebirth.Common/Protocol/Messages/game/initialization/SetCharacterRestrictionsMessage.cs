


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class SetCharacterRestrictionsMessage : NetworkMessage
{

public const uint Id = 2997;
public uint MessageId
{
    get { return Id; }
}

public double actorId;
        public Types.ActorRestrictionsInformations restrictions;
        

public SetCharacterRestrictionsMessage()
{
}

public SetCharacterRestrictionsMessage(double actorId, Types.ActorRestrictionsInformations restrictions)
        {
            this.actorId = actorId;
            this.restrictions = restrictions;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(actorId);
            restrictions.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

actorId = reader.ReadDouble();
            restrictions = new Types.ActorRestrictionsInformations();
            restrictions.Deserialize(reader);
            

}


}


}