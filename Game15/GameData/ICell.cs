﻿using System;
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
        CustomPoint CurrentPosition { get; set; }

        bool IsInPlace();

        Cell.ReturnValue TypeValue();
    }
}
