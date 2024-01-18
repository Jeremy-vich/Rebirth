using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Command
{
    public class Parameter
    {
        public string Name;
        public object Value;
        public bool IsOptionnal;
        public Parameter(string name, bool isOptionnal) { Name = name; IsOptionnal = isOptionnal; }
    }
}
