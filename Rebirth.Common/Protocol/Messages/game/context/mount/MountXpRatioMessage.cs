


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class MountXpRatioMessage : NetworkMessage
{

public const uint Id = 7601;
public uint MessageId
{
    get { return Id; }
}

public sbyte ratio;
        

public MountXpRatioMessage()
{
}

public MountXpRatioMessage(sbyte ratio)
        {
            this.ratio = ratio;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(ratio);
            

}

public void Deserialize(IDataReader reader)
{

ratio = reader.ReadSbyte();
            

}


}


}