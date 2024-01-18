


















// Generated on 01/30/2023 13:09:21
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildInformationsGeneralMessage : NetworkMessage
{

public const uint Id = 1416;
public uint MessageId
{
    get { return Id; }
}

public bool abandonnedPaddock;
        public byte level;
        public double expLevelFloor;
        public double experience;
        public double expNextLevelFloor;
        public int creationDate;
        public uint nbTotalMembers;
        public uint nbConnectedMembers;
        

public GuildInformationsGeneralMessage()
{
}

public GuildInformationsGeneralMessage(bool abandonnedPaddock, byte level, double expLevelFloor, double experience, double expNextLevelFloor, int creationDate, uint nbTotalMembers, uint nbConnectedMembers)
        {
            this.abandonnedPaddock = abandonnedPaddock;
            this.level = level;
            this.expLevelFloor = expLevelFloor;
            this.experience = experience;
            this.expNextLevelFloor = expNextLevelFloor;
            this.creationDate = creationDate;
            this.nbTotalMembers = nbTotalMembers;
            this.nbConnectedMembers = nbConnectedMembers;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(abandonnedPaddock);
            writer.WriteByte(level);
            writer.WriteVarLong(expLevelFloor);
            writer.WriteVarLong(experience);
            writer.WriteVarLong(expNextLevelFloor);
            writer.WriteInt(creationDate);
            writer.WriteVarShort((int)nbTotalMembers);
            writer.WriteVarShort((int)nbConnectedMembers);
            

}

public void Deserialize(IDataReader reader)
{

abandonnedPaddock = reader.ReadBoolean();
            level = reader.ReadByte();
            expLevelFloor = reader.ReadVarUhLong();
            experience = reader.ReadVarUhLong();
            expNextLevelFloor = reader.ReadVarUhLong();
            creationDate = reader.ReadInt();
            nbTotalMembers = reader.ReadVarUhShort();
            nbConnectedMembers = reader.ReadVarUhShort();
            

}


}


}