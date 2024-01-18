


















// Generated on 01/30/2023 13:09:29
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class TitlesAndOrnamentsListMessage : NetworkMessage
{

public const uint Id = 9899;
public uint MessageId
{
    get { return Id; }
}

public uint[] titles;
        public uint[] ornaments;
        public uint activeTitle;
        public uint activeOrnament;
        

public TitlesAndOrnamentsListMessage()
{
}

public TitlesAndOrnamentsListMessage(uint[] titles, uint[] ornaments, uint activeTitle, uint activeOrnament)
        {
            this.titles = titles;
            this.ornaments = ornaments;
            this.activeTitle = activeTitle;
            this.activeOrnament = activeOrnament;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort((short)titles.Length);
            foreach (var entry in titles)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)ornaments.Length);
            foreach (var entry in ornaments)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteVarShort((int)activeTitle);
            writer.WriteVarShort((int)activeOrnament);
            

}

public void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            titles = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 titles[i] = reader.ReadVarUhShort();
            }
            limit = (ushort)reader.ReadUShort();
            ornaments = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 ornaments[i] = reader.ReadVarUhShort();
            }
            activeTitle = reader.ReadVarUhShort();
            activeOrnament = reader.ReadVarUhShort();
            

}


}


}