


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayArenaInvitationCandidatesAnswerMessage : NetworkMessage
{

public const uint Id = 5561;
public uint MessageId
{
    get { return Id; }
}

public Types.LeagueFriendInformations[] candidates;
        

public GameRolePlayArenaInvitationCandidatesAnswerMessage()
{
}

public GameRolePlayArenaInvitationCandidatesAnswerMessage(Types.LeagueFriendInformations[] candidates)
        {
            this.candidates = candidates;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)candidates.Length);
            foreach (var entry in candidates)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            candidates = new Types.LeagueFriendInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 candidates[i] = new Types.LeagueFriendInformations();
                 candidates[i].Deserialize(reader);
            }
            

}


}


}