using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_class.lessons.lesson13
{
    class Board
    {
        public List<Row> Rows { get; set; }

        public int Dimension { get; set; }

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
                int y = row.Cells.Count;
                int x = Rows.Count;
                if (item == emptyCellIndex)
                {
                    EmptyCell emptyCell = new EmptyCell(new CustomValue(string.Empty), new CustomPoint(x, y), Dimension);
                    row.Cells.Add(emptyCell);
                }
                else
                {
                    row.Cells.Add(new Cell(new CustomValue(item), new CustomPoint(x, y), Dimension));
                }
                if (row.Cells.Count == Dimension)
                {
                    Rows.Add(row);
                    row = new Row();
                }
            }
        }
    }
}