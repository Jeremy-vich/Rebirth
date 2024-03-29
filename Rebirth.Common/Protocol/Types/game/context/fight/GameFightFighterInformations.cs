


















// Generated on 01/30/2023 13:09:32
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameFightFighterInformations : GameContextActorInformations
{

public const short Id = 8667;
public override short TypeId
{
    get { return Id; }
}

public Types.GameContextBasicSpawnInformation spawnInfo;
        public sbyte wave;
        public Types.GameFightCharacteristics stats;
        public uint[] previousPositions;
        

public GameFightFighterInformations()
{
}

public GameFightFighterInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, Types.GameContextBasicSpawnInformation spawnInfo, sbyte wave, Types.GameFightCharacteristics stats, uint[] previousPositions)
         : base(contextualId, disposition, look)
        {
            this.spawnInfo = spawnInfo;
            this.wave = wave;
            this.stats = stats;
            this.previousPositions = previousPositions;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            spawnInfo.Serialize(writer);
            writer.WriteSbyte(wave);
            writer.WriteShort(stats.TypeId);
            stats.Serialize(writer);
            writer.WriteShort((short)previousPositions.Length);
            foreach (var entry in previousPositions)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            spawnInfo = new Types.GameContextBasicSpawnInformation();
            spawnInfo.Deserialize(reader);
            wave = reader.ReadSbyte();
            stats = ProtocolTypeManager.GetInstance<Types.GameFightCharacteristics>(reader.ReadUShort());
            stats.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            previousPositions = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 previousPositions[i] = reader.ReadVarUhShort();
            }
            

}


}


}