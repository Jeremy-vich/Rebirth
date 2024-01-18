


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayPlayerFightRequestMessage : NetworkMessage
{

public const uint Id = 8139;
public uint MessageId
{
    get { return Id; }
}

public double targetId;
        public short targetCellId;
        public bool friendly;
        

public GameRolePlayPlayerFightRequestMessage()
{
}

public GameRolePlayPlayerFightRequestMessage(double targetId, short targetCellId, bool friendly)
        {
            this.targetId = targetId;
            this.targetCellId = targetCellId;
            this.friendly = friendly;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(targetId);
            writer.WriteShort(targetCellId);
            writer.WriteBoolean(friendly);
            

}

public void Deserialize(IDataReader reader)
{

targetId = reader.ReadVarUhLong();
            targetCellId = reader.ReadShort();
            friendly = reader.ReadBoolean();
            

}


}


}