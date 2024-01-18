


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class MountInformationRequestMessage : NetworkMessage
{

public const uint Id = 9546;
public uint MessageId
{
    get { return Id; }
}

public double id;
        public double time;
        

public MountInformationRequestMessage()
{
}

public MountInformationRequestMessage(double id, double time)
        {
            this.id = id;
            this.time = time;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(id);
            writer.WriteDouble(time);
            

}

public void Deserialize(IDataReader reader)
{

id = reader.ReadDouble();
            time = reader.ReadDouble();
            

}


}


}