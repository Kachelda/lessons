using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lesson_class.UtilsForLessons;

namespace lesson_class.lessons
{
    class Lesson12
    {
        public Lesson12()
        {
            List<string> list = new List<string>
            { "сок", "сом", "кум", "ком", "кол", "кор", "сор",
              "сук", "мор", "мул", "мак", "мир", "лом", "лук",
              "лак", "рок", "ром", "рак", "рис", "аул", "оса"};

            List<string> listCharacters = new List<string>();
            List<List<string>> listfinal = new List<List<string>>();

            //собираем буквы в список
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Length; j++)
                {
                    if (Utils.CountContains(listCharacters, list[i][j].ToString()) == 0)
                    {
                        listCharacters.Add(list[i][j].ToString());
                    }
                }
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
                        
            string exitgame = "exit";// слово для выхода из игры
            int counter = 0;//счетчик правильных слов
            int numrc;

            while (true)
            {
                Utils.PrintTwoDimensional(listfinal);
                counter = TestWord(listfinal, list, counter);
                Console.WriteLine("Количество правильных слов = {0}", counter);

                if (counter == 10)
                {
                    Console.WriteLine("Игра окончена!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

                Console.WriteLine("Введите 'row' или 'column' для изменения игрового поля, либо 'exit' для выхода из игры :");
                string rc1 = Console.ReadLine();

                if (rc1 == exitgame)
                {
                    Environment.Exit(0);
                }

                else if (rc1 == RowCol.row.ToString())
                {
                    Console.WriteLine("Введите номер <row> от 0 до 2 :");
                    if (Int32.TryParse(Console.ReadLine(), out numrc) && numrc >= 0 && numrc <= 2)
                    {
                        Console.WriteLine("Введите направление 'left' или 'right' :");
                        string way1 = Console.ReadLine();

                        if (way1 == WayRowCol.left.ToString())
                        {
                            ChangeRowLeft(listfinal, numrc);
                        }

                        else if (way1 == WayRowCol.right.ToString())
                        {
                            ChangeRowRight(listfinal, numrc);
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

                else if (rc1 == RowCol.column.ToString())
                {
                    Console.WriteLine("Введите номер <column> от 0 до 2 :");
                    if (Int32.TryParse(Console.ReadLine(), out numrc) && numrc >= 0 && numrc <= 2)
                    {
                        Console.WriteLine("Введите направление 'up' или 'dowm' :");
                        string way1 = Console.ReadLine();

                        if (way1 == WayRowCol.up.ToString())
                        {
                            ChangeColUp(listfinal, numrc);
                        }

                        else if (way1 == WayRowCol.down.ToString())
                        {
                            ChangeColDown(listfinal, numrc);
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

        //передвижение строки влево
        public static void ChangeRowLeft(List<List<string>> list, int numrc)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (i == numrc)
                    {
                        string k = list[i][j].ToString();
                        list[i][j] = list[i][j + 1];
                        list[i][j + 1] = k;
                    }
                }
            }
        }

        //передвижение строки вправо
        public static void ChangeRowRight(List<List<string>> list, int numrc)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = list.Count - 1; j > 0; j--)
                {
                    if (i == numrc)
                    {
                        string k = list[i][j].ToString();
                        list[i][j] = list[i][j - 1];
                        list[i][j - 1] = k;
                    }
                }
            }
        }

        //передвижение столбца вверх
        public static void ChangeColUp(List<List<string>> list, int numrc)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (j == numrc)
                    {
                        string k = list[i][j].ToString();
                        list[i][j] = list[i + 1][j];
                        list[i + 1][j] = k;
                    }
                }
            }
        }

        //передвижение столбца вниз
        public static void ChangeColDown(List<List<string>> list, int numrc)
        {
            for (int i = list.Count - 1; i > 0 ; i--)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (j == numrc)
                    {
                        string k = list[i][j].ToString();
                        list[i][j] = list[i - 1][j];
                        list[i - 1][j] = k;
                    }
                }
            }
        }

        //проверка есть ли слово и счетчик правильных ответов
        public static int TestWord(List<List<string>> list2, List<string> list, int counter)
        {
            string str = list2[1][0] + list2[1][1] + list2[1][2];
            if (Utils.CountContains(list, str) == 1)
            {
                counter++;
                list.Remove(str);
            }
            return counter;
        }
    }
}
