


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class MountInformationsForPaddock
{

public const short Id = 8850;
public virtual short TypeId
{
    get { return Id; }
}

public uint modelId;
        public string name;
        public string ownerName;
        

public MountInformationsForPaddock()
{
}

public MountInformationsForPaddock(uint modelId, string name, string ownerName)
        {
            this.modelId = modelId;
            this.name = name;
            this.ownerName = ownerName;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)modelId);
            writer.WriteUTF(name);
            writer.WriteUTF(ownerName);
            

}

public virtual void Deserialize(IDataReader reader)
{

modelId = reader.ReadVarUhShort();
            name = reader.ReadUTF();
            ownerName = reader.ReadUTF();
            

}


}


}