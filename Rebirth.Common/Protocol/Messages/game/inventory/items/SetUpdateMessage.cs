


















// Generated on 01/30/2023 13:09:27
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class SetUpdateMessage : NetworkMessage
{

public const uint Id = 6258;
public uint MessageId
{
    get { return Id; }
}

public uint setId;
        public uint[] setObjects;
        public Types.ObjectEffect[] setEffects;
        

public SetUpdateMessage()
{
}

public SetUpdateMessage(uint setId, uint[] setObjects, Types.ObjectEffect[] setEffects)
        {
            this.setId = setId;
            this.setObjects = setObjects;
            this.setEffects = setEffects;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)setId);
            writer.WriteShort((short)setObjects.Length);
            foreach (var entry in setObjects)
            {
                 writer.WriteVarInt((int)entry);
            }
            writer.WriteShort((short)setEffects.Length);
            foreach (var entry in setEffects)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

setId = reader.ReadVarUhShort();
            var limit = (ushort)reader.ReadUShort();
            setObjects = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 setObjects[i] = reader.ReadVarUhInt();
            }
            limit = (ushort)reader.ReadUShort();
            setEffects = new Types.ObjectEffect[limit];
            for (int i = 0; i < limit; i++)
            {
                 setEffects[i] = ProtocolTypeManager.GetInstance<Types.ObjectEffect>(reader.ReadUShort());
                 setEffects[i].Deserialize(reader);
            }
            

}


}


}