


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class TaxCollectorAttackedMessage : NetworkMessage
{

public const uint Id = 9963;
public uint MessageId
{
    get { return Id; }
}

public uint firstNameId;
        public uint lastNameId;
        public short worldX;
        public short worldY;
        public double mapId;
        public uint subAreaId;
        public Types.BasicGuildInformations guild;
        

public TaxCollectorAttackedMessage()
{
}

public TaxCollectorAttackedMessage(uint firstNameId, uint lastNameId, short worldX, short worldY, double mapId, uint subAreaId, Types.BasicGuildInformations guild)
        {
            this.firstNameId = firstNameId;
            this.lastNameId = lastNameId;
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
            this.guild = guild;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)firstNameId);
            writer.WriteVarShort((int)lastNameId);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteDouble(mapId);
            writer.WriteVarShort((int)subAreaId);
            guild.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

firstNameId = reader.ReadVarUhShort();
            lastNameId = reader.ReadVarUhShort();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            mapId = reader.ReadDouble();
            subAreaId = reader.ReadVarUhShort();
            guild = new Types.BasicGuildInformations();
            guild.Deserialize(reader);
            

}


}


}