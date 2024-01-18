


















// Generated on 01/30/2023 13:09:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class CharacterCanBeCreatedResultMessage : NetworkMessage
{

public const uint Id = 7681;
public uint MessageId
{
    get { return Id; }
}

public bool yesYouCan;
        

public CharacterCanBeCreatedResultMessage()
{
}

public CharacterCanBeCreatedResultMessage(bool yesYouCan)
        {
            this.yesYouCan = yesYouCan;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(yesYouCan);
            

}

public void Deserialize(IDataReader reader)
{

yesYouCan = reader.ReadBoolean();
            

}


}


}