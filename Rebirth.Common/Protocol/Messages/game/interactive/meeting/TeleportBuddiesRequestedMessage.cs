


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class TeleportBuddiesRequestedMessage : NetworkMessage
{

public const uint Id = 7211;
public uint MessageId
{
    get { return Id; }
}

public uint dungeonId;
        public double inviterId;
        public double[] invalidBuddiesIds;
        

public TeleportBuddiesRequestedMessage()
{
}

public TeleportBuddiesRequestedMessage(uint dungeonId, double inviterId, double[] invalidBuddiesIds)
        {
            this.dungeonId = dungeonId;
            this.inviterId = inviterId;
            this.invalidBuddiesIds = invalidBuddiesIds;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)dungeonId);
            writer.WriteVarLong(inviterId);
            writer.WriteShort((short)invalidBuddiesIds.Length);
            foreach (var entry in invalidBuddiesIds)
            {
                 writer.WriteVarLong(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

dungeonId = reader.ReadVarUhShort();
            inviterId = reader.ReadVarUhLong();
            var limit = (ushort)reader.ReadUShort();
            invalidBuddiesIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 invalidBuddiesIds[i] = reader.ReadVarUhLong();
            }
            

}


}


}