


















// Generated on 01/30/2023 13:09:29
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class TitleSelectedMessage : NetworkMessage
{

public const uint Id = 4607;
public uint MessageId
{
    get { return Id; }
}

public uint titleId;
        

public TitleSelectedMessage()
{
}

public TitleSelectedMessage(uint titleId)
        {
            this.titleId = titleId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)titleId);
            

}

public void Deserialize(IDataReader reader)
{

titleId = reader.ReadVarUhShort();
            

}


}


}