﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
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

        public CustomValue data;

        public CustomPoint CurrentPosition { get; set; }

        public CustomPoint finalPosition()
        {
            if (data.GetDataStr() == "emp")
            {
                return new CustomPoint(3, 3);
            }
            return new CustomPoint((data.GetDataInt() - 1) / 4, GetHardCodeForY());
        }

        public int GetHardCodeForY()
        {
            switch (data.GetDataInt())
            {
                case 1:
                case 5:
                case 9:
                case 13:
                    return 0;
                case 2:
                case 6:
                case 10:
                case 14:
                    return 1;
                case 3:
                case 7:
                case 11:
                case 15:
                    return 2;
                case 4:
                case 8:
                case 12:
                    return 3;
                default:
                    return -1;
            }
        }

        public Cell(CustomValue value, CustomPoint cP)
        {
            data = value;
            CurrentPosition = cP;
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
