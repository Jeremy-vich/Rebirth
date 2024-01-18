


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class SymbioticObjectErrorMessage : ObjectErrorMessage
{

public const uint Id = 827;
public uint MessageId
{
    get { return Id; }
}

public sbyte errorCode;
        

public SymbioticObjectErrorMessage()
{
}

public SymbioticObjectErrorMessage(sbyte reason, sbyte errorCode)
         : base(reason)
        {
            this.errorCode = errorCode;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(errorCode);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            errorCode = reader.ReadSbyte();
            

}


}


}