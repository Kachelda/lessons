using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_class.lessons.lesson13
{
    class Row
    {
        public Row()
        {
            Cells = new List<ICell>();
        }

        public List<ICell> Cells { get; set; }
    }
}
