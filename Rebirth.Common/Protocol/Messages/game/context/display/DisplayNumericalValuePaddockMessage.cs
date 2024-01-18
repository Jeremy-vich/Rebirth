


















// Generated on 01/30/2023 13:09:12
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class DisplayNumericalValuePaddockMessage : NetworkMessage
{

public const uint Id = 4794;
public uint MessageId
{
    get { return Id; }
}

public int rideId;
        public int value;
        public sbyte type;
        

public DisplayNumericalValuePaddockMessage()
{
}

public DisplayNumericalValuePaddockMessage(int rideId, int value, sbyte type)
        {
            this.rideId = rideId;
            this.value = value;
            this.type = type;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(rideId);
            writer.WriteInt(value);
            writer.WriteSbyte(type);
            

}

public void Deserialize(IDataReader reader)
{

rideId = reader.ReadInt();
            value = reader.ReadInt();
            type = reader.ReadSbyte();
            

}


}


}