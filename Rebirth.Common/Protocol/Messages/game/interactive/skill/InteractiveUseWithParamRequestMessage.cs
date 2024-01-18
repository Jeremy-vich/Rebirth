


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class InteractiveUseWithParamRequestMessage : InteractiveUseRequestMessage
{

public const uint Id = 9538;
public uint MessageId
{
    get { return Id; }
}

public int id;
        

public InteractiveUseWithParamRequestMessage()
{
}

public InteractiveUseWithParamRequestMessage(uint elemId, uint skillInstanceUid, int id)
         : base(elemId, skillInstanceUid)
        {
            this.id = id;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(id);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            id = reader.ReadInt();
            

}


}


}