using Rebirth.Common.GameData.D2O;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.Common.GameData.D2O
{
    public class Rectangle : IDataObject
    {
        public int bottom;
        public Point bottomRight;
        public int height;
        public int left;
        public int right;
        public Point size;
        public int top;
        public Point topLeft;
        public int width;
        public int x;
        public int y;
    }
}
