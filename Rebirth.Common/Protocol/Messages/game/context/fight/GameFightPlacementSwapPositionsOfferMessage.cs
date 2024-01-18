


















// Generated on 01/30/2023 13:09:12
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightPlacementSwapPositionsOfferMessage : NetworkMessage
{

public const uint Id = 81;
public uint MessageId
{
    get { return Id; }
}

public int requestId;
        public double requesterId;
        public uint requesterCellId;
        public double requestedId;
        public uint requestedCellId;
        

public GameFightPlacementSwapPositionsOfferMessage()
{
}

public GameFightPlacementSwapPositionsOfferMessage(int requestId, double requesterId, uint requesterCellId, double requestedId, uint requestedCellId)
        {
            this.requestId = requestId;
            this.requesterId = requesterId;
            this.requesterCellId = requesterCellId;
            this.requestedId = requestedId;
            this.requestedCellId = requestedCellId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(requestId);
            writer.WriteDouble(requesterId);
            writer.WriteVarShort((int)requesterCellId);
            writer.WriteDouble(requestedId);
            writer.WriteVarShort((int)requestedCellId);
            

}

public void Deserialize(IDataReader reader)
{

requestId = reader.ReadInt();
            requesterId = reader.ReadDouble();
            requesterCellId = reader.ReadVarUhShort();
            requestedId = reader.ReadDouble();
            requestedCellId = reader.ReadVarUhShort();
            

}


}


}