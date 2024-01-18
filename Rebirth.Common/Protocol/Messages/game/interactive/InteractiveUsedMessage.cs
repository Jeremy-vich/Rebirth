


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class InteractiveUsedMessage : NetworkMessage
{

public const uint Id = 4286;
public uint MessageId
{
    get { return Id; }
}

public double entityId;
        public uint elemId;
        public uint skillId;
        public uint duration;
        public bool canMove;
        

public InteractiveUsedMessage()
{
}

public InteractiveUsedMessage(double entityId, uint elemId, uint skillId, uint duration, bool canMove)
        {
            this.entityId = entityId;
            this.elemId = elemId;
            this.skillId = skillId;
            this.duration = duration;
            this.canMove = canMove;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(entityId);
            writer.WriteVarInt((int)elemId);
            writer.WriteVarShort((int)skillId);
            writer.WriteVarShort((int)duration);
            writer.WriteBoolean(canMove);
            

}

public void Deserialize(IDataReader reader)
{

entityId = reader.ReadVarUhLong();
            elemId = reader.ReadVarUhInt();
            skillId = reader.ReadVarUhShort();
            duration = reader.ReadVarUhShort();
            canMove = reader.ReadBoolean();
            

}


}


}