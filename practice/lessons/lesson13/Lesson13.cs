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
        List<int> list;
        
        public Lesson13()
        {
            board = new List<List<ICell>>();
            list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, -1 };

            InitBoard();
            OnRunBoard();
        }

        public void InitBoard()
        {
            //переносим в двумерный список
            for (int i = 0; i < 4; i++)
            {
               board.Add(new List<ICell>());
            
                for (int j = 0; j < 4; j++)
                {
                    int ram = new Random().Next(0, list.Count);
                    if (list[ram] == -1)
                    {
                        emptyCell = new EmptyCell(list[ram], new Point(i, j));
                        board[i].Add(emptyCell);
                    }
                    else
                    {
                        board[i].Add(new Cell(list[ram], new Point(i, j)));
                    }
                    list.Remove(list[ram]);
                }
            }
        }

        public void OnRunBoard()
        {
            string inputText;

            PrintTwoDimensional(board);
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
                    MoveLeft(board);
                }
                else if (inputText == EnumDirection.right.ToString())
                {
                    MoveRight(board);
                }
                else if (inputText == EnumDirection.up.ToString())
                {
                    MoveUp(board);
                }
                else if (inputText == EnumDirection.down.ToString())
                {
                    MoveDown(board);
                }
                else
                {
                    Console.WriteLine("Повторите ввод!");
                }

                PrintTwoDimensional(board);
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

        public void MoveLeft(List<List<ICell>> list)
        {
            if (emptyCell.CurrentPosition.Y != 0)
            {
                list[emptyCell.CurrentPosition.X][emptyCell.CurrentPosition.Y] = list[emptyCell.CurrentPosition.X][emptyCell.CurrentPosition.Y - 1];
                list[emptyCell.CurrentPosition.X][emptyCell.CurrentPosition.Y - 1] = emptyCell;
                list[emptyCell.CurrentPosition.X][emptyCell.CurrentPosition.Y].CurrentPosition.Offset(0, 1);
                emptyCell.CurrentPosition.Offset(0, -1);
            }
        }

        public void MoveRight(List<List<ICell>> list)
        {
            if (emptyCell.CurrentPosition.Y != list.Count - 1)
            {
                list[emptyCell.CurrentPosition.X][emptyCell.CurrentPosition.Y] = list[emptyCell.CurrentPosition.X][emptyCell.CurrentPosition.Y + 1];
                list[emptyCell.CurrentPosition.X][emptyCell.CurrentPosition.Y + 1] = emptyCell;
                list[emptyCell.CurrentPosition.X][emptyCell.CurrentPosition.Y].CurrentPosition.Offset(0, -1);
                emptyCell.CurrentPosition.Offset(0, 1);
            }
        }

        public void MoveUp(List<List<ICell>> list)
        {
            if (emptyCell.CurrentPosition.X != 0)
            {
                list[emptyCell.CurrentPosition.X][emptyCell.CurrentPosition.Y] = list[emptyCell.CurrentPosition.X - 1][emptyCell.CurrentPosition.Y];
                list[emptyCell.CurrentPosition.X - 1][emptyCell.CurrentPosition.Y] = emptyCell;
                list[emptyCell.CurrentPosition.X][emptyCell.CurrentPosition.Y].CurrentPosition.Offset(1, 0);
                emptyCell.CurrentPosition.Offset(-1, 0);
            }
        }

        public void MoveDown(List<List<ICell>> list)
        {
            if (emptyCell.CurrentPosition.X != list.Count - 1)
            {
                list[emptyCell.CurrentPosition.X][emptyCell.CurrentPosition.Y] = list[emptyCell.CurrentPosition.X + 1][emptyCell.CurrentPosition.Y];
                list[emptyCell.CurrentPosition.X + 1][emptyCell.CurrentPosition.Y] = emptyCell;
                list[emptyCell.CurrentPosition.X][emptyCell.CurrentPosition.Y].CurrentPosition.Offset(-1, 0);
                emptyCell.CurrentPosition.Offset(1, 0);
            }
        }

        public void PrintOneDimensional(List<ICell> list, string separator = "\t")
        {
            string result = "{" + string.Join(separator, ToListInt(list)) + "}";
            Console.Write("\n");
            Console.Write(result);
        }

        public List<int> ToListInt(List<ICell> list)
        {
            List<int> result = new List<int>();
            foreach (ICell cell in list)
            {
               result.Add(cell.getValue());
            }
            return result;
        }

        public void PrintTwoDimensional(List<List<ICell>> list)
        {
            Console.Write("{");

            for (int i = 0; i < list.Count; i++)
            {
                PrintOneDimensional(list[i]);
                if (i + 1 < list.Count)
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