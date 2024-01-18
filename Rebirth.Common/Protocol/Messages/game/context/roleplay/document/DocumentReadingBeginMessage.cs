


















// Generated on 01/30/2023 13:09:15
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class DocumentReadingBeginMessage : NetworkMessage
{

public const uint Id = 5660;
public uint MessageId
{
    get { return Id; }
}

public uint documentId;
        

public DocumentReadingBeginMessage()
{
}

public DocumentReadingBeginMessage(uint documentId)
        {
            this.documentId = documentId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)documentId);
            

}

public void Deserialize(IDataReader reader)
{

documentId = reader.ReadVarUhShort();
            

}


}


}