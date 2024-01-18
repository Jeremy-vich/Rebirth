

















// Generated on 01/12/2017 03:53:13
using System;
using System.Collections.Generic;
using Rebirth.Common.GameData.D2O;

namespace Rebirth.Common.Protocol.Data
{

    [D2oClass("NamingRules")]

    public class NamingRule : IDataObject
    {

        public const String MODULE = "NamingRules";
        public uint id;
        public uint minLength;
        public uint maxLength;
        public String regexp;



    }

}