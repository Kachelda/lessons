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
        CustomPoint CurrentPosition { get; set; }

        bool IsInPlace();

        Cell.ReturnValue TypeValue();
    }
}
