


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AlignmentWarEffortDonatePreviewMessage : NetworkMessage
{

public const uint Id = 7512;
public uint MessageId
{
    get { return Id; }
}

public double xp;
        

public AlignmentWarEffortDonatePreviewMessage()
{
}

public AlignmentWarEffortDonatePreviewMessage(double xp)
        {
            this.xp = xp;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(xp);
            

}

public void Deserialize(IDataReader reader)
{

xp = reader.ReadDouble();
            

}


}


}