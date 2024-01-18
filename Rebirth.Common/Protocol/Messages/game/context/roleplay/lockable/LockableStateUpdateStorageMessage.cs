


















// Generated on 01/30/2023 13:09:17
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class LockableStateUpdateStorageMessage : LockableStateUpdateAbstractMessage
{

public const uint Id = 1184;
public uint MessageId
{
    get { return Id; }
}

public double mapId;
        public uint elementId;
        

public LockableStateUpdateStorageMessage()
{
}

public LockableStateUpdateStorageMessage(bool locked, double mapId, uint elementId)
         : base(locked)
        {
            this.mapId = mapId;
            this.elementId = elementId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(mapId);
            writer.WriteVarInt((int)elementId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            mapId = reader.ReadDouble();
            elementId = reader.ReadVarUhInt();
            

}


}


}