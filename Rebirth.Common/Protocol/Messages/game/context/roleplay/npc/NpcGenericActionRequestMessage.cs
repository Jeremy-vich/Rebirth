


















// Generated on 01/30/2023 13:09:17
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class NpcGenericActionRequestMessage : NetworkMessage
{

public const uint Id = 8628;
public uint MessageId
{
    get { return Id; }
}

public int npcId;
        public sbyte npcActionId;
        public double npcMapId;
        

public NpcGenericActionRequestMessage()
{
}

public NpcGenericActionRequestMessage(int npcId, sbyte npcActionId, double npcMapId)
        {
            this.npcId = npcId;
            this.npcActionId = npcActionId;
            this.npcMapId = npcMapId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(npcId);
            writer.WriteSbyte(npcActionId);
            writer.WriteDouble(npcMapId);
            

}

public void Deserialize(IDataReader reader)
{

npcId = reader.ReadInt();
            npcActionId = reader.ReadSbyte();
            npcMapId = reader.ReadDouble();
            

}


}


}