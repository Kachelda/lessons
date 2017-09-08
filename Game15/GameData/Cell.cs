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
        public bool IsEmpty { get; set; }

        public int Data { get; set; }

        public CustomPoint CurrentPosition { get; set; }

        public Cell(int value, CustomPoint currentPosition)
        {
            Data = value;
            CurrentPosition = currentPosition;
        }

        public override string ToString()
        {
            if (IsEmpty)
            {
                return String.Empty;
            }
            else
            {
                return Data.ToString();
            }
   
        }

        
    }
}
