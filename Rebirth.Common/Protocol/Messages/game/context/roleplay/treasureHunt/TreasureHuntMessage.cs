


















// Generated on 01/30/2023 13:09:20
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class TreasureHuntMessage : NetworkMessage
{

public const uint Id = 8209;
public uint MessageId
{
    get { return Id; }
}

public sbyte questType;
        public double startMapId;
        public Types.TreasureHuntStep[] knownStepsList;
        public sbyte totalStepCount;
        public uint checkPointCurrent;
        public uint checkPointTotal;
        public int availableRetryCount;
        public Types.TreasureHuntFlag[] flags;
        

public TreasureHuntMessage()
{
}

public TreasureHuntMessage(sbyte questType, double startMapId, Types.TreasureHuntStep[] knownStepsList, sbyte totalStepCount, uint checkPointCurrent, uint checkPointTotal, int availableRetryCount, Types.TreasureHuntFlag[] flags)
        {
            this.questType = questType;
            this.startMapId = startMapId;
            this.knownStepsList = knownStepsList;
            this.totalStepCount = totalStepCount;
            this.checkPointCurrent = checkPointCurrent;
            this.checkPointTotal = checkPointTotal;
            this.availableRetryCount = availableRetryCount;
            this.flags = flags;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(questType);
            writer.WriteDouble(startMapId);
            writer.WriteShort((short)knownStepsList.Length);
            foreach (var entry in knownStepsList)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteSbyte(totalStepCount);
            writer.WriteVarInt((int)checkPointCurrent);
            writer.WriteVarInt((int)checkPointTotal);
            writer.WriteInt(availableRetryCount);
            writer.WriteShort((short)flags.Length);
            foreach (var entry in flags)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

questType = reader.ReadSbyte();
            startMapId = reader.ReadDouble();
            var limit = (ushort)reader.ReadUShort();
            knownStepsList = new Types.TreasureHuntStep[limit];
            for (int i = 0; i < limit; i++)
            {
                 knownStepsList[i] = ProtocolTypeManager.GetInstance<Types.TreasureHuntStep>(reader.ReadUShort());
                 knownStepsList[i].Deserialize(reader);
            }
            totalStepCount = reader.ReadSbyte();
            checkPointCurrent = reader.ReadVarUhInt();
            checkPointTotal = reader.ReadVarUhInt();
            availableRetryCount = reader.ReadInt();
            limit = (ushort)reader.ReadUShort();
            flags = new Types.TreasureHuntFlag[limit];
            for (int i = 0; i < limit; i++)
            {
                 flags[i] = new Types.TreasureHuntFlag();
                 flags[i].Deserialize(reader);
            }
            

}


}


}