


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class MountSetXpRatioRequestMessage : NetworkMessage
{

public const uint Id = 7292;
public uint MessageId
{
    get { return Id; }
}

public sbyte xpRatio;
        

public MountSetXpRatioRequestMessage()
{
}

public MountSetXpRatioRequestMessage(sbyte xpRatio)
        {
            this.xpRatio = xpRatio;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(xpRatio);
            

}

public void Deserialize(IDataReader reader)
{

xpRatio = reader.ReadSbyte();
            

}


}


}