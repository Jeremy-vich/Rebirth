


















// Generated on 01/30/2023 13:09:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class IdentificationSuccessMessage : NetworkMessage
{

public const uint Id = 3593;
public uint MessageId
{
    get { return Id; }
}

public bool hasRights;
        public bool hasConsoleRight;
        public bool wasAlreadyConnected;
        public bool isAccountForced;
        public string login;
        public Types.AccountTagInformation accountTag;
        public int accountId;
        public sbyte communityId;
        public double accountCreation;
        public double subscriptionEndDate;
        public byte havenbagAvailableRoom;
        

public IdentificationSuccessMessage()
{
}

public IdentificationSuccessMessage(bool hasRights, bool hasConsoleRight, bool wasAlreadyConnected, bool isAccountForced, string login, Types.AccountTagInformation accountTag, int accountId, sbyte communityId, double accountCreation, double subscriptionEndDate, byte havenbagAvailableRoom)
        {
            this.hasRights = hasRights;
            this.hasConsoleRight = hasConsoleRight;
            this.wasAlreadyConnected = wasAlreadyConnected;
            this.isAccountForced = isAccountForced;
            this.login = login;
            this.accountTag = accountTag;
            this.accountId = accountId;
            this.communityId = communityId;
            this.accountCreation = accountCreation;
            this.subscriptionEndDate = subscriptionEndDate;
            this.havenbagAvailableRoom = havenbagAvailableRoom;
        }
        

public void Serialize(IDataWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, hasRights);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, hasConsoleRight);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 2, wasAlreadyConnected);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 3, isAccountForced);
            writer.WriteByte(flag1);
            writer.WriteUTF(login);
            accountTag.Serialize(writer);
            writer.WriteInt(accountId);
            writer.WriteSbyte(communityId);
            writer.WriteDouble(accountCreation);
            writer.WriteDouble(subscriptionEndDate);
            writer.WriteByte(havenbagAvailableRoom);
            

}

public void Deserialize(IDataReader reader)
{

byte flag1 = reader.ReadByte();
            hasRights = BooleanByteWrapper.GetFlag(flag1, 0);
            hasConsoleRight = BooleanByteWrapper.GetFlag(flag1, 1);
            wasAlreadyConnected = BooleanByteWrapper.GetFlag(flag1, 2);
            isAccountForced = BooleanByteWrapper.GetFlag(flag1, 3);
            login = reader.ReadUTF();
            accountTag = new Types.AccountTagInformation();
            accountTag.Deserialize(reader);
            accountId = reader.ReadInt();
            communityId = reader.ReadSbyte();
            accountCreation = reader.ReadDouble();
            subscriptionEndDate = reader.ReadDouble();
            havenbagAvailableRoom = reader.ReadByte();
            

}


}


}