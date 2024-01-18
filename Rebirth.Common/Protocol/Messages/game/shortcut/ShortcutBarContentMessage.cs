


















// Generated on 01/30/2023 13:09:28
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ShortcutBarContentMessage : NetworkMessage
{

public const uint Id = 3749;
public uint MessageId
{
    get { return Id; }
}

public sbyte barType;
        public Types.Shortcut[] shortcuts;
        

public ShortcutBarContentMessage()
{
}

public ShortcutBarContentMessage(sbyte barType, Types.Shortcut[] shortcuts)
        {
            this.barType = barType;
            this.shortcuts = shortcuts;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(barType);
            writer.WriteShort((short)shortcuts.Length);
            foreach (var entry in shortcuts)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

barType = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            shortcuts = new Types.Shortcut[limit];
            for (int i = 0; i < limit; i++)
            {
                 shortcuts[i] = ProtocolTypeManager.GetInstance<Types.Shortcut>(reader.ReadUShort());
                 shortcuts[i].Deserialize(reader);
            }
            

}


}


}