using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game15.GameData
{
    interface ICell
    {
        bool IsEmpty { get; set; }

        int Data { get; set; }

        CustomPoint CurrentPosition { get; set; }
    }
}
