


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BreachKickResponseMessage : NetworkMessage
{

public const uint Id = 4950;
public uint MessageId
{
    get { return Id; }
}

public Types.CharacterMinimalInformations target;
        public bool kicked;
        

public BreachKickResponseMessage()
{
}

public BreachKickResponseMessage(Types.CharacterMinimalInformations target, bool kicked)
        {
            this.target = target;
            this.kicked = kicked;
        }
        

public void Serialize(IDataWriter writer)
{

target.Serialize(writer);
            writer.WriteBoolean(kicked);
            

}

public void Deserialize(IDataReader reader)
{

target = new Types.CharacterMinimalInformations();
            target.Deserialize(reader);
            kicked = reader.ReadBoolean();
            

}


}


}