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
        
        const string wordForExit = "exit";// слово для выхода из игры

        List<List<ICell>> board;
        
        public Lesson13()
        {
            board = new List<List<ICell>>();
            
            InitBoard();
            OnRunBoard();
        }

        public void InitBoard()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, -1 };
            //переносим в двумерный список
            for (int i = 0; i < 4; i++)
            {
               board.Add(new List<ICell>());
            
                for (int j = 0; j < 4; j++)
                {
                    int ram = new Random().Next(0, list.Count);
                    if (list[ram] == -1)
                    {
                        emptyCell = new EmptyCell(new CustomValue("111"), new CustomPoint(i, j));
                        board[i].Add(emptyCell);
                    }
                    else
                    {
                        board[i].Add(new Cell(new CustomValue(list[ram]), new CustomPoint(i, j)));
                    }
                    list.Remove(list[ram]);
                }
            }
        }

        public void OnRunBoard()
        {
            string inputText;

            PrintTwoDimensional();
            CheckWordBoard();

            while (true)
            {
                Console.WriteLine("Введите 'left', 'right', 'up' или 'down' чтобы сделать ход, либо 'exit' для выхода из игры :");
                inputText = Console.ReadLine();

                if (inputText == wordForExit)
                {
                    Environment.Exit(0);
                }
                else if (inputText == EnumDirection.left.ToString())
                {
                    MoveLeft();
                }
                else if (inputText == EnumDirection.right.ToString())
                {
                    MoveRight();
                }
                else if (inputText == EnumDirection.up.ToString())
                {
                    MoveUp();
                }
                else if (inputText == EnumDirection.down.ToString())
                {
                    MoveDown();
                }
                else
                {
                    Console.WriteLine("Повторите ввод!");
                }

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
                    if (!board[i][j].IsInPlace()) //применить метод IsInPlace
                    {
                        return;
                    }
                }
            }
            Console.WriteLine("Игра окончена!");
            Console.ReadLine();
            Environment.Exit(0);
        }

        enum EnumDirection
        {
            up,
            down,
            left,
            right
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

        public void PrintOneDimensional(List<CustomValue> list, string separator = "\t")
        {
            foreach (CustomValue custom in list)
            {
                Console.WriteLine(custom.GetValue());
            }
            string result = "{" + string.Join(separator, ToListCustomValues(list)) + "}";
            Console.Write("\n");
            Console.Write(result);
        }

        public List<CustomValue> ToListCustomValues(List<ICell> list)
        {
            List<CustomValue> result = new List<CustomValue>();
            foreach (ICell cell in list)
            {
                result.Add(cell.getValue());
            }
            return result;
        }

        public void PrintTwoDimensional()
        {
            Console.Write("{");

            for (int i = 0; i < board.Count; i++)
            {
                PrintOneDimensional(board[i]);
                if (i + 1 < board.Count)
                {
                    Console.Write(",");
                    Console.Write("\n");
                }
            }
            Console.Write("\n");
            Console.Write("}");
            Console.WriteLine();
        }
    }
}