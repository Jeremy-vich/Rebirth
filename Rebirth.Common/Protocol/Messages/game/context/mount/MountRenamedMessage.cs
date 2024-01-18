


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class MountRenamedMessage : NetworkMessage
{

public const uint Id = 7843;
public uint MessageId
{
    get { return Id; }
}

public int mountId;
        public string name;
        

public MountRenamedMessage()
{
}

public MountRenamedMessage(int mountId, string name)
        {
            this.mountId = mountId;
            this.name = name;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)mountId);
            writer.WriteUTF(name);
            

}

public void Deserialize(IDataReader reader)
{

mountId = reader.ReadVarInt();
            name = reader.ReadUTF();
            

}


}


}