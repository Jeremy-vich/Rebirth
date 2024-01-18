


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class AllianceInsiderPrismInformation : PrismInformation
{

public const short Id = 5890;
public override short TypeId
{
    get { return Id; }
}

public int lastTimeSlotModificationDate;
        public uint lastTimeSlotModificationAuthorGuildId;
        public double lastTimeSlotModificationAuthorId;
        public string lastTimeSlotModificationAuthorName;
        public Types.ObjectItem[] modulesObjects;
        

public AllianceInsiderPrismInformation()
{
}

public AllianceInsiderPrismInformation(sbyte typeId, sbyte state, int nextVulnerabilityDate, int placementDate, uint rewardTokenCount, int lastTimeSlotModificationDate, uint lastTimeSlotModificationAuthorGuildId, double lastTimeSlotModificationAuthorId, string lastTimeSlotModificationAuthorName, Types.ObjectItem[] modulesObjects)
         : base(typeId, state, nextVulnerabilityDate, placementDate, rewardTokenCount)
        {
            this.lastTimeSlotModificationDate = lastTimeSlotModificationDate;
            this.lastTimeSlotModificationAuthorGuildId = lastTimeSlotModificationAuthorGuildId;
            this.lastTimeSlotModificationAuthorId = lastTimeSlotModificationAuthorId;
            this.lastTimeSlotModificationAuthorName = lastTimeSlotModificationAuthorName;
            this.modulesObjects = modulesObjects;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(lastTimeSlotModificationDate);
            writer.WriteVarInt((int)lastTimeSlotModificationAuthorGuildId);
            writer.WriteVarLong(lastTimeSlotModificationAuthorId);
            writer.WriteUTF(lastTimeSlotModificationAuthorName);
            writer.WriteShort((short)modulesObjects.Length);
            foreach (var entry in modulesObjects)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            lastTimeSlotModificationDate = reader.ReadInt();
            lastTimeSlotModificationAuthorGuildId = reader.ReadVarUhInt();
            lastTimeSlotModificationAuthorId = reader.ReadVarUhLong();
            lastTimeSlotModificationAuthorName = reader.ReadUTF();
            var limit = (ushort)reader.ReadUShort();
            modulesObjects = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 modulesObjects[i] = new Types.ObjectItem();
                 modulesObjects[i].Deserialize(reader);
            }
            

}


}


}