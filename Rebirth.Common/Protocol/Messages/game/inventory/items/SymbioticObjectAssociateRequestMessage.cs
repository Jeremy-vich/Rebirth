


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class SymbioticObjectAssociateRequestMessage : NetworkMessage
{

public const uint Id = 8550;
public uint MessageId
{
    get { return Id; }
}

public uint symbioteUID;
        public byte symbiotePos;
        public uint hostUID;
        public byte hostPos;
        

public SymbioticObjectAssociateRequestMessage()
{
}

public SymbioticObjectAssociateRequestMessage(uint symbioteUID, byte symbiotePos, uint hostUID, byte hostPos)
        {
            this.symbioteUID = symbioteUID;
            this.symbiotePos = symbiotePos;
            this.hostUID = hostUID;
            this.hostPos = hostPos;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)symbioteUID);
            writer.WriteByte(symbiotePos);
            writer.WriteVarInt((int)hostUID);
            writer.WriteByte(hostPos);
            

}

public void Deserialize(IDataReader reader)
{

symbioteUID = reader.ReadVarUhInt();
            symbiotePos = reader.ReadByte();
            hostUID = reader.ReadVarUhInt();
            hostPos = reader.ReadByte();
            

}


}


}