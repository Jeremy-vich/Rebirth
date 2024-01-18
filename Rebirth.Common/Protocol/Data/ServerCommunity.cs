

















// Generated on 01/12/2017 03:53:14
using System;
using System.Collections.Generic;
using Rebirth.Common.GameData.D2O;

namespace Rebirth.Common.Protocol.Data
{

[D2oClass("ServerCommunities")]
    
public class ServerCommunity : IDataObject
{

public const String MODULE = "ServerCommunities";
        public int id;
        public uint nameId;
        public String shortId;
        public List<String> defaultCountries;
        public List<int> supportedLangIds;
        public int namingRulePlayerNameId;
        public int namingRuleGuildNameId;
        public int namingRuleAllianceNameId;
        public int namingRuleAllianceTagId;
        public int namingRulePartyNameId;
        public int namingRuleMountNameId;
        public int namingRuleNameGeneratorId;
        public int namingRuleAdminId;
        public int namingRuleModoId;

    }

}