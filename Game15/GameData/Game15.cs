using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Game15.GameData
{
    class Game15
    {
        public int Dimension { get; set; }

        Board board;

        public Game15()
        {
            InitBoard();

            OnRunBoard();
        }

        public void InitBoard()
        {
            ConsoleInput consoleInput = new ConsoleInput();

            int i;
            List<int> list = new List<int>();

            do
            {
                Console.WriteLine(
                    "Меню:\n1) Начать новую игру \n2) Продолжить ранее сохраненную игру \n3) Выйти из игры");
                i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Dimension = consoleInput.GetDimension();
                        list = Enumerable.Range(0, Dimension * Dimension).ToList().Shuffle();
                        break;
                    case 2:
                        if (File.Exists("Game15.txt"))
                        {
                            Dimension = consoleInput.GetFileDimension();
                            consoleInput.GetFileList(list);
                        }
                        else
                        {
                            Console.WriteLine("Сохраненной игры нет, начните новую!");
                        }
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ошибка! Выберите правильный пункт!");
                        break;
                }
                Console.Clear();
            } while (i != 1 && i != 2);
            
            //IInput fileInput = new FileInput();
            //Dimension = fileInput.GetDimension();
            
            board = new Board(Dimension);
            board.Initialization(list);
        }



        public void OnRunBoard()
        {
            var listOutput = new List<IOutput>();
            IOutput writeFile = new FileOutput();
            IOutput consoleOutput = new ConsoleOutput();
            listOutput.Add(writeFile);
            listOutput.Add(consoleOutput);
            foreach (IOutput output in listOutput)
            {
                output.OutputBoard(board);
            }
            
            CheckWordBoard();
            
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("передвигайте ячейки, используя стрелки на клавиатуре, либо нажмите 'Escape' для выхода из игры");

                ConsoleKeyInfo k = Console.ReadKey(true);

                if (k.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                else if (k.Key == ConsoleKey.LeftArrow)
                {
                    board.MoveLeft();
                }
                else if (k.Key == ConsoleKey.RightArrow)
                {
                    board.MoveRight();
                }
                else if (k.Key == ConsoleKey.UpArrow)
                {
                    board.MoveUp();
                }
                else if (k.Key == ConsoleKey.DownArrow)
                {
                    board.MoveDown();
                }
                else
                {
                    Console.WriteLine("Повторите ввод!");
                }

                consoleOutput.OutputBoard(board);
                writeFile.OutputBoard(board);
                CheckWordBoard();
          
            }
        }

        public void CheckWordBoard()
        {
            foreach (var row in board.Rows)
            {
                foreach (var cell in row.Cells)
                {
                    if (!cell.IsInPlace())
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

        
    }
}