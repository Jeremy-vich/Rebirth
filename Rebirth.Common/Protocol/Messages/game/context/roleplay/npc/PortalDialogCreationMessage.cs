


















// Generated on 01/30/2023 13:09:17
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PortalDialogCreationMessage : NpcDialogCreationMessage
{

public const uint Id = 9706;
public uint MessageId
{
    get { return Id; }
}

public int type;
        

public PortalDialogCreationMessage()
{
}

public PortalDialogCreationMessage(double mapId, int npcId, int type)
         : base(mapId, npcId)
        {
            this.type = type;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(type);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            type = reader.ReadInt();
            

}


}


}