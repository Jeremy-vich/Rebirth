


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class PrismGeolocalizedInformation : PrismSubareaEmptyInfo
{

public const short Id = 8423;
public override short TypeId
{
    get { return Id; }
}

public short worldX;
        public short worldY;
        public double mapId;
        public Types.PrismInformation prism;
        

public PrismGeolocalizedInformation()
{
}

public PrismGeolocalizedInformation(uint subAreaId, uint allianceId, short worldX, short worldY, double mapId, Types.PrismInformation prism)
         : base(subAreaId, allianceId)
        {
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.prism = prism;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteDouble(mapId);
            writer.WriteShort(prism.TypeId);
            prism.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            mapId = reader.ReadDouble();
            prism = ProtocolTypeManager.GetInstance<Types.PrismInformation>(reader.ReadUShort());
            prism.Deserialize(reader);
            

}


}


}