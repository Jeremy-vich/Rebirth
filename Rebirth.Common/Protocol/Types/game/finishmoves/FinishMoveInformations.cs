


















// Generated on 01/30/2023 13:09:34
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class FinishMoveInformations
{

public const short Id = 5282;
public virtual short TypeId
{
    get { return Id; }
}

public int finishMoveId;
        public bool finishMoveState;
        

public FinishMoveInformations()
{
}

public FinishMoveInformations(int finishMoveId, bool finishMoveState)
        {
            this.finishMoveId = finishMoveId;
            this.finishMoveState = finishMoveState;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteInt(finishMoveId);
            writer.WriteBoolean(finishMoveState);
            

}

public virtual void Deserialize(IDataReader reader)
{

finishMoveId = reader.ReadInt();
            finishMoveState = reader.ReadBoolean();
            

}


}


}