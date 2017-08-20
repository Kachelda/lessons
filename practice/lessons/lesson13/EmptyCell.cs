﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_class.lessons.lesson13
{
    class EmptyCell: Cell, ICell
    {
        public EmptyCell(CustomValue value, CustomPoint cP)
        :base(value, cP)
        {
            data = value;
            CurrentPosition = cP;
        }

        public string getValue()
        {
            return data.GetDataStr();
        }

        public override ReturnValue typeValue()
        {
            return ReturnValue.STRING;
        }
    }
}
