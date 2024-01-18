


















// Generated on 01/30/2023 13:09:14
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class DiceRollRequestMessage : NetworkMessage
{

public const uint Id = 1047;
public uint MessageId
{
    get { return Id; }
}

public uint dice;
        public uint faces;
        public sbyte channel;
        

public DiceRollRequestMessage()
{
}

public DiceRollRequestMessage(uint dice, uint faces, sbyte channel)
        {
            this.dice = dice;
            this.faces = faces;
            this.channel = channel;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)dice);
            writer.WriteVarInt((int)faces);
            writer.WriteSbyte(channel);
            

}

public void Deserialize(IDataReader reader)
{

dice = reader.ReadVarUhInt();
            faces = reader.ReadVarUhInt();
            channel = reader.ReadSbyte();
            

}


}


}