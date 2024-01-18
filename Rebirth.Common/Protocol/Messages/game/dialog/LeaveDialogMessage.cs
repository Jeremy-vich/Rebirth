


















// Generated on 01/30/2023 13:09:20
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class LeaveDialogMessage : NetworkMessage
{

public const uint Id = 115;
public uint MessageId
{
    get { return Id; }
}

public sbyte dialogType;
        

public LeaveDialogMessage()
{
}

public LeaveDialogMessage(sbyte dialogType)
        {
            this.dialogType = dialogType;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(dialogType);
            

}

public void Deserialize(IDataReader reader)
{

dialogType = reader.ReadSbyte();
            

}


}


}