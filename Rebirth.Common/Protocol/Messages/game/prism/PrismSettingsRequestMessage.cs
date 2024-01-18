


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PrismSettingsRequestMessage : NetworkMessage
{

public const uint Id = 9345;
public uint MessageId
{
    get { return Id; }
}

public uint subAreaId;
        public sbyte startDefenseTime;
        

public PrismSettingsRequestMessage()
{
}

public PrismSettingsRequestMessage(uint subAreaId, sbyte startDefenseTime)
        {
            this.subAreaId = subAreaId;
            this.startDefenseTime = startDefenseTime;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)subAreaId);
            writer.WriteSbyte(startDefenseTime);
            

}

public void Deserialize(IDataReader reader)
{

subAreaId = reader.ReadVarUhShort();
            startDefenseTime = reader.ReadSbyte();
            

}


}


}