using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game15.GameData
{
    class ConsoleOutput: IOutput
    {
        public int X { get; set; }
        public int Y { get; set; }

        public ConsoleOutput()
        {
            X = Console.CursorLeft;
            Y = Console.CursorTop;
        }

        public void OutputBoard(Board board)
        {
            PrintGrid(board.Dimension);
            PrintTwoDimensional(board);
        }

        public void PrintGrid(int dimension)
        {
            string g1 = "+-----+";
            string g2 = "|     |";

            for (int i = 0; i < dimension * 4; i += 4)
            {
                for (int j = 0; j < dimension * 6; j += 6)
                {
                    Console.SetCursorPosition(X + j, Y + i);
                    Console.WriteLine(g1);
                    Console.SetCursorPosition(X + j, Y + i + 1);
                    Console.WriteLine(g2);
                    Console.SetCursorPosition(X + j, Y + i + 2);
                    Console.WriteLine(g2);
                    Console.SetCursorPosition(X + j, Y + i + 3);
                    Console.WriteLine(g2);
                    Console.SetCursorPosition(X + j, Y + i + 4);
                    Console.WriteLine(g1);
                }
            }
        }

        public void PrintOneDimensional(Row row, int counterY)
        {
            int counterX = 0;
            foreach (var cell in row.Cells)
            {
                switch (cell.TypeValue())
                {
                    case Cell.ReturnValue.INT:
                        Console.SetCursorPosition(X + 3 + counterX, Y + 2 + counterY);
                        Console.Write(((Cell)cell).GetValue());
                        break;
                    case Cell.ReturnValue.STRING:
                        Console.SetCursorPosition(X + 3 + counterX, Y + 2 + counterY);
                        Console.Write(((EmptyCell)cell).GetValue());
                        break;
                }
                counterX += 6;
            }
        }

        public void PrintTwoDimensional(Board board)
        {
            int counterY = 0;
            foreach (var row in board.Rows)
            {
                PrintOneDimensional(row, counterY);
                Console.Write("\n");
                counterY += 4;
            }
            Console.WriteLine();
        }
    }
}
