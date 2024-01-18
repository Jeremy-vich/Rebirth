


















// Generated on 01/30/2023 13:09:16
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{

public class ChangeThemeRequestMessage : NetworkMessage
{

public const uint Id = 451;
public uint MessageId
{
    get { return Id; }
}

public sbyte theme;
        

public ChangeThemeRequestMessage()
{
}

public ChangeThemeRequestMessage(sbyte theme)
        {
            this.theme = theme;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSbyte(theme);
            

}

public void Deserialize(IDataReader reader)
{

theme = reader.ReadSbyte();
            

}


}


}