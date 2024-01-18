using Rebirth.Common.Protocol.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.Common.Extensions
{
    public static class IntExtensions
    {
        public static int GetCellAfterChangeMap(this int id, MapNeighbour mapNeighbour) =>
            mapNeighbour switch
            {
                MapNeighbour.None => 0,
                MapNeighbour.Right => id - 13,
                MapNeighbour.Top => id + 532,
                MapNeighbour.Left => id + 13,
                MapNeighbour.Bottom => id - 532,
                _ => 0,
            };


    }
}
