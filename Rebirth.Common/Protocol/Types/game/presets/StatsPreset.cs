


















// Generated on 01/30/2023 13:09:35
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class StatsPreset : Preset
{

public const short Id = 7648;
public override short TypeId
{
    get { return Id; }
}

public Types.SimpleCharacterCharacteristicForPreset[] stats;
        

public StatsPreset()
{
}

public StatsPreset(short id, Types.SimpleCharacterCharacteristicForPreset[] stats)
         : base(id)
        {
            this.stats = stats;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)stats.Length);
            foreach (var entry in stats)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            stats = new Types.SimpleCharacterCharacteristicForPreset[limit];
            for (int i = 0; i < limit; i++)
            {
                 stats[i] = new Types.SimpleCharacterCharacteristicForPreset();
                 stats[i].Deserialize(reader);
            }
            

}


}


}