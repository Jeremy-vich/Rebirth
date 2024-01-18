


















// Generated on 01/30/2023 13:09:29
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class HaapiCancelBidRequestMessage : NetworkMessage
{

public const uint Id = 4878;
public uint MessageId
{
    get { return Id; }
}

public double id;
        public sbyte type;
        

public HaapiCancelBidRequestMessage()
{
}

public HaapiCancelBidRequestMessage(double id, sbyte type)
        {
            this.id = id;
            this.type = type;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(id);
            writer.WriteSbyte(type);
            

}

public void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhLong();
            type = reader.ReadSbyte();
            

}


}


}