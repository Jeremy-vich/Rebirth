

















// Generated on 01/12/2017 03:53:15
using System;
using System.Collections.Generic;
using Rebirth.Common.GameData.D2O;

namespace Rebirth.Common.Protocol.Data
{

    [D2oClass("MapCoordinates")]

    public class MapCoordinates : IDataObject
    {

        public const String MODULE = "MapCoordinates";
        public uint compressedCoords;
        public List<int> mapIds;

        public static int getSignedValue(int param1)
        {
            var _loc2_ = (param1 & 32768) > 0;
            var _loc3_ = param1 & 32767;
            return _loc2_ ? 0 - _loc3_ : _loc3_;
        }

        public int X
        {
            get
            {
                return MapCoordinates.getSignedValue((int)(compressedCoords & 4294901760) >> 16);
            }

        }
        public int Y
        {
            get
            {
                return MapCoordinates.getSignedValue((int)compressedCoords & 65535);
            }

        }

    }

}