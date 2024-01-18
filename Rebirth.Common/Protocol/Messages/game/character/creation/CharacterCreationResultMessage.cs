


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class CharacterCreationResultMessage : NetworkMessage
{

public const uint Id = 9042;
public uint MessageId
{
    get { return Id; }
}

public sbyte result;
        public sbyte reason;
        

public CharacterCreationResultMessage()
{
}

public CharacterCreationResultMessage(sbyte result, sbyte reason)
        {
            this.result = result;
            this.reason = reason;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(result);
            writer.WriteSbyte(reason);
            

}

public void Deserialize(IDataReader reader)
{

result = reader.ReadSbyte();
            reason = reader.ReadSbyte();
            

}


}


}