


















// Generated on 01/30/2023 13:09:30
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class HaapiValidationRequestMessage : NetworkMessage
{

public const uint Id = 2106;
public uint MessageId
{
    get { return Id; }
}

public string transaction;
        

public HaapiValidationRequestMessage()
{
}

public HaapiValidationRequestMessage(string transaction)
        {
            this.transaction = transaction;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(transaction);
            

}

public void Deserialize(IDataReader reader)
{

transaction = reader.ReadUTF();
            

}


}


}