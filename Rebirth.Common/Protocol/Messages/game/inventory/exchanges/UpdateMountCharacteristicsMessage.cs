


















// Generated on 01/30/2023 13:09:26
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class UpdateMountCharacteristicsMessage : NetworkMessage
{

public const uint Id = 6180;
public uint MessageId
{
    get { return Id; }
}

public int rideId;
        public Types.UpdateMountCharacteristic[] boostToUpdateList;
        

public UpdateMountCharacteristicsMessage()
{
}

public UpdateMountCharacteristicsMessage(int rideId, Types.UpdateMountCharacteristic[] boostToUpdateList)
        {
            this.rideId = rideId;
            this.boostToUpdateList = boostToUpdateList;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)rideId);
            writer.WriteShort((short)boostToUpdateList.Length);
            foreach (var entry in boostToUpdateList)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

rideId = reader.ReadVarInt();
            var limit = (ushort)reader.ReadUShort();
            boostToUpdateList = new Types.UpdateMountCharacteristic[limit];
            for (int i = 0; i < limit; i++)
            {
                 boostToUpdateList[i] = ProtocolTypeManager.GetInstance<Types.UpdateMountCharacteristic>(reader.ReadUShort());
                 boostToUpdateList[i].Deserialize(reader);
            }
            

}


}


}