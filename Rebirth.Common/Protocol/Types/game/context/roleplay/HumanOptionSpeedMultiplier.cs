


















// Generated on 01/30/2023 13:09:33
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class HumanOptionSpeedMultiplier : HumanOption
{

public const short Id = 5081;
public override short TypeId
{
    get { return Id; }
}

public uint speedMultiplier;
        

public HumanOptionSpeedMultiplier()
{
}

public HumanOptionSpeedMultiplier(uint speedMultiplier)
        {
            this.speedMultiplier = speedMultiplier;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)speedMultiplier);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            speedMultiplier = reader.ReadVarUhInt();
            

}


}


}