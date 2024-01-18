


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class UpdatedStorageTabInformation
{

public const short Id = 4597;
public virtual short TypeId
{
    get { return Id; }
}

public string name;
        public uint tabNumber;
        public uint picto;
        public uint[] dropTypeLimitation;
        

public UpdatedStorageTabInformation()
{
}

public UpdatedStorageTabInformation(string name, uint tabNumber, uint picto, uint[] dropTypeLimitation)
        {
            this.name = name;
            this.tabNumber = tabNumber;
            this.picto = picto;
            this.dropTypeLimitation = dropTypeLimitation;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteUTF(name);
            writer.WriteVarInt((int)tabNumber);
            writer.WriteVarInt((int)picto);
            writer.WriteShort((short)dropTypeLimitation.Length);
            foreach (var entry in dropTypeLimitation)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public virtual void Deserialize(IDataReader reader)
{

name = reader.ReadUTF();
            tabNumber = reader.ReadVarUhInt();
            picto = reader.ReadVarUhInt();
            var limit = (ushort)reader.ReadUShort();
            dropTypeLimitation = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 dropTypeLimitation[i] = reader.ReadVarUhInt();
            }
            

}


}


}