using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Datas.Dialogs
{
    public interface IDialog
    {
        Client Client { get; set; }
        void Open();
        void Close();
    }
}
