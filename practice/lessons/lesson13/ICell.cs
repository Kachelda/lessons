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

        CustomValue getValue();

        bool IsInPlace();
    }

    interface ICell<T>
    {
        CustomPoint CurrentPosition { get; set; }

        CustomValueT<T> getValue();

        bool IsInPlace();
    }
}
