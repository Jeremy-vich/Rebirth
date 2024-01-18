


















// Generated on 01/30/2023 13:09:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameActionFightCastOnTargetRequestMessage : NetworkMessage
{

public const uint Id = 270;
public uint MessageId
{
    get { return Id; }
}

public uint spellId;
        public double targetId;
        

public GameActionFightCastOnTargetRequestMessage()
{
}

public GameActionFightCastOnTargetRequestMessage(uint spellId, double targetId)
        {
            this.spellId = spellId;
            this.targetId = targetId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)spellId);
            writer.WriteDouble(targetId);
            

}

public void Deserialize(IDataReader reader)
{

spellId = reader.ReadVarUhShort();
            targetId = reader.ReadDouble();
            

}


}


}