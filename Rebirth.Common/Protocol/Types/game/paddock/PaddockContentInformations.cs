


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class PaddockContentInformations : PaddockInformations
{

public const short Id = 9501;
public override short TypeId
{
    get { return Id; }
}

public double paddockId;
        public short worldX;
        public short worldY;
        public double mapId;
        public uint subAreaId;
        public bool abandonned;
        public Types.MountInformationsForPaddock[] mountsInformations;
        

public PaddockContentInformations()
{
}

public PaddockContentInformations(uint maxOutdoorMount, uint maxItems, double paddockId, short worldX, short worldY, double mapId, uint subAreaId, bool abandonned, Types.MountInformationsForPaddock[] mountsInformations)
         : base(maxOutdoorMount, maxItems)
        {
            this.paddockId = paddockId;
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
            this.abandonned = abandonned;
            this.mountsInformations = mountsInformations;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(paddockId);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteDouble(mapId);
            writer.WriteVarShort((int)subAreaId);
            writer.WriteBoolean(abandonned);
            writer.WriteShort((short)mountsInformations.Length);
            foreach (var entry in mountsInformations)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            paddockId = reader.ReadDouble();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            mapId = reader.ReadDouble();
            subAreaId = reader.ReadVarUhShort();
            abandonned = reader.ReadBoolean();
            var limit = (ushort)reader.ReadUShort();
            mountsInformations = new Types.MountInformationsForPaddock[limit];
            for (int i = 0; i < limit; i++)
            {
                 mountsInformations[i] = new Types.MountInformationsForPaddock();
                 mountsInformations[i].Deserialize(reader);
            }
            

}


}


}