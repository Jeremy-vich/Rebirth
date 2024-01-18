


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayArenaFightPropositionMessage : NetworkMessage
{

public const uint Id = 4162;
public uint MessageId
{
    get { return Id; }
}

public uint fightId;
        public double[] alliesId;
        public uint duration;
        

public GameRolePlayArenaFightPropositionMessage()
{
}

public GameRolePlayArenaFightPropositionMessage(uint fightId, double[] alliesId, uint duration)
        {
            this.fightId = fightId;
            this.alliesId = alliesId;
            this.duration = duration;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)fightId);
            writer.WriteShort((short)alliesId.Length);
            foreach (var entry in alliesId)
            {
                 writer.WriteDouble(entry);
            }
            writer.WriteVarShort((int)duration);
            

}

public void Deserialize(IDataReader reader)
{

fightId = reader.ReadVarUhShort();
            var limit = (ushort)reader.ReadUShort();
            alliesId = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 alliesId[i] = reader.ReadDouble();
            }
            duration = reader.ReadVarUhShort();
            

}


}


}