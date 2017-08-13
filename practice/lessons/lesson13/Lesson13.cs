using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lesson_class.UtilsForLessons;

namespace lesson_class.lessons.lesson13
{
    class Lesson13
    {
        private EmptyCell emptyCell;

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

        private void InitBoard()
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
        
        private void OnRunBoard()
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
        
        private void CheckWordBoard()
        {
            int counter = 1;
            for (int i = 0; i < board.Count; i++)
            {
                for (int j = 0; j < board[i].Count; j++)
                {
                    if (board[i][j].getValue() == counter)//применить метод IsInPlace
                    {
                        counter++;
                        if (counter == board.Count - 1)
                        {
                            Console.WriteLine("Игра окончена!");
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
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
            if (emptyCell.currentPosition.Y != 0)
            {
                ICell cell = list[emptyCell.currentPosition.X][emptyCell.currentPosition.Y];
                list[emptyCell.currentPosition.X][emptyCell.currentPosition.Y] = list[emptyCell.currentPosition.X][emptyCell.currentPosition.Y - 1];
                list[emptyCell.currentPosition.X][emptyCell.currentPosition.Y - 1] =  cell;
                emptyCell.currentPosition = new Point(emptyCell.currentPosition.X, emptyCell.currentPosition.Y - 1);
                //emptyCell  = new EmptyCell(emptyCell.getValue(), new Point(emptyCell.currentPosition.X, emptyCell.currentPosition.Y - 1));
            }
        }

        public void MoveRight(List<List<ICell>> list)
        {
            if (emptyCell.currentPosition.Y != list.Count - 1)
            {
                ICell cell = list[emptyCell.currentPosition.X][emptyCell.currentPosition.Y];
                list[emptyCell.currentPosition.X][emptyCell.currentPosition.Y] = list[emptyCell.currentPosition.X][emptyCell.currentPosition.Y + 1];
                list[emptyCell.currentPosition.X][emptyCell.currentPosition.Y + 1] = cell;
                emptyCell.currentPosition = new Point(emptyCell.currentPosition.X, emptyCell.currentPosition.Y + 1);
                //emptyCell = new EmptyCell(emptyCell.getValue(), new Point(emptyCell.currentPosition.X, emptyCell.currentPosition.Y + 1));
            }
        }

        public void MoveUp(List<List<ICell>> list)
        {
            if (emptyCell.currentPosition.X != 0)
            {
                ICell cell = list[emptyCell.currentPosition.X][emptyCell.currentPosition.Y];
                list[emptyCell.currentPosition.X][emptyCell.currentPosition.Y] = list[emptyCell.currentPosition.X - 1][emptyCell.currentPosition.Y];
                list[emptyCell.currentPosition.X - 1][emptyCell.currentPosition.Y] = cell;
                emptyCell.currentPosition = new Point(emptyCell.currentPosition.X - 1, emptyCell.currentPosition.Y);
                //emptyCell = new EmptyCell(emptyCell.getValue(), new Point(emptyCell.currentPosition.X - 1, emptyCell.currentPosition.Y));
            }
        }

        public void MoveDown(List<List<ICell>> list)
        {
            if (emptyCell.currentPosition.X != list.Count - 1)
            {
                ICell cell = list[emptyCell.currentPosition.X][emptyCell.currentPosition.Y];
                list[emptyCell.currentPosition.X][emptyCell.currentPosition.Y] = list[emptyCell.currentPosition.X + 1][emptyCell.currentPosition.Y];
                list[emptyCell.currentPosition.X + 1][emptyCell.currentPosition.Y] = cell;
                emptyCell.currentPosition = new Point(emptyCell.currentPosition.X + 1, emptyCell.currentPosition.Y);
                //emptyCell = new EmptyCell(emptyCell.getValue(), new Point(emptyCell.currentPosition.X + 1, emptyCell.currentPosition.Y));
            }
        }

        private void PrintOneDimensional(List<ICell> list, string separator = "\t")
        {
            string result = "{" + string.Join(separator, ToListInt(list)) + "}";
            Console.Write("\n");
            Console.Write(result);
        }

        private List<int> ToListInt(List<ICell> list)
        {
            List<int> result = new List<int>();
            foreach (ICell cell in list)
            {
               result.Add(cell.getValue());
            }
            return result;
        }

        private void PrintTwoDimensional(List<List<ICell>> list)
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