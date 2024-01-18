


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class MountRidingMessage : NetworkMessage
{

public const uint Id = 8140;
public uint MessageId
{
    get { return Id; }
}

public bool isRiding;
        public bool isAutopilot;
        

public MountRidingMessage()
{
}

public MountRidingMessage(bool isRiding, bool isAutopilot)
        {
            this.isRiding = isRiding;
            this.isAutopilot = isAutopilot;
        }
        

public void Serialize(IDataWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, isRiding);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, isAutopilot);
            writer.WriteByte(flag1);
            

}

public void Deserialize(IDataReader reader)
{

byte flag1 = reader.ReadByte();
            isRiding = BooleanByteWrapper.GetFlag(flag1, 0);
            isAutopilot = BooleanByteWrapper.GetFlag(flag1, 1);
            

}


}


}