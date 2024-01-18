


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BreachBonusMessage : NetworkMessage
{

public const uint Id = 4510;
public uint MessageId
{
    get { return Id; }
}

public Types.ObjectEffectInteger bonus;
        

public BreachBonusMessage()
{
}

public BreachBonusMessage(Types.ObjectEffectInteger bonus)
        {
            this.bonus = bonus;
        }
        

public void Serialize(IDataWriter writer)
{

bonus.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

bonus = new Types.ObjectEffectInteger();
            bonus.Deserialize(reader);
            

}


}


}