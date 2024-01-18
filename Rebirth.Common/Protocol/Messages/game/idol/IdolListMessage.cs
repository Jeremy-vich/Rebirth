


















// Generated on 01/30/2023 13:09:23
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class IdolListMessage : NetworkMessage
{

public const uint Id = 5456;
public uint MessageId
{
    get { return Id; }
}

public uint[] chosenIdols;
        public uint[] partyChosenIdols;
        public Types.PartyIdol[] partyIdols;
        

public IdolListMessage()
{
}

public IdolListMessage(uint[] chosenIdols, uint[] partyChosenIdols, Types.PartyIdol[] partyIdols)
        {
            this.chosenIdols = chosenIdols;
            this.partyChosenIdols = partyChosenIdols;
            this.partyIdols = partyIdols;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)chosenIdols.Length);
            foreach (var entry in chosenIdols)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)partyChosenIdols.Length);
            foreach (var entry in partyChosenIdols)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)partyIdols.Length);
            foreach (var entry in partyIdols)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            chosenIdols = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 chosenIdols[i] = reader.ReadVarUhShort();
            }
            limit = (ushort)reader.ReadUShort();
            partyChosenIdols = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 partyChosenIdols[i] = reader.ReadVarUhShort();
            }
            limit = (ushort)reader.ReadUShort();
            partyIdols = new Types.PartyIdol[limit];
            for (int i = 0; i < limit; i++)
            {
                 partyIdols[i] = ProtocolTypeManager.GetInstance<Types.PartyIdol>(reader.ReadUShort());
                 partyIdols[i].Deserialize(reader);
            }
            

}


}


}