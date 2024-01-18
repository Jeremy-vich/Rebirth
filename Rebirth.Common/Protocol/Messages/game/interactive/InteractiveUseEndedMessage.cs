


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class InteractiveUseEndedMessage : NetworkMessage
{

public const uint Id = 5477;
public uint MessageId
{
    get { return Id; }
}

public uint elemId;
        public uint skillId;
        

public InteractiveUseEndedMessage()
{
}

public InteractiveUseEndedMessage(uint elemId, uint skillId)
        {
            this.elemId = elemId;
            this.skillId = skillId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)elemId);
            writer.WriteVarShort((int)skillId);
            

}

public void Deserialize(IDataReader reader)
{

elemId = reader.ReadVarUhInt();
            skillId = reader.ReadVarUhShort();
            

}


}


}