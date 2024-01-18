


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ObjectAddedMessage : NetworkMessage
{

public const uint Id = 3844;
public uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem @object;
        public sbyte origin;
        

public ObjectAddedMessage()
{
}

public ObjectAddedMessage(Types.ObjectItem @object, sbyte origin)
        {
            this.@object = @object;
            this.origin = origin;
        }
        

public void Serialize(IDataWriter writer)
{

@object.Serialize(writer);
            writer.WriteSbyte(origin);
            

}

public void Deserialize(IDataReader reader)
{

@object = new Types.ObjectItem();
            @object.Deserialize(reader);
            origin = reader.ReadSbyte();
            

}


}


}