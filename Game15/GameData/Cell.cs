using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game15.GameData
{
    class Cell: ICell
    {
        public int Dimension { get; set; }

        public string Data { get; set; }

        public CustomPoint CurrentPosition { get; set; }

        public Cell(string value, CustomPoint currentPosition, int dimension)
        {
            Data = value;
            CurrentPosition = currentPosition;
            Dimension = dimension;
        }
    }
}
