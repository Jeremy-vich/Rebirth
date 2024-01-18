


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PrismFightDefenderAddMessage : NetworkMessage
{

public const uint Id = 2845;
public uint MessageId
{
    get { return Id; }
}

public uint subAreaId;
        public uint fightId;
        public Types.CharacterMinimalPlusLookInformations defender;
        

public PrismFightDefenderAddMessage()
{
}

public PrismFightDefenderAddMessage(uint subAreaId, uint fightId, Types.CharacterMinimalPlusLookInformations defender)
        {
            this.subAreaId = subAreaId;
            this.fightId = fightId;
            this.defender = defender;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)subAreaId);
            writer.WriteVarShort((int)fightId);
            writer.WriteShort(defender.TypeId);
            defender.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

subAreaId = reader.ReadVarUhShort();
            fightId = reader.ReadVarUhShort();
            defender = ProtocolTypeManager.GetInstance<Types.CharacterMinimalPlusLookInformations>(reader.ReadUShort());
            defender.Deserialize(reader);
            

}


}


}