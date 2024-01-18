


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class PlayerNote
{

public const short Id = 7031;
public virtual short TypeId
{
    get { return Id; }
}

public string content;
        public double lastEditDate;
        

public PlayerNote()
{
}

public PlayerNote(string content, double lastEditDate)
        {
            this.content = content;
            this.lastEditDate = lastEditDate;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteUTF(content);
            writer.WriteDouble(lastEditDate);
            

}

public virtual void Deserialize(IDataReader reader)
{

content = reader.ReadUTF();
            lastEditDate = reader.ReadDouble();
            

}


}


}