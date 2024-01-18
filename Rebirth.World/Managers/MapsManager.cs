using Rebirth.Common.Extensions;
using Rebirth.Common.GameData.D2O;
using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Protocol.Enums;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Managers
{
    public class MapsManager : DataManager<MapsManager>
    {
        private List<Map> _maps = new();

        public Map? Get(int id)
        {
            Map? map = _maps.FirstOrDefault(m => m.Template.Id == id);
            if (map == null)
            {
                var template = Common.GameData.Maps.MapsManager.GetMapFromId(id);
                if (template == null)
                    return null;
                var position = ObjectDataManager.Get<MapPosition>(id);
                map = new Map(template, position);
                _maps.Add(map);
            }
            return map;
        }

        public Map? Get(Map nMap, MapNeighbour dir)
        {
            var mapId = 0;
            MapCoordinates coord;
            switch (dir)
            {
                case MapNeighbour.Right:
                    coord = ObjectDataManager.Get<MapCoordinates>((getCompressedValue(nMap.Position.posX + 1) << 16) + getCompressedValue(nMap.Position.posY));
                    break;
                case MapNeighbour.Top:
                    coord = ObjectDataManager.Get<MapCoordinates>((getCompressedValue(nMap.Position.posX) << 16) + getCompressedValue(nMap.Position.posY - 1));
                    break;
                case MapNeighbour.Left:
                    coord = ObjectDataManager.Get<MapCoordinates>((getCompressedValue(nMap.Position.posX - 1) << 16) + getCompressedValue(nMap.Position.posY));
                    break;
                case MapNeighbour.Bottom:
                    coord = ObjectDataManager.Get<MapCoordinates>((getCompressedValue(nMap.Position.posX) << 16) + getCompressedValue(nMap.Position.posY + 1));
                    break;
                default:
                    return null;
            }
            if(coord == null) return null;
            foreach (var item in coord.mapIds)
            {
                var m = ObjectDataManager.Get<MapPosition>(item);
                if (m.worldMap == nMap.Position.worldMap)
                    mapId = m.id; 
            }
            return Get(mapId);
        }

        public uint getCompressedValue(int param1)
        {
            return param1 < 0 ? 32768 | (uint)param1 & 32767 : (uint)param1 & 32767;
        }
    }
}
