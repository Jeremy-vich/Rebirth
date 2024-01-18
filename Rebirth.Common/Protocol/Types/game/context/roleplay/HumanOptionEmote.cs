


















// Generated on 01/30/2023 13:09:33
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class HumanOptionEmote : HumanOption
{

public const short Id = 7493;
public override short TypeId
{
    get { return Id; }
}

public ushort emoteId;
        public double emoteStartTime;
        

public HumanOptionEmote()
{
}

public HumanOptionEmote(ushort emoteId, double emoteStartTime)
        {
            this.emoteId = emoteId;
            this.emoteStartTime = emoteStartTime;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort(emoteId);
            writer.WriteDouble(emoteStartTime);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            emoteId = reader.ReadUShort();
            emoteStartTime = reader.ReadDouble();
            

}


}


}