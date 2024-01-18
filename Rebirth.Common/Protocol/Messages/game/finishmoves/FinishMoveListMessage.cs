


















// Generated on 01/30/2023 13:09:20
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class FinishMoveListMessage : NetworkMessage
{

public const uint Id = 8031;
public uint MessageId
{
    get { return Id; }
}

public Types.FinishMoveInformations[] finishMoves;
        

public FinishMoveListMessage()
{
}

public FinishMoveListMessage(Types.FinishMoveInformations[] finishMoves)
        {
            this.finishMoves = finishMoves;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)finishMoves.Length);
            foreach (var entry in finishMoves)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            finishMoves = new Types.FinishMoveInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 finishMoves[i] = new Types.FinishMoveInformations();
                 finishMoves[i].Deserialize(reader);
            }
            

}


}


}