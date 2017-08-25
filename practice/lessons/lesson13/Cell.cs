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

        public int Dimension { get; set; }

        public CustomValue Data { get; set; }

        public CustomPoint CurrentPosition { get; set; }

        public virtual CustomPoint FinalPosition()
        {
            return new CustomPoint((Data.GetDataInt() - 1) / Dimension, ((Data.GetDataInt() + 1) % Dimension + Dimension - 2) % Dimension);
        }
        
        public Cell(CustomValue value, CustomPoint currentPosition, int dimension)
        {
            Data = value;
            CurrentPosition = currentPosition;
            Dimension = dimension;
        }

        public bool IsInPlace()
        {
            return CurrentPosition.Equals(FinalPosition());
        }

        public int GetValue()
        {
            return Data.GetDataInt();
        }

        public virtual ReturnValue TypeValue()
        {
            return ReturnValue.INT;
        }
    }
}
