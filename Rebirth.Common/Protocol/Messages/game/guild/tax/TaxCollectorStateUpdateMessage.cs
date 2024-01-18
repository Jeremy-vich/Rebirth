


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class TaxCollectorStateUpdateMessage : NetworkMessage
{

public const uint Id = 223;
public uint MessageId
{
    get { return Id; }
}

public double uniqueId;
        public sbyte state;
        

public TaxCollectorStateUpdateMessage()
{
}

public TaxCollectorStateUpdateMessage(double uniqueId, sbyte state)
        {
            this.uniqueId = uniqueId;
            this.state = state;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(uniqueId);
            writer.WriteSbyte(state);
            

}

public void Deserialize(IDataReader reader)
{

uniqueId = reader.ReadDouble();
            state = reader.ReadSbyte();
            

}


}


}