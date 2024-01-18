


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AlterationRemovedMessage : NetworkMessage
{

public const uint Id = 6499;
public uint MessageId
{
    get { return Id; }
}

public Types.AlterationInfo alteration;
        

public AlterationRemovedMessage()
{
}

public AlterationRemovedMessage(Types.AlterationInfo alteration)
        {
            this.alteration = alteration;
        }
        

public void Serialize(IDataWriter writer)
{

alteration.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

alteration = new Types.AlterationInfo();
            alteration.Deserialize(reader);
            

}


}


}