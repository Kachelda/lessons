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
        public EmptyCell(CustomValue value, CustomPoint currentPosition, int dimension)
            : base(value, currentPosition, dimension) { }
        
        public string GetValue()
        {
            return Data.GetDataStr();
        }

        public override ReturnValue TypeValue()
        {
            return ReturnValue.STRING;
        }

        public override CustomPoint FinalPosition()
        {
            return new CustomPoint(Dimension - 1, Dimension - 1);
        }
    }
}
