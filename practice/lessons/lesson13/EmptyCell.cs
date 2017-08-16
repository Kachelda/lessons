using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_class.lessons.lesson13
{
    class EmptyCell: Cell, ICell
    {
        public EmptyCell(int value, Point cP)
        :base(value, cP)
        {
            data = value;
            CurrentPosition = cP;
        }
    }
}
