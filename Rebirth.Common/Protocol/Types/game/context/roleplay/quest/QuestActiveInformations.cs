


















// Generated on 01/30/2023 13:09:33
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class QuestActiveInformations
{

public const short Id = 883;
public virtual short TypeId
{
    get { return Id; }
}

public uint questId;
        

public QuestActiveInformations()
{
}

public QuestActiveInformations(uint questId)
        {
            this.questId = questId;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)questId);
            

}

public virtual void Deserialize(IDataReader reader)
{

questId = reader.ReadVarUhShort();
            

}


}


}