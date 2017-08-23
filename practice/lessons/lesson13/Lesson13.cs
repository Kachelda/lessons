using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Configuration;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using lesson_class.UtilsForLessons;

namespace lesson_class.lessons.lesson13
{
    class Lesson13
    {
        public EmptyCell emptyCell;
        
        public int dimension;

        public int x;
        public int y;

        List<List<ICell>> board;
        
        public Lesson13()
        {
            board = new List<List<ICell>>();
            
            InitBoard();
            OnRunBoard();
        }

        public void InitBoard()
        {
            while (true)
            {
                Console.WriteLine("Введите размерность игрового поля:");
                if (Int32.TryParse(Console.ReadLine(), out dimension) && dimension > 1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка! Повторите ввод!");
                }
            }

            List<int> list = new List<int>() {-1};
            for (int i = 1; i < dimension * dimension; i++)
            {
                list.Add(i);
            }
            
            //переносим в двумерный список
            for (int i = 0; i < dimension; i++)
            {
               board.Add(new List<ICell>());
            
                for (int j = 0; j < dimension; j++)
                {
                    int ram = new Random().Next(0, list.Count);
                    if (list[ram] == -1)
                    {
                        emptyCell = new EmptyCell(new CustomValue("emp"), new CustomPoint(i, j), dimension);
                        board[i].Add(emptyCell);
                    }
                    else
                    {
                        board[i].Add(new Cell(new CustomValue(list[ram]), new CustomPoint(i, j), dimension));
                    }
                    list.Remove(list[ram]);
                }
            }
        }

        public void OnRunBoard()
        {
            x = Console.CursorLeft;
            y = Console.CursorTop;

            PrintTwoDimensional();
            CheckWordBoard();

            while (true)
            {
                Console.WriteLine("передвигайте ячейки, используя стрелки на клавиатуре, либо нажмите 'Escape' для выхода из игры");
                
                ConsoleKeyInfo k = Console.ReadKey(true);

                if (k.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                else if (k.Key == ConsoleKey.LeftArrow)
                {
                    MoveLeft();
                }
                else if (k.Key == ConsoleKey.RightArrow)
                {
                    MoveRight();
                }
                else if (k.Key == ConsoleKey.UpArrow)
                {
                    MoveUp();
                }
                else if (k.Key == ConsoleKey.DownArrow)
                {
                    MoveDown();
                }
                else
                {
                    Console.WriteLine("Повторите ввод!");
                }

                Console.SetCursorPosition(x, y);
                PrintTwoDimensional();
                
                CheckWordBoard();
            }
        }

        public void CheckWordBoard()
        {
            for (int i = 0; i < board.Count; i++)
            {
                for (int j = 0; j < board[i].Count; j++)
                {
                    if (!board[i][j].IsInPlace())
                    {
                        return;
                    }
                }
            }
            Console.WriteLine("Игра окончена!");
            Console.ReadLine();
            Environment.Exit(0);
        }

        public void MoveLeft()
        {
            if (emptyCell.CurrentPosition.Y != 0)
            {
                board[emptyCell.CurrentPosition.X][emptyCell.CurrentPosition.Y] = board[emptyCell.CurrentPosition.X][emptyCell.CurrentPosition.Y - 1];
                board[emptyCell.CurrentPosition.X][emptyCell.CurrentPosition.Y - 1] = emptyCell;
                board[emptyCell.CurrentPosition.X][emptyCell.CurrentPosition.Y].CurrentPosition.Offset(0, 1);
                emptyCell.CurrentPosition.Offset(0, -1);
            }
        }

        public void MoveRight()
        {
            if (emptyCell.CurrentPosition.Y != board.Count - 1)
            {
                board[emptyCell.CurrentPosition.X][emptyCell.CurrentPosition.Y] = board[emptyCell.CurrentPosition.X][emptyCell.CurrentPosition.Y + 1];
                board[emptyCell.CurrentPosition.X][emptyCell.CurrentPosition.Y + 1] = emptyCell;
                board[emptyCell.CurrentPosition.X][emptyCell.CurrentPosition.Y].CurrentPosition.Offset(0, -1);
                emptyCell.CurrentPosition.Offset(0, 1);
            }
        }

        public void MoveUp()
        {
            if (emptyCell.CurrentPosition.X != 0)
            {
                board[emptyCell.CurrentPosition.X][emptyCell.CurrentPosition.Y] = board[emptyCell.CurrentPosition.X - 1][emptyCell.CurrentPosition.Y];
                board[emptyCell.CurrentPosition.X - 1][emptyCell.CurrentPosition.Y] = emptyCell;
                board[emptyCell.CurrentPosition.X][emptyCell.CurrentPosition.Y].CurrentPosition.Offset(1, 0);
                emptyCell.CurrentPosition.Offset(-1, 0);
            }
        }

        public void MoveDown()
        {
            if (emptyCell.CurrentPosition.X != board.Count - 1)
            {
                board[emptyCell.CurrentPosition.X][emptyCell.CurrentPosition.Y] = board[emptyCell.CurrentPosition.X + 1][emptyCell.CurrentPosition.Y];
                board[emptyCell.CurrentPosition.X + 1][emptyCell.CurrentPosition.Y] = emptyCell;
                board[emptyCell.CurrentPosition.X][emptyCell.CurrentPosition.Y].CurrentPosition.Offset(-1, 0);
                emptyCell.CurrentPosition.Offset(1, 0);
            }
        }

        public void PrintOneDimensional(List<ICell> list)
        {
            string result = "{";
            Console.WriteLine();
            for (int i = 0; i < list.Count; i++)
            {
                ICell cell = list[i];
                switch (cell.typeValue())
                {
                    case Cell.ReturnValue.INT:
                        result += ((Cell) cell).getValue();
                        break;
                    case Cell.ReturnValue.STRING:
                        result += ((EmptyCell) cell).getValue();
                        break;
                }
                if (i + 1 < list.Count)
                {
                    result += " \t ";
                }
            }
            result += "} \n";
            Console.Write(result);
        }

        public void PrintTwoDimensional()
        {
            Console.Write("{");

            for (int i = 0; i < board.Count; i++)
            {
                PrintOneDimensional(board[i]);
                if (i + 1 < board.Count)
                {
                    Console.Write("\n");
                }
            }
            Console.Write("\n");
            Console.Write("}");
            Console.WriteLine();
        }
    }
}