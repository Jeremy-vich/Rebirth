


















// Generated on 01/30/2023 13:09:29
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class CheckIntegrityMessage : NetworkMessage
{

public const uint Id = 643;
public uint MessageId
{
    get { return Id; }
}

public sbyte[] data;
        

public CheckIntegrityMessage()
{
}

public CheckIntegrityMessage(sbyte[] data)
        {
            this.data = data;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)(ushort)data.Length);
            foreach (var entry in data)
            {
                 writer.WriteSbyte(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadVarInt();
            data = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 data[i] = reader.ReadSbyte();
            }
            

}


}


}