﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_class.lessons.lesson13
{
    class Board
    {
        public List<Row> Rows { get; set; }

        public Board()
        {
            Rows = new List<Row>();
        }
    }
}