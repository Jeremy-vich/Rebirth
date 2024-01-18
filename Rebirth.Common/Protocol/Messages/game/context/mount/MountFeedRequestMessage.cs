


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class MountFeedRequestMessage : NetworkMessage
{

public const uint Id = 6428;
public uint MessageId
{
    get { return Id; }
}

public uint mountUid;
        public sbyte mountLocation;
        public uint mountFoodUid;
        public uint quantity;
        

public MountFeedRequestMessage()
{
}

public MountFeedRequestMessage(uint mountUid, sbyte mountLocation, uint mountFoodUid, uint quantity)
        {
            this.mountUid = mountUid;
            this.mountLocation = mountLocation;
            this.mountFoodUid = mountFoodUid;
            this.quantity = quantity;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)mountUid);
            writer.WriteSbyte(mountLocation);
            writer.WriteVarInt((int)mountFoodUid);
            writer.WriteVarInt((int)quantity);
            

}

public void Deserialize(IDataReader reader)
{

mountUid = reader.ReadVarUhInt();
            mountLocation = reader.ReadSbyte();
            mountFoodUid = reader.ReadVarUhInt();
            quantity = reader.ReadVarUhInt();
            

}


}


}