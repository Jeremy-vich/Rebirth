


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class PrismFightersInformation
{

public const short Id = 1824;
public virtual short TypeId
{
    get { return Id; }
}

public uint subAreaId;
        public Types.ProtectedEntityWaitingForHelpInfo waitingForHelpInfo;
        public Types.CharacterMinimalPlusLookInformations[] allyCharactersInformations;
        public Types.CharacterMinimalPlusLookInformations[] enemyCharactersInformations;
        

public PrismFightersInformation()
{
}

public PrismFightersInformation(uint subAreaId, Types.ProtectedEntityWaitingForHelpInfo waitingForHelpInfo, Types.CharacterMinimalPlusLookInformations[] allyCharactersInformations, Types.CharacterMinimalPlusLookInformations[] enemyCharactersInformations)
        {
            this.subAreaId = subAreaId;
            this.waitingForHelpInfo = waitingForHelpInfo;
            this.allyCharactersInformations = allyCharactersInformations;
            this.enemyCharactersInformations = enemyCharactersInformations;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)subAreaId);
            waitingForHelpInfo.Serialize(writer);
            writer.WriteShort((short)allyCharactersInformations.Length);
            foreach (var entry in allyCharactersInformations)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)enemyCharactersInformations.Length);
            foreach (var entry in enemyCharactersInformations)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public virtual void Deserialize(IDataReader reader)
{

subAreaId = reader.ReadVarUhShort();
            waitingForHelpInfo = new Types.ProtectedEntityWaitingForHelpInfo();
            waitingForHelpInfo.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            allyCharactersInformations = new Types.CharacterMinimalPlusLookInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 allyCharactersInformations[i] = ProtocolTypeManager.GetInstance<Types.CharacterMinimalPlusLookInformations>(reader.ReadUShort());
                 allyCharactersInformations[i].Deserialize(reader);
            }
            limit = (ushort)reader.ReadUShort();
            enemyCharactersInformations = new Types.CharacterMinimalPlusLookInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 enemyCharactersInformations[i] = ProtocolTypeManager.GetInstance<Types.CharacterMinimalPlusLookInformations>(reader.ReadUShort());
                 enemyCharactersInformations[i].Deserialize(reader);
            }
            

}


}


}