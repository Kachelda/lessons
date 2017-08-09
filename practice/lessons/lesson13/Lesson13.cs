using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lesson_class.UtilsForLessons;

namespace lesson_class.lessons.lesson13
{
    class Lesson13
    {
        const int counterForFinish = 16;
        const string wordForExit = "exit";// слово для выхода из игры

        List<List<int>> listfinal;
        List<int> list;
        List<int> listForCheck1;
        List<int> listForCheck2;
        List<int> listCharacters;

        int empty = -1;

        public Lesson13()
        {
            listfinal = new List<List<int>>();
            listCharacters = new List<int>();
            list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, -1 };

            initField();
            onRun();
        }

        private void initField()
        {
            //используем рандом
            for (int i = list.Count - 1; i >= 0; i--)
            {
                int ram = new Random().Next(0, i);
                listCharacters.Add(list[ram]);
                list.Remove(list[ram]);
            }

            //переносим в двумерный список
            int ind = 0;
            for (int i = 0; i < 4; i++)
            {
                listfinal.Add(new List<int>());

                for (int j = 0; j < 4; j++)
                {
                    listfinal[i].Add(listCharacters[ind]);
                    ind++;
                }
            }
        }

        private void onRun()
        {
            string inputText;

            Utils.PrintTwoDimensional(listfinal);
            CheckWord();

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
                    MoveLeft(listfinal);
                }
                else if (inputText == EnumDirection.right.ToString())
                {
                    MoveRight(listfinal);
                }
                else if (inputText == EnumDirection.up.ToString())
                {
                    MoveUp(listfinal);
                }
                else if (inputText == EnumDirection.down.ToString())
                {
                    MoveDown(listfinal);
                }
                else
                {
                    Console.WriteLine("Повторите ввод!");
                }

                Utils.PrintTwoDimensional(listfinal);
                CheckWord();
            }
        }

        private void CheckWord()
        {
            int counter = 1;
            for (int i = 0; i < listfinal.Count; i++)
            {
                for (int j = 0; j < listfinal[i].Count; j++)
                {
                    if (listfinal[i][j] == counter)
                    {
                        counter++;
                        if (counter == listfinal.Count - 1)
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

        public enum EnumDirection
        {
            up,
            down,
            left,
            right
        }

        public void MoveLeft(List<List<int>> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Count; j++)
                {
                    if (list[i][j] == empty)
                    {
                        if (j == 0)
                        {
                            return;
                        }
                        else
                        {
                            int k = list[i][j];
                            list[i][j] = list[i][j - 1];
                            list[i][j - 1] = k;
                            return;
                        }
                    }
                }
            }
        }

        public void MoveRight(List<List<int>> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Count; j++)
                {
                    if (list[i][j] == empty)
                    {
                        if (j == list.Count - 1)
                        {
                            return;
                        }
                        else
                        {
                            int k = list[i][j];
                            list[i][j] = list[i][j + 1];
                            list[i][j + 1] = k;
                            return;
                        }
                    }
                }
            }
        }

        public void MoveUp(List<List<int>> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Count; j++)
                {
                    if (list[i][j] == empty)
                    {
                        if (i == 0)
                        {
                            return;
                        }
                        else
                        {
                            int k = list[i][j];
                            list[i][j] = list[i - 1][j];
                            list[i - 1][j] = k;
                            return;
                        }
                    }
                }
            }
        }

        public void MoveDown(List<List<int>> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Count; j++)
                {
                    if (list[i][j] == empty)
                    {
                        if (i == list.Count - 1)
                        {
                            return;
                        }
                        else
                        {
                            int k = list[i][j];
                            list[i][j] = list[i + 1][j];
                            list[i + 1][j] = k;
                            return;
                        }
                    }
                }
            }
        }
    }
}