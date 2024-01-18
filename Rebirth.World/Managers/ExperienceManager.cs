using Rebirth.Common.Extensions;
using Rebirth.Common.Protocol.Data;
using Rebirth.World.Enums;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Managers
{
    public class ExperienceManager : DataManager<ExperienceManager>
    {
        private List<Experience> _experiences = new();

        public void Init() => _experiences = Starter.DatabaseWorld.Fetch<Experience>();

        public int Get(ExperienceEnum expType, double exp)
        {
            switch (expType)
            {
                case ExperienceEnum.Character:
                    return _experiences.Last(x => x.Character <= exp && x.Character >= 0).Id;
                case ExperienceEnum.Job:
                    return _experiences.Last(x => x.Job <= exp && x.Job >= 0).Id;
                case ExperienceEnum.Drago:
                    return _experiences.Last(x => x.Dragodinde <= exp && x.Dragodinde >= 0).Id;
                case ExperienceEnum.Guild:
                    return _experiences.Last(x => x.Guilde <= exp && x.Guilde >= 0 ).Id;
                case ExperienceEnum.ObjVi:
                    return _experiences.Last(x => x.ObjetVivant <= exp && x.ObjetVivant >= 0 ).Id;
                case ExperienceEnum.Jcj:
                    return _experiences.Last(x => x.JCJ <= exp && x.JCJ >= 0).Id;
                default:
                    return 0;
            }
        }

        public double Get(ExperienceEnum expType, int level)
        {
            if (level > 200)
                level = 200;
            switch (expType)
            {
                case ExperienceEnum.Character:
                    return _experiences.Last(x => x.Id == level && x.Character >= 0).Character;
                case ExperienceEnum.Job:
                    return _experiences.Last(x => x.Id == level && x.Job >= 0).Job;
                case ExperienceEnum.Drago:
                    return _experiences.Last(x => x.Id == level && x.Dragodinde >= 0).Dragodinde;
                case ExperienceEnum.Guild:
                    return _experiences.Last(x => x.Id == level && x.Guilde >= 0).Guilde;
                case ExperienceEnum.ObjVi:
                    return _experiences.Last(x => x.Id == level && x.ObjetVivant >= 0).ObjetVivant;
                case ExperienceEnum.Jcj:
                    return _experiences.Last(x => x.Id == level && x.JCJ >= 0).JCJ;
                default:
                    return 0;
            }
        }

    }
}
