using PetaPoco;
using Rebirth.Common.GameData.D2O;
using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Protocol.Types;
using Rebirth.World.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Models
{
    [TableName("Jobs")]
    public class Job
    {
        public int Id { get; set; }
        public double Exp { get; set; }
        public int JobId { get; set; }
        public int CharacterId { get; set; }
        [Ignore]
        public byte Level => (byte)ExperienceManager.Instance.Get(Enums.ExperienceEnum.Job, Exp);

        [Ignore]
        public double NextExp => ExperienceManager.Instance.Get(Enums.ExperienceEnum.Job, Level + 1);

        [Ignore]
        public double ActualExp => ExperienceManager.Instance.Get(Enums.ExperienceEnum.Job, Level);

        [Ignore]
        public JobExperience JobExperience => new((sbyte)JobId, Level, Exp, ActualExp, NextExp);

        [Ignore]
        public List<Skill> Skills => ObjectDataManager.GetAll<Skill>().FindAll(x => x.parentJobId == JobId && x.levelMin <= Level);

        [Ignore]
        public SkillActionDescription[] SkillActionDescriptions { get
            {
                List<SkillActionDescription> lst = new();
                foreach (var skill in Skills)
                {
                    if (skill.gatheredRessourceItem >= 0)
                        lst.Add(new SkillActionDescriptionCollect((uint)skill.id, 30, 1, (uint)(7 + ((Level - skill.levelMin + 1) / 10))));
                    else if (skill.craftableItemIds.Count > 0)
                        lst.Add(new SkillActionDescriptionCraft((uint)skill.id, 100));
                }
                return lst.ToArray();
            } }

        [Ignore]
        public JobDescription JobDescription => new((sbyte)JobId, SkillActionDescriptions);

        [Ignore]
        public JobCrafterDirectorySettings JobCrafterDirectorySetting => new((sbyte)JobId, 0, true);
    }
}
