


















// Generated on 01/30/2023 13:09:12
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightSpectateMessage : NetworkMessage
{

public const uint Id = 8159;
public uint MessageId
{
    get { return Id; }
}

public Types.FightDispellableEffectExtendedInformations[] effects;
        public Types.GameActionMark[] marks;
        public uint gameTurn;
        public int fightStart;
        public Types.Idol[] idols;
        public Types.GameFightEffectTriggerCount[] fxTriggerCounts;
        

public GameFightSpectateMessage()
{
}

public GameFightSpectateMessage(Types.FightDispellableEffectExtendedInformations[] effects, Types.GameActionMark[] marks, uint gameTurn, int fightStart, Types.Idol[] idols, Types.GameFightEffectTriggerCount[] fxTriggerCounts)
        {
            this.effects = effects;
            this.marks = marks;
            this.gameTurn = gameTurn;
            this.fightStart = fightStart;
            this.idols = idols;
            this.fxTriggerCounts = fxTriggerCounts;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)effects.Length);
            foreach (var entry in effects)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)marks.Length);
            foreach (var entry in marks)
            {
                 entry.Serialize(writer);
            }
            writer.WriteVarShort((int)gameTurn);
            writer.WriteInt(fightStart);
            writer.WriteShort((short)idols.Length);
            foreach (var entry in idols)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)fxTriggerCounts.Length);
            foreach (var entry in fxTriggerCounts)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            effects = new Types.FightDispellableEffectExtendedInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 effects[i] = new Types.FightDispellableEffectExtendedInformations();
                 effects[i].Deserialize(reader);
            }
            limit = (ushort)reader.ReadUShort();
            marks = new Types.GameActionMark[limit];
            for (int i = 0; i < limit; i++)
            {
                 marks[i] = new Types.GameActionMark();
                 marks[i].Deserialize(reader);
            }
            gameTurn = reader.ReadVarUhShort();
            fightStart = reader.ReadInt();
            limit = (ushort)reader.ReadUShort();
            idols = new Types.Idol[limit];
            for (int i = 0; i < limit; i++)
            {
                 idols[i] = new Types.Idol();
                 idols[i].Deserialize(reader);
            }
            limit = (ushort)reader.ReadUShort();
            fxTriggerCounts = new Types.GameFightEffectTriggerCount[limit];
            for (int i = 0; i < limit; i++)
            {
                 fxTriggerCounts[i] = new Types.GameFightEffectTriggerCount();
                 fxTriggerCounts[i].Deserialize(reader);
            }
            

}


}


}