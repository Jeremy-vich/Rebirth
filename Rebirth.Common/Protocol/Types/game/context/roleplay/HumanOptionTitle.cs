


















// Generated on 01/30/2023 13:09:33
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class HumanOptionTitle : HumanOption
{

public const short Id = 8686;
public override short TypeId
{
    get { return Id; }
}

public uint titleId;
        public string titleParam;
        

public HumanOptionTitle()
{
}

public HumanOptionTitle(uint titleId, string titleParam)
        {
            this.titleId = titleId;
            this.titleParam = titleParam;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)titleId);
            writer.WriteUTF(titleParam);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            titleId = reader.ReadVarUhShort();
            titleParam = reader.ReadUTF();
            

}


}


}