using Rebirth.Common.Extensions;
using Rebirth.World.Models;

namespace Rebirth.World.Managers
{
    public class SpellsManager : DataManager<SpellsManager>
    {
        public List<Spell> Get(int characterId) => Starter.DatabaseWorld.Fetch<Spell>("WHERE CharacterId=@0", characterId);
        public void Save(Spell spell) => Starter.DatabaseWorld.Save(spell);
        public void Delete(int id) => Starter.DatabaseWorld.Delete<Spell>(id);
    }
}
