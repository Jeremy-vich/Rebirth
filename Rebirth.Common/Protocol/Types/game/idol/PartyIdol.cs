


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class PartyIdol : Idol
{

public const short Id = 8979;
public override short TypeId
{
    get { return Id; }
}

public double[] ownersIds;
        

public PartyIdol()
{
}

public PartyIdol(uint id, uint xpBonusPercent, uint dropBonusPercent, double[] ownersIds)
         : base(id, xpBonusPercent, dropBonusPercent)
        {
            this.ownersIds = ownersIds;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)ownersIds.Length);
            foreach (var entry in ownersIds)
            {
                 writer.WriteVarLong(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            ownersIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 ownersIds[i] = reader.ReadVarUhLong();
            }
            

}


}


}