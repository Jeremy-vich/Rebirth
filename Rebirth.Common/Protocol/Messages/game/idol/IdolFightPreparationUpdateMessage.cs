


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class IdolFightPreparationUpdateMessage : NetworkMessage
{

public const uint Id = 9059;
public uint MessageId
{
    get { return Id; }
}

public sbyte idolSource;
        public Types.Idol[] idols;
        

public IdolFightPreparationUpdateMessage()
{
}

public IdolFightPreparationUpdateMessage(sbyte idolSource, Types.Idol[] idols)
        {
            this.idolSource = idolSource;
            this.idols = idols;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(idolSource);
            writer.WriteShort((short)idols.Length);
            foreach (var entry in idols)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

idolSource = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            idols = new Types.Idol[limit];
            for (int i = 0; i < limit; i++)
            {
                 idols[i] = ProtocolTypeManager.GetInstance<Types.Idol>(reader.ReadUShort());
                 idols[i].Deserialize(reader);
            }
            

}


}


}