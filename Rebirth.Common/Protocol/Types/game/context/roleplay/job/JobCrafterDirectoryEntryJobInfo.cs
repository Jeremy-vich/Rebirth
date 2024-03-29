


















// Generated on 01/30/2023 13:09:33
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class JobCrafterDirectoryEntryJobInfo
{

public const short Id = 2848;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte jobId;
        public byte jobLevel;
        public bool free;
        public byte minLevel;
        

public JobCrafterDirectoryEntryJobInfo()
{
}

public JobCrafterDirectoryEntryJobInfo(sbyte jobId, byte jobLevel, bool free, byte minLevel)
        {
            this.jobId = jobId;
            this.jobLevel = jobLevel;
            this.free = free;
            this.minLevel = minLevel;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSbyte(jobId);
            writer.WriteByte(jobLevel);
            writer.WriteBoolean(free);
            writer.WriteByte(minLevel);
            

}

public virtual void Deserialize(IDataReader reader)
{

jobId = reader.ReadSbyte();
            jobLevel = reader.ReadByte();
            free = reader.ReadBoolean();
            minLevel = reader.ReadByte();
            

}


}


}