using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_class.lessons.lesson13
{
    interface ICell
    {
        Point CurrentPosition { get; set; }

        int getValue();

        bool IsInPlace();
    }
}
