


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class HousePropertiesMessage : NetworkMessage
{

public const uint Id = 4311;
public uint MessageId
{
    get { return Id; }
}

public uint houseId;
        public int[] doorsOnMap;
        public Types.HouseInstanceInformations properties;
        

public HousePropertiesMessage()
{
}

public HousePropertiesMessage(uint houseId, int[] doorsOnMap, Types.HouseInstanceInformations properties)
        {
            this.houseId = houseId;
            this.doorsOnMap = doorsOnMap;
            this.properties = properties;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)houseId);
            writer.WriteShort((short)doorsOnMap.Length);
            foreach (var entry in doorsOnMap)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteShort(properties.TypeId);
            properties.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

houseId = reader.ReadVarUhInt();
            var limit = (ushort)reader.ReadUShort();
            doorsOnMap = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 doorsOnMap[i] = reader.ReadInt();
            }
            properties = ProtocolTypeManager.GetInstance<Types.HouseInstanceInformations>(reader.ReadUShort());
            properties.Deserialize(reader);
            

}


}


}