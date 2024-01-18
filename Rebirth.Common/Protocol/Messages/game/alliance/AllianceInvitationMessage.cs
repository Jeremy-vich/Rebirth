


















// Generated on 01/30/2023 13:09:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AllianceInvitationMessage : NetworkMessage
{

public const uint Id = 5278;
public uint MessageId
{
    get { return Id; }
}

public double targetId;
        

public AllianceInvitationMessage()
{
}

public AllianceInvitationMessage(double targetId)
        {
            this.targetId = targetId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(targetId);
            

}

public void Deserialize(IDataReader reader)
{

targetId = reader.ReadVarUhLong();
            

}


}


}