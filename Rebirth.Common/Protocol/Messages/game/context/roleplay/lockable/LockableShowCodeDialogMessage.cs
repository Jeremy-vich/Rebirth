


















// Generated on 01/30/2023 13:09:17
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class LockableShowCodeDialogMessage : NetworkMessage
{

public const uint Id = 6049;
public uint MessageId
{
    get { return Id; }
}

public bool changeOrUse;
        public sbyte codeSize;
        

public LockableShowCodeDialogMessage()
{
}

public LockableShowCodeDialogMessage(bool changeOrUse, sbyte codeSize)
        {
            this.changeOrUse = changeOrUse;
            this.codeSize = codeSize;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(changeOrUse);
            writer.WriteSbyte(codeSize);
            

}

public void Deserialize(IDataReader reader)
{

changeOrUse = reader.ReadBoolean();
            codeSize = reader.ReadSbyte();
            

}


}


}