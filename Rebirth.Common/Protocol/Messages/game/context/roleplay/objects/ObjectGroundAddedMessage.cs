


















// Generated on 01/30/2023 13:09:17
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ObjectGroundAddedMessage : NetworkMessage
{

public const uint Id = 6422;
public uint MessageId
{
    get { return Id; }
}

public uint cellId;
        public uint objectGID;
        

public ObjectGroundAddedMessage()
{
}

public ObjectGroundAddedMessage(uint cellId, uint objectGID)
        {
            this.cellId = cellId;
            this.objectGID = objectGID;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)cellId);
            writer.WriteVarInt((int)objectGID);
            

}

public void Deserialize(IDataReader reader)
{

cellId = reader.ReadVarUhShort();
            objectGID = reader.ReadVarUhInt();
            

}


}


}