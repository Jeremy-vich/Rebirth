using Rebirth.Common.Extensions;
using Rebirth.Common.GameData.D2O;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Managers
{
    public class JobsManager : DataManager<JobsManager>
    {

        public List<Job> Get(int characterId) => Starter.DatabaseWorld.Fetch<Job>("WHERE CharacterId=@0", characterId);

        public void Create(int characterId)
        {
            var jobs = ObjectDataManager.GetAll<Common.Protocol.Data.Job>();
            jobs.RemoveAt(0);
            foreach (var item in jobs)
                Starter.DatabaseWorld.Save(new Job()
                {
                     CharacterId = characterId,
                     JobId = item.id,
                     Exp = 0
                });
        }
    }
}
