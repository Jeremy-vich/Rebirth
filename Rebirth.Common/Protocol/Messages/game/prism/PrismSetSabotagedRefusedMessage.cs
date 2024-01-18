


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PrismSetSabotagedRefusedMessage : NetworkMessage
{

public const uint Id = 305;
public uint MessageId
{
    get { return Id; }
}

public uint subAreaId;
        public sbyte reason;
        

public PrismSetSabotagedRefusedMessage()
{
}

public PrismSetSabotagedRefusedMessage(uint subAreaId, sbyte reason)
        {
            this.subAreaId = subAreaId;
            this.reason = reason;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)subAreaId);
            writer.WriteSbyte(reason);
            

}

public void Deserialize(IDataReader reader)
{

subAreaId = reader.ReadVarUhShort();
            reason = reader.ReadSbyte();
            

}


}


}