


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightStartingMessage : NetworkMessage
{

public const uint Id = 4026;
public uint MessageId
{
    get { return Id; }
}

public sbyte fightType;
        public uint fightId;
        public double attackerId;
        public double defenderId;
        public bool containsBoss;
        public int[] monsters;
        

public GameFightStartingMessage()
{
}

public GameFightStartingMessage(sbyte fightType, uint fightId, double attackerId, double defenderId, bool containsBoss, int[] monsters)
        {
            this.fightType = fightType;
            this.fightId = fightId;
            this.attackerId = attackerId;
            this.defenderId = defenderId;
            this.containsBoss = containsBoss;
            this.monsters = monsters;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(fightType);
            writer.WriteVarShort((int)fightId);
            writer.WriteDouble(attackerId);
            writer.WriteDouble(defenderId);
            writer.WriteBoolean(containsBoss);
            writer.WriteShort((short)monsters.Length);
            foreach (var entry in monsters)
            {
                 writer.WriteInt(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

fightType = reader.ReadSbyte();
            fightId = reader.ReadVarUhShort();
            attackerId = reader.ReadDouble();
            defenderId = reader.ReadDouble();
            containsBoss = reader.ReadBoolean();
            var limit = (ushort)reader.ReadUShort();
            monsters = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 monsters[i] = reader.ReadInt();
            }
            

}


}


}