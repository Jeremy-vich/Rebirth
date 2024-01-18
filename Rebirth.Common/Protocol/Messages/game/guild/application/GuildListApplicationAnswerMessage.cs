


















// Generated on 01/30/2023 13:09:22
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildListApplicationAnswerMessage : PaginationAnswerAbstractMessage
{

public const uint Id = 9667;
public uint MessageId
{
    get { return Id; }
}

public Types.GuildApplicationInformation[] applies;
        

public GuildListApplicationAnswerMessage()
{
}

public GuildListApplicationAnswerMessage(double offset, uint count, uint total, Types.GuildApplicationInformation[] applies)
         : base(offset, count, total)
        {
            this.applies = applies;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)applies.Length);
            foreach (var entry in applies)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            applies = new Types.GuildApplicationInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 applies[i] = new Types.GuildApplicationInformation();
                 applies[i].Deserialize(reader);
            }
            

}


}


}