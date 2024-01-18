


















// Generated on 01/30/2023 13:09:19
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class RefreshFollowedQuestsOrderRequestMessage : NetworkMessage
{

public const uint Id = 5420;
public uint MessageId
{
    get { return Id; }
}

public uint[] quests;
        

public RefreshFollowedQuestsOrderRequestMessage()
{
}

public RefreshFollowedQuestsOrderRequestMessage(uint[] quests)
        {
            this.quests = quests;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)quests.Length);
            foreach (var entry in quests)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            quests = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 quests[i] = reader.ReadVarUhShort();
            }
            

}


}


}