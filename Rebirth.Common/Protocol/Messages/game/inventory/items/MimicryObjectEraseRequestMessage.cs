


















// Generated on 01/30/2023 13:09:26
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class MimicryObjectEraseRequestMessage : NetworkMessage
{

public const uint Id = 2684;
public uint MessageId
{
    get { return Id; }
}

public uint hostUID;
        public byte hostPos;
        

public MimicryObjectEraseRequestMessage()
{
}

public MimicryObjectEraseRequestMessage(uint hostUID, byte hostPos)
        {
            this.hostUID = hostUID;
            this.hostPos = hostPos;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)hostUID);
            writer.WriteByte(hostPos);
            

}

public void Deserialize(IDataReader reader)
{

hostUID = reader.ReadVarUhInt();
            hostPos = reader.ReadByte();
            

}


}


}