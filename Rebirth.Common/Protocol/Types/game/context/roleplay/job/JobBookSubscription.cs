


















// Generated on 01/30/2023 13:09:33
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class JobBookSubscription
{

public const short Id = 1331;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte jobId;
        public bool subscribed;
        

public JobBookSubscription()
{
}

public JobBookSubscription(sbyte jobId, bool subscribed)
        {
            this.jobId = jobId;
            this.subscribed = subscribed;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSbyte(jobId);
            writer.WriteBoolean(subscribed);
            

}

public virtual void Deserialize(IDataReader reader)
{

jobId = reader.ReadSbyte();
            subscribed = reader.ReadBoolean();
            

}


}


}