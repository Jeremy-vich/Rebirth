


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class CurrentMapInstanceMessage : CurrentMapMessage
{

public const uint Id = 4457;
public uint MessageId
{
    get { return Id; }
}

public double instantiatedMapId;
        

public CurrentMapInstanceMessage()
{
}

public CurrentMapInstanceMessage(double mapId, double instantiatedMapId)
         : base(mapId)
        {
            this.instantiatedMapId = instantiatedMapId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(instantiatedMapId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            instantiatedMapId = reader.ReadDouble();
            

}


}


}