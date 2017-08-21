using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_class.lessons.lesson13
{
    class Cell: ICell
    {
        public enum ReturnValue
        {
            INT,
            STRING
        }

        public int dimension;

        public CustomValue data;

        public CustomPoint CurrentPosition { get; set; }

        public virtual CustomPoint finalPosition()
        {
            return new CustomPoint((data.GetDataInt() - 1) / dimension, ((data.GetDataInt() + 1) % dimension + dimension - 2) % dimension);
        }
        
        public Cell(CustomValue value, CustomPoint cP, int dimension)
        {
            data = value;
            CurrentPosition = cP;
            this.dimension = dimension;
        }

        public bool IsInPlace()
        {
            return CurrentPosition.Equals(finalPosition());
        }

        public int getValue()
        {
            return data.GetDataInt();
        }

        public virtual ReturnValue typeValue()
        {
            return ReturnValue.INT;
        }
    }
}
