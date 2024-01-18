


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ShortcutBarSwapRequestMessage : NetworkMessage
{

public const uint Id = 5362;
public uint MessageId
{
    get { return Id; }
}

public sbyte barType;
        public sbyte firstSlot;
        public sbyte secondSlot;
        

public ShortcutBarSwapRequestMessage()
{
}

public ShortcutBarSwapRequestMessage(sbyte barType, sbyte firstSlot, sbyte secondSlot)
        {
            this.barType = barType;
            this.firstSlot = firstSlot;
            this.secondSlot = secondSlot;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(barType);
            writer.WriteSbyte(firstSlot);
            writer.WriteSbyte(secondSlot);
            

}

public void Deserialize(IDataReader reader)
{

barType = reader.ReadSbyte();
            firstSlot = reader.ReadSbyte();
            secondSlot = reader.ReadSbyte();
            

}


}


}