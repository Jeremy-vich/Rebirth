using Rebirth.Common.Extensions;
using Rebirth.Common.Protocol.Types;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rebirth.World.Managers
{
    public class CharacterManager : DataManager<CharacterManager>
    {
        public readonly Regex _nameCheckerRegex = new Regex("^[A-Z][a-z]{2,9}(?:-[A-Z][a-z]{2,9}|[a-z]{1,10})$", RegexOptions.Compiled);
        public List<Character> GetAll(int accId) => Starter.DatabaseWorld.Fetch<Character>("WHERE AccountId=@0", accId);
        public Character Get(int id)
        {
            var chr = Starter.DatabaseWorld.SingleOrDefault<Character>(id);
            chr.Init();
            return chr;
        }
        public Character? Get(string name) => Starter.DatabaseWorld.SingleOrDefault<Character>("WHERE Name=@0", name.ToLower());
        public bool HasName(string name) => Starter.DatabaseWorld.Fetch<Character>("WHERE Name=@0", name).Count > 0;
        public int Count(int accId) => Starter.DatabaseWorld.Fetch<Character>("WHERE AccountId=@0", accId).Count;
        public void Save(Character character) => Starter.DatabaseWorld.Save(character);
        public void Delete(Character character) => Starter.DatabaseWorld.Delete<Character>(character);
        public void Delete(int id) => Starter.DatabaseWorld.Delete<Character>(id);
    }
}
