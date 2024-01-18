


















// Generated on 01/30/2023 13:09:29
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ContactLookRequestMessage : NetworkMessage
{

public const uint Id = 2275;
public uint MessageId
{
    get { return Id; }
}

public byte requestId;
        public sbyte contactType;
        

public ContactLookRequestMessage()
{
}

public ContactLookRequestMessage(byte requestId, sbyte contactType)
        {
            this.requestId = requestId;
            this.contactType = contactType;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteByte(requestId);
            writer.WriteSbyte(contactType);
            

}

public void Deserialize(IDataReader reader)
{

requestId = reader.ReadByte();
            contactType = reader.ReadSbyte();
            

}


}


}