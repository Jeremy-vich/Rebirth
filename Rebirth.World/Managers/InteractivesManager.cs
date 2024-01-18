using Rebirth.Common.Extensions;
using Rebirth.Common.GameData.D2O;
using Rebirth.Common.Protocol.Data;
using Rebirth.World.Datas.Interactives;
using Rebirth.World.Datas.Interactives.Types;
using Rebirth.World.Datas.Interactives.Types.Classic;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Managers
{
    public class InteractivesManager : DataManager<InteractivesManager>
    {
        private List<Interactive> _interactives;
        private List<InteractiveData> _interactivesData { get { return Starter.DatabaseWorld.Fetch<InteractiveData>(); } }
        private List<Waypoint> _waypoint;

        public void Init()
        {
            _interactives = ObjectDataManager.GetAll<Interactive>();
            _waypoint = ObjectDataManager.GetAll<Waypoint>();
        }

        public List<AbstractInteractive> GetInteractives(int mapId) => _interactivesData.FindAll(x => x.MapId == mapId).Select(x => _getInteractive(x)).ToList();

        private AbstractInteractive _getInteractive(InteractiveData data)
        =>  data.Type switch
            {
                Common.Protocol.Enums.InteractiveTypeEnum.Teleportation => new InteractiveTeleporter(data.Identifier, (uint) data.CellId, data.OnMap, data.param1, data.param2),
                Common.Protocol.Enums.InteractiveTypeEnum.Book => new InteractiveBook(data.Identifier, (uint) data.CellId, data.OnMap, data.param1),
                Common.Protocol.Enums.InteractiveTypeEnum.Atelier => new InteractiveAtelier(data.Identifier, (uint) data.CellId, data.param1, new uint[1] { (uint) data.param2 }, data.MapId),
                Common.Protocol.Enums.InteractiveTypeEnum.Ressource => new Ressource(data.Identifier, (uint) data.CellId, data.param1, new uint[1] { (uint) data.param2 }, data.MapId, data.OnMap),
                Common.Protocol.Enums.InteractiveTypeEnum.Zaap => new InteractiveZaap(data.Identifier, (uint)data.CellId),
                Common.Protocol.Enums.InteractiveTypeEnum.Zaapi => new InteractiveZaapi(data.Identifier, (uint)data.CellId, data.param2, data.MapId, data.OnMap),
                _ => new InteractiveDefault(data.Identifier, (uint)data.CellId, data.OnMap),
            };

        public Waypoint[] GetAllWaypointExcept(int mapId)
        {
            return (from x in _waypoint
                    where x.mapId != mapId
                    select x).ToArray();
        }

        public Waypoint GetWaypointByMap(int mapId)
        {
            return _waypoint.FirstOrDefault(x => x.mapId == mapId);
        }

        public InteractiveData GetDatasById(int id)
        {
            var datas = _interactivesData.FirstOrDefault(x => x.Id == id);
            if (datas == null)
                Console.WriteLine(string.Format("[World.Interactive] '{0}' don't work !", id));
            return datas;
        }
    }
}
