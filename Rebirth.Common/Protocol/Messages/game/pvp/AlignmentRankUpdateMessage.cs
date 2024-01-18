


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class AlignmentRankUpdateMessage : NetworkMessage
{

public const uint Id = 8954;
public uint MessageId
{
    get { return Id; }
}

public sbyte alignmentRank;
        public bool verbose;
        

public AlignmentRankUpdateMessage()
{
}

public AlignmentRankUpdateMessage(sbyte alignmentRank, bool verbose)
        {
            this.alignmentRank = alignmentRank;
            this.verbose = verbose;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(alignmentRank);
            writer.WriteBoolean(verbose);
            

}

public void Deserialize(IDataReader reader)
{

alignmentRank = reader.ReadSbyte();
            verbose = reader.ReadBoolean();
            

}


}


}