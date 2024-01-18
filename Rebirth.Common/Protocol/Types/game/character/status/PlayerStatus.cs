


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class PlayerStatus
{

public const short Id = 6409;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte statusId;
        

public PlayerStatus()
{
}

public PlayerStatus(sbyte statusId)
        {
            this.statusId = statusId;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSbyte(statusId);
            

}

public virtual void Deserialize(IDataReader reader)
{

statusId = reader.ReadSbyte();
            

}


}


}