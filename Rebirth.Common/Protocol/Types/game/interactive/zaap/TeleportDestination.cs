


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class TeleportDestination
{

public const short Id = 9417;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte type;
        public double mapId;
        public uint subAreaId;
        public uint level;
        public uint cost;
        

public TeleportDestination()
{
}

public TeleportDestination(sbyte type, double mapId, uint subAreaId, uint level, uint cost)
        {
            this.type = type;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
            this.level = level;
            this.cost = cost;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSbyte(type);
            writer.WriteDouble(mapId);
            writer.WriteVarShort((int)subAreaId);
            writer.WriteVarShort((int)level);
            writer.WriteVarShort((int)cost);
            

}

public virtual void Deserialize(IDataReader reader)
{

type = reader.ReadSbyte();
            mapId = reader.ReadDouble();
            subAreaId = reader.ReadVarUhShort();
            level = reader.ReadVarUhShort();
            cost = reader.ReadVarUhShort();
            

}


}


}