


















// Generated on 01/30/2023 13:09:33
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class MonsterInGroupLightInformations
{

public const short Id = 7887;
public virtual short TypeId
{
    get { return Id; }
}

public int genericId;
        public sbyte grade;
        public short level;
        

public MonsterInGroupLightInformations()
{
}

public MonsterInGroupLightInformations(int genericId, sbyte grade, short level)
        {
            this.genericId = genericId;
            this.grade = grade;
            this.level = level;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteInt(genericId);
            writer.WriteSbyte(grade);
            writer.WriteShort(level);
            

}

public virtual void Deserialize(IDataReader reader)
{

genericId = reader.ReadInt();
            grade = reader.ReadSbyte();
            level = reader.ReadShort();
            

}


}


}