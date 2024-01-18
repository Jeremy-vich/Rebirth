


















// Generated on 01/30/2023 13:09:30
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class HaapiValidationMessage : NetworkMessage
{

public const uint Id = 3738;
public uint MessageId
{
    get { return Id; }
}

public sbyte action;
        public sbyte code;
        

public HaapiValidationMessage()
{
}

public HaapiValidationMessage(sbyte action, sbyte code)
        {
            this.action = action;
            this.code = code;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(action);
            writer.WriteSbyte(code);
            

}

public void Deserialize(IDataReader reader)
{

action = reader.ReadSbyte();
            code = reader.ReadSbyte();
            

}


}


}