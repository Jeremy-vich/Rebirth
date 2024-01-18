


















// Generated on 01/30/2023 13:09:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameActionFightSummonMessage : AbstractGameActionMessage
{

public const uint Id = 7224;
public uint MessageId
{
    get { return Id; }
}

public Types.GameFightFighterInformations[] summons;
        

public GameActionFightSummonMessage()
{
}

public GameActionFightSummonMessage(uint actionId, double sourceId, Types.GameFightFighterInformations[] summons)
         : base(actionId, sourceId)
        {
            this.summons = summons;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)summons.Length);
            foreach (var entry in summons)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            summons = new Types.GameFightFighterInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 summons[i] = ProtocolTypeManager.GetInstance<Types.GameFightFighterInformations>(reader.ReadUShort());
                 summons[i].Deserialize(reader);
            }
            

}


}


}