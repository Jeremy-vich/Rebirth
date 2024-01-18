


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class InteractiveUseErrorMessage : NetworkMessage
{

public const uint Id = 972;
public uint MessageId
{
    get { return Id; }
}

public uint elemId;
        public uint skillInstanceUid;
        

public InteractiveUseErrorMessage()
{
}

public InteractiveUseErrorMessage(uint elemId, uint skillInstanceUid)
        {
            this.elemId = elemId;
            this.skillInstanceUid = skillInstanceUid;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)elemId);
            writer.WriteVarInt((int)skillInstanceUid);
            

}

public void Deserialize(IDataReader reader)
{

elemId = reader.ReadVarUhInt();
            skillInstanceUid = reader.ReadVarUhInt();
            

}


}


}