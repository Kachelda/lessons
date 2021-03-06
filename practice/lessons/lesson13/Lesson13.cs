﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public int Dimension { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        Board board;
        
        public Lesson13()
        {
            InitBoard();
            
            OnRunBoard();
        }

        public void InitBoard()
        {
            while (true)
            {
                int s;
                Console.WriteLine("Введите размерность игрового поля:");

                if (Int32.TryParse(Console.ReadLine(), out s) && s > 1)
                {
                    Dimension = s;
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка! Повторите ввод!");
                }
            }

            List<int> list = Enumerable.Range(0, Dimension * Dimension).ToList().Shuffle();
            
            
            board = new Board(Dimension);
            board.Initialization(list);
        }

        

        public void OnRunBoard()
        {
            X = Console.CursorLeft;
            Y = Console.CursorTop;

            PrintGrid();
            PrintTwoDimensional();

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

                Console.SetCursorPosition(X, Y);
                PrintGrid();
                PrintTwoDimensional();

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

        public void PrintGrid()
        {
            string g1 = "+-----+";
            string g2 = "|     |";

            for (int i = 0; i < Dimension * 4; i += 4)
            {
                for (int j = 0; j < Dimension * 6; j += 6)
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

        public void PrintTwoDimensional()
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