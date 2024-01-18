


















// Generated on 01/30/2023 13:09:31
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class CharacterRemodelingInformation : AbstractCharacterInformation
{

public const short Id = 3502;
public override short TypeId
{
    get { return Id; }
}

public string name;
        public sbyte breed;
        public bool sex;
        public uint cosmeticId;
        public int[] colors;
        

public CharacterRemodelingInformation()
{
}

public CharacterRemodelingInformation(double id, string name, sbyte breed, bool sex, uint cosmeticId, int[] colors)
         : base(id)
        {
            this.name = name;
            this.breed = breed;
            this.sex = sex;
            this.cosmeticId = cosmeticId;
            this.colors = colors;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            writer.WriteSbyte(breed);
            writer.WriteBoolean(sex);
            writer.WriteVarShort((int)cosmeticId);
            writer.WriteShort((short)colors.Length);
            foreach (var entry in colors)
            {
                 writer.WriteInt(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            breed = reader.ReadSbyte();
            sex = reader.ReadBoolean();
            cosmeticId = reader.ReadVarUhShort();
            var limit = (ushort)reader.ReadUShort();
            colors = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 colors[i] = reader.ReadInt();
            }
            

}


}


}