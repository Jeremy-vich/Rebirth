


















// Generated on 01/30/2023 13:09:18
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class PartyFollowStatusUpdateMessage : AbstractPartyMessage
{

public const uint Id = 8754;
public uint MessageId
{
    get { return Id; }
}

public bool success;
        public bool isFollowed;
        public double followedId;
        

public PartyFollowStatusUpdateMessage()
{
}

public PartyFollowStatusUpdateMessage(uint partyId, bool success, bool isFollowed, double followedId)
         : base(partyId)
        {
            this.success = success;
            this.isFollowed = isFollowed;
            this.followedId = followedId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, success);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, isFollowed);
            writer.WriteByte(flag1);
            writer.WriteVarLong(followedId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            byte flag1 = reader.ReadByte();
            success = BooleanByteWrapper.GetFlag(flag1, 0);
            isFollowed = BooleanByteWrapper.GetFlag(flag1, 1);
            followedId = reader.ReadVarUhLong();
            

}


}


}