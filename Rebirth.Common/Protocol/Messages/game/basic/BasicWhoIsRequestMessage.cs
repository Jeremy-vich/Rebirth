


















// Generated on 01/30/2023 13:09:09
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class BasicWhoIsRequestMessage : NetworkMessage
{

public const uint Id = 5910;
public uint MessageId
{
    get { return Id; }
}

public bool verbose;
        public Types.AbstractPlayerSearchInformation target;
        

public BasicWhoIsRequestMessage()
{
}

public BasicWhoIsRequestMessage(bool verbose, Types.AbstractPlayerSearchInformation target)
        {
            this.verbose = verbose;
            this.target = target;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(verbose);
            writer.WriteShort(target.TypeId);
            target.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

verbose = reader.ReadBoolean();
            target = ProtocolTypeManager.GetInstance<Types.AbstractPlayerSearchInformation>(reader.ReadUShort());
            target.Deserialize(reader);
            

}


}


}