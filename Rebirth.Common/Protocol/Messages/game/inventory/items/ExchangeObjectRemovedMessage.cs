


















// Generated on 01/30/2023 13:09:26
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeObjectRemovedMessage : ExchangeObjectMessage
{

public const uint Id = 1310;
public uint MessageId
{
    get { return Id; }
}

public uint objectUID;
        

public ExchangeObjectRemovedMessage()
{
}

public ExchangeObjectRemovedMessage(bool remote, uint objectUID)
         : base(remote)
        {
            this.objectUID = objectUID;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)objectUID);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            objectUID = reader.ReadVarUhInt();
            

}


}


}