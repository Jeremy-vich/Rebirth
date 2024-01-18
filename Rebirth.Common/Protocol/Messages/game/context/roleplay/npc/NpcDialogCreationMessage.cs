


















// Generated on 01/30/2023 13:09:17
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class NpcDialogCreationMessage : NetworkMessage
{

public const uint Id = 6164;
public uint MessageId
{
    get { return Id; }
}

public double mapId;
        public int npcId;
        

public NpcDialogCreationMessage()
{
}

public NpcDialogCreationMessage(double mapId, int npcId)
        {
            this.mapId = mapId;
            this.npcId = npcId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(mapId);
            writer.WriteInt(npcId);
            

}

public void Deserialize(IDataReader reader)
{

mapId = reader.ReadDouble();
            npcId = reader.ReadInt();
            

}


}


}