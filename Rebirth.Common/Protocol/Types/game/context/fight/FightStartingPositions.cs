


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class FightStartingPositions
{

public const short Id = 9514;
public virtual short TypeId
{
    get { return Id; }
}

public uint[] positionsForChallengers;
        public uint[] positionsForDefenders;
        

public FightStartingPositions()
{
}

public FightStartingPositions(uint[] positionsForChallengers, uint[] positionsForDefenders)
        {
            this.positionsForChallengers = positionsForChallengers;
            this.positionsForDefenders = positionsForDefenders;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteShort((short)positionsForChallengers.Length);
            foreach (var entry in positionsForChallengers)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)positionsForDefenders.Length);
            foreach (var entry in positionsForDefenders)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public virtual void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            positionsForChallengers = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 positionsForChallengers[i] = reader.ReadVarUhShort();
            }
            limit = (ushort)reader.ReadUShort();
            positionsForDefenders = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 positionsForDefenders[i] = reader.ReadVarUhShort();
            }
            

}


}


}