﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game15.GameData
{
    class Board
    {
        public List<Row> Rows { get; set; }

        public int Dimension { get; set; }

        public Cell EmptyCell { get; set; }

        public Board(int dimension)
        {
            Dimension = dimension;
            Rows = new List<Row>();
        }

        public void Initialization(List<int> list)
        {
            int emptyCellIndex = 0;
            Row row = new Row();
            foreach (int item in list)
            {
                int x = Rows.Count;
                int y = row.Cells.Count;
                if (item == emptyCellIndex)
                {
                    EmptyCell = new Cell(emptyCellIndex, new CustomPoint(x, y));
                    EmptyCell.IsEmpty = true;
                    row.Cells.Add(EmptyCell);
                }
                else
                {
                    row.Cells.Add(new Cell(item, new CustomPoint(x, y)));
                }
                if (row.Cells.Count == Dimension)
                {
                    Rows.Add(row);
                    row = new Row();
                }
            }
        }

        public void CheckWordBoard()
        {
            int counter = 1;
            foreach (var row in Rows)
            {
                foreach (var cell in row.Cells)
                {
                    if (Convert.ToInt32(cell.Data) == counter || cell.Data == 0)
                    {
                        counter++;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Игра окончена!");
            Console.ReadLine();
            Environment.Exit(0);
        }

        public void MoveLeft()
        {
            if (EmptyCell.CurrentPosition.Y != 0)
            {
                Rows[EmptyCell.CurrentPosition.X].Cells[EmptyCell.CurrentPosition.Y] = Rows[EmptyCell.CurrentPosition.X].Cells[EmptyCell.CurrentPosition.Y - 1];
                Rows[EmptyCell.CurrentPosition.X].Cells[EmptyCell.CurrentPosition.Y - 1] = EmptyCell;
                Rows[EmptyCell.CurrentPosition.X].Cells[EmptyCell.CurrentPosition.Y].CurrentPosition.Offset(0, 1);
                EmptyCell.CurrentPosition.Offset(0, -1);
            }
        }

        public void MoveRight()
        {
            if (EmptyCell.CurrentPosition.Y != Rows.Count - 1)
            {
                Rows[EmptyCell.CurrentPosition.X].Cells[EmptyCell.CurrentPosition.Y] = Rows[EmptyCell.CurrentPosition.X].Cells[EmptyCell.CurrentPosition.Y + 1];
                Rows[EmptyCell.CurrentPosition.X].Cells[EmptyCell.CurrentPosition.Y + 1] = EmptyCell;
                Rows[EmptyCell.CurrentPosition.X].Cells[EmptyCell.CurrentPosition.Y].CurrentPosition.Offset(0, -1);
                EmptyCell.CurrentPosition.Offset(0, 1);
            }
        }

        public void MoveUp()
        {
            if (EmptyCell.CurrentPosition.X != 0)
            {
                Rows[EmptyCell.CurrentPosition.X].Cells[EmptyCell.CurrentPosition.Y] = Rows[EmptyCell.CurrentPosition.X - 1].Cells[EmptyCell.CurrentPosition.Y];
                Rows[EmptyCell.CurrentPosition.X - 1].Cells[EmptyCell.CurrentPosition.Y] = EmptyCell;
                Rows[EmptyCell.CurrentPosition.X].Cells[EmptyCell.CurrentPosition.Y].CurrentPosition.Offset(1, 0);
                EmptyCell.CurrentPosition.Offset(-1, 0);
            }
        }

        public void MoveDown()
        {
            if (EmptyCell.CurrentPosition.X != Rows.Count - 1)
            {
                Rows[EmptyCell.CurrentPosition.X].Cells[EmptyCell.CurrentPosition.Y] = Rows[EmptyCell.CurrentPosition.X + 1].Cells[EmptyCell.CurrentPosition.Y];
                Rows[EmptyCell.CurrentPosition.X + 1].Cells[EmptyCell.CurrentPosition.Y] = EmptyCell;
                Rows[EmptyCell.CurrentPosition.X].Cells[EmptyCell.CurrentPosition.Y].CurrentPosition.Offset(-1, 0);
                EmptyCell.CurrentPosition.Offset(1, 0);
            }
        }
    }
}