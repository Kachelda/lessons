﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lesson_class.UtilsForLessons;

namespace lesson_class.lessons
{
    class Lesson12
    {
        const int counterForFinish = 10;
        const string wordForExit = "exit";// слово для выхода из игры

        List<List<string>> listfinal;
        List<string> list;
        List<string> listCharacters;
        List<string> listCharactersForRandom;
        
        int counter = 0;//счетчик правильных слов
        

        public Lesson12()
        {
            listfinal = new List<List<string>>();
            listCharacters = new List<string>();
            listCharactersForRandom = new List<string>();
            list = new List<string>
            { "сок", "сом", "кум", "ком", "кол", "кор", "сор",
              "сук", "мор", "мул", "мак", "мир", "лом", "лук",
              "лак", "рок", "ром", "рак", "рис", "аул", "оса"};
           
            initField();
            onRun();
        }

        private void initField()
        {
            //собираем буквы в список
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Length; j++)
                {
                    if (Utils.CountContains(listCharactersForRandom, list[i][j].ToString()) == 0)
                    {
                        listCharactersForRandom.Add(list[i][j].ToString());
                    }
                }
            }

            //используем рандом
            for (int i = listCharactersForRandom.Count - 1; i >= 0; i--)
            {
                int ram = new Random().Next(0, i);
                listCharacters.Add(listCharactersForRandom[ram]);
                listCharactersForRandom.Remove(listCharactersForRandom[ram]);
            }

            //переносим в двумерный список
            int ind = 0;
            for (int i = 0; i < 3; i++)
            {
                listfinal.Add(new List<string>());

                for (int j = 0; j < 3; j++)
                {
                    listfinal[i].Add(listCharacters[ind]);
                    ind++;
                }
            }
        }

        private void onRun()
        {
            int lineNumber;
            string line;

            while (true)
            {
                CurrentData();
                
                Console.WriteLine("Введите 'row' или 'column' для изменения игрового поля, либо 'exit' для выхода из игры :");
                line = Console.ReadLine();

                if (line == wordForExit)
                {
                    Environment.Exit(0);
                }

                else if (line == RowCol.row.ToString())
                {
                    Console.WriteLine("Введите номер <row> от 0 до 2 :");
                    if (Int32.TryParse(Console.ReadLine(), out lineNumber) && lineNumber >= 0 && lineNumber <= 2)
                    {
                        Console.WriteLine("Введите направление 'left' или 'right' :");
                        string way1 = Console.ReadLine();

                        if (way1 == WayRowCol.left.ToString())
                        {
                            ChangesLogic.ChangeRowLeft(listfinal, lineNumber);
                        }

                        else if (way1 == WayRowCol.right.ToString())
                        {
                            ChangesLogic.ChangeRowRight(listfinal, lineNumber);
                        }

                        else
                        {
                            Console.WriteLine("Повторите ввод!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Повторите ввод!");
                    }
                }

                else if (line == RowCol.column.ToString())
                {
                    Console.WriteLine("Введите номер <column> от 0 до 2 :");
                    if (Int32.TryParse(Console.ReadLine(), out lineNumber) && lineNumber >= 0 && lineNumber <= 2)
                    {
                        Console.WriteLine("Введите направление 'up' или 'dowm' :");
                        string way1 = Console.ReadLine();

                        if (way1 == WayRowCol.up.ToString())
                        {
                            ChangesLogic.ChangeColUp(listfinal, lineNumber);
                        }

                        else if (way1 == WayRowCol.down.ToString())
                        {
                            ChangesLogic.ChangeColDown(listfinal, lineNumber);
                        }

                        else
                        {
                            Console.WriteLine("Повторите ввод!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Повторите ввод!");
                    }
                }
                else
                {
                    Console.WriteLine("Повторите ввод!");
                }
            }
        }

        private void CurrentData()
        {
            Utils.PrintTwoDimensional(listfinal);
            CheckWord();
            Console.WriteLine("Количество правильных слов = {0}", counter);
        }

        private void CheckWord()
        {
            string str = listfinal[1][0] + listfinal[1][1] + listfinal[1][2];
            if (Utils.CountContains(list, str) == 1)
            {
                list.Remove(str);
                counter++;
                if (counter == counterForFinish)
                {
                    Console.WriteLine("Игра окончена!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
        }
        
        public enum RowCol
        {
            row,
            column
        }

        public enum WayRowCol
        {
            up,
            down,
            left,
            right
        }
    }
}
