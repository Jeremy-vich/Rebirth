


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PrismFightStateUpdateMessage : NetworkMessage
{

public const uint Id = 7030;
public uint MessageId
{
    get { return Id; }
}

public sbyte state;
        

public PrismFightStateUpdateMessage()
{
}

public PrismFightStateUpdateMessage(sbyte state)
        {
            this.state = state;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(state);
            

}

public void Deserialize(IDataReader reader)
{

state = reader.ReadSbyte();
            

}


}


}