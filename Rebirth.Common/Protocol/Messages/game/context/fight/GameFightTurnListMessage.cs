


















// Generated on 01/30/2023 13:09:13
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightTurnListMessage : NetworkMessage
{

public const uint Id = 7290;
public uint MessageId
{
    get { return Id; }
}

public double[] ids;
        public double[] deadsIds;
        

public GameFightTurnListMessage()
{
}

public GameFightTurnListMessage(double[] ids, double[] deadsIds)
        {
            this.ids = ids;
            this.deadsIds = deadsIds;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)ids.Length);
            foreach (var entry in ids)
            {
                 writer.WriteDouble(entry);
            }
            writer.WriteShort((short)deadsIds.Length);
            foreach (var entry in deadsIds)
            {
                 writer.WriteDouble(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            ids = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 ids[i] = reader.ReadDouble();
            }
            limit = (ushort)reader.ReadUShort();
            deadsIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 deadsIds[i] = reader.ReadDouble();
            }
            

}


}


}