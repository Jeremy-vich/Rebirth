


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PrismFightAttackerAddMessage : NetworkMessage
{

public const uint Id = 4390;
public uint MessageId
{
    get { return Id; }
}

public uint subAreaId;
        public uint fightId;
        public Types.CharacterMinimalPlusLookInformations attacker;
        

public PrismFightAttackerAddMessage()
{
}

public PrismFightAttackerAddMessage(uint subAreaId, uint fightId, Types.CharacterMinimalPlusLookInformations attacker)
        {
            this.subAreaId = subAreaId;
            this.fightId = fightId;
            this.attacker = attacker;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)subAreaId);
            writer.WriteVarShort((int)fightId);
            writer.WriteShort(attacker.TypeId);
            attacker.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

subAreaId = reader.ReadVarUhShort();
            fightId = reader.ReadVarUhShort();
            attacker = ProtocolTypeManager.GetInstance<Types.CharacterMinimalPlusLookInformations>(reader.ReadUShort());
            attacker.Deserialize(reader);
            

}


}


}