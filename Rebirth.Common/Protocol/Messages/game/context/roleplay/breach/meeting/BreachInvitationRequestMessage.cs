


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BreachInvitationRequestMessage : NetworkMessage
{

public const uint Id = 8081;
public uint MessageId
{
    get { return Id; }
}

public double[] guests;
        

public BreachInvitationRequestMessage()
{
}

public BreachInvitationRequestMessage(double[] guests)
        {
            this.guests = guests;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)guests.Length);
            foreach (var entry in guests)
            {
                 writer.WriteVarLong(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            guests = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 guests[i] = reader.ReadVarUhLong();
            }
            

}


}


}