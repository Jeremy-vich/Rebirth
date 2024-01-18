


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ChangeMapMessage : NetworkMessage
{

public const uint Id = 7988;
public uint MessageId
{
    get { return Id; }
}

public double mapId;
        public bool autopilot;
        

public ChangeMapMessage()
{
}

public ChangeMapMessage(double mapId, bool autopilot)
        {
            this.mapId = mapId;
            this.autopilot = autopilot;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(mapId);
            writer.WriteBoolean(autopilot);
            

}

public void Deserialize(IDataReader reader)
{

mapId = reader.ReadDouble();
            autopilot = reader.ReadBoolean();
            

}


}


}