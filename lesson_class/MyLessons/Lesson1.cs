using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLessons
{
    public class Lesson1
    {
        public Lesson1()
        {
            int x = 10;
            int y = 11;
            int z = 9;
            int t = 20;

            if (x != 10)
            {
                Console.WriteLine("Верно!");
            }
            else if (x == y)
            {
                Console.WriteLine("Верно!");
            }
            else if (x <= (t - y))
            {
                Console.WriteLine("Верно!");
            }
            else if (x < z)
            {
                Console.WriteLine("Верно!");
            }
            else if (x >= t)
            {
                Console.WriteLine("Верно!");
            }
            else if (x > (y + z))
            {
                Console.WriteLine("Верно!");
            }
            else
            {
                Console.WriteLine("Ни одно из условий не верно!");
                Console.ReadLine();
            }
        }
    }

    public class Lesson2
    {
        public Lesson2()
        {
            int x = 0;
            int y = 0;
            int z = 0;
            while (true)
            {
                if (x < 10)
                {
                    x++;
                }

                if (y < 15)
                {
                    y++;
                }

                if (z < 20)
                {
                    z++;
                }

                if (x == 10 && y == 15 && z == 20)
                {
                    break;
                }
            }
            Console.WriteLine("число x = {0}", x);
            Console.WriteLine("число y = {0}", y);
            Console.WriteLine("число z = {0}", z);
            Console.ReadLine();

        }
    }

    public class Lesson3
    {
        public Lesson3()
        {
            int x = 7;
            int y = 9;
            int help;

            help = x;
            x = y;
            y = help;

            Console.WriteLine("step1: x = {0}, y = {1}", x, y);

            int a = 100;
            int b = 24;

            a = a - b;
            b = a + b;
            a = b - a;

            Console.WriteLine("step1: a = {0}, b = {1}", a, b);
            Console.ReadLine();
        }
    }

    public class Lesson4
    {
        public Lesson4()
        {
            List<int> array = new List<int> { };
            for (int i = 1; i <= 100; i++)
            {
                array.Add(i);
                Console.WriteLine(array.Count);

            }
            Console.Read();
        }
    }

    public class Lesson5
    {
        public Lesson5()
        {
            List<int> list1 = new List<int>() { };

            for (int i = 0; i < 100; i++)
            {
                if (i < 50)
                {
                    list1.Add(50 - i);
                }
                else
                {
                    list1.Add(i + 1);
                }

            }

            foreach (int n in list1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Количество элементов = {0}", list1.Count);
            Console.ReadLine();

            int help = 0;
            for (int j = 0; j < 50; j++)
            {
                help = list1[j];
                list1[j] = list1[j + 50];
                list1[j + 50] = help;
            }

            foreach (int n in list1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Количество элементов = {0}", list1.Count);
            Console.ReadLine();
        }
    }

    public class Lesson6
    {
        public Lesson6()
        {
            List<int> list1 = new List<int>() { 0, 0, 0, 5, 5, 5, 9, 9, 9, 0, 5, 9 };

            //обработка списка

            for (int i = 0; i < list1.Count; i++)
            {
                if (i % 2 == 0)
                {
                    list1.Insert(i + 1, list1[i] + 1);
                }

            }

            // вывод списка

            foreach (int n in list1)
            {
                Console.Write(" " + n);
            }

            Console.ReadLine();

            //удаление лишних элементов

            List<int> list2 = new List<int>();

            list2.Add(list1[0]);
            for (int i = 1; i < list1.Count; i++)
            {
                if (CountContains(list2, list1[i]) < 2)
                {
                    list2.Add(list1[i]);
                }
            }

            //вывод нового списка

            foreach (int n in list2)
            {
                Console.Write(" " + n);
            }

            Console.ReadLine();

        }
        public static int CountContains(List<int> list, int value)
        {
            int p = 0;
            for (int k = 0; k < list.Count; k++)
            {
                if (value == list[k])
                {
                    p++;
                }
            }
            return p;
        }
    }

    public class Lesson7
    {
        public Lesson7()
        {
            List<int> list1 = new List<int>() { 1, 1, 3, 4, 4, 4, 5, 6, 6, 6, 6, 3, 3, 3, 3, 3, 3, 3, 3 };

            for (int i = 0; i < list1.Count; i++)
            {
                int p = 1;
                for (int j = i + 1; j < list1.Count; j++)
                {
                    if (list1[i] == list1[j])
                    {
                        list1.RemoveAt(j);
                        j--;
                        p++;
                    }

                }
                Console.WriteLine("Элемент {0} встречается в списке {1} раз", list1[i], p);
            }
            Console.ReadLine();
        }
    }

    public class Lesson8
    {
        public Lesson8()
        {
            List<int> list0 = new List<int>() { 1, 1, 5, 5, 6, 6, 1 };
            List<List<int>> listfinal = new List<List<int>>();

            for (int i = 0; i < list0.Count; i++)
            {
                int help = ListCountContains(listfinal, list0[i]);
                if (help >= 0)
                {
                    listfinal[help].Add(list0[i]);
                }
                else
                {
                    listfinal.Add(new List<int>());
                    listfinal[listfinal.Count - 1].Add(list0[i]);
                }
            }
            //проверить что list0[i] есть ли уже среди listfinal
            //если да, тогда достаю list у котого хранится это значение чтобы добавить в него list0[i]
            //если нету, тогда добавляем пустой list и в него добавляем list0[i]
            //listfinal.Add(new List<int>() { list0[i] });


            //listfinal.Add(new List<int>());
            //listfinal[listfinal.Count - 1].Add(list0[i]); 



            PrintTwoDimensional(listfinal);

            Console.ReadLine();

        }

        static int ListCountContains(List<List<int>> list, int value)
        {
            int p = -1;
            for (int k = 0; k < list.Count; k++)
            {
                if (CountContains(list[k], value) > 0)
                {
                    //p = p - k;
                    //k = p + k;
                    //p = k - p;
                    p = k;
                }
            }
            return p;
        }

        static int CountContains(List<int> list, int value)
        {
            int p = 0;
            for (int k = 0; k < list.Count; k++)
            {
                if (value == list[k])
                {
                    p++;
                }
            }
            return p;
        }

        static void Print(List<int> list)
        {
            foreach (int i in list)
            {
                Console.Write(" " + i);
            }
            Console.ReadLine();
        }

        public static void PrintTwoDimensional(List<List<int>> list)
        {
            Console.Write("{");

            for (int i = 0; i < list.Count; i++)
            {
                PrintOneDimensional(list[i]);
                if (i + 1 < list.Count)
                {
                    Console.Write(",");
                }
            }
            Console.Write("}");
        }

        public static void PrintOneDimensional(List<int> list, string separator = ",")
        {
            string result = "{" + string.Join(separator, list) + "}";
            Console.Write(result);
        }
    }

    public class Lesson9
    {
        public Lesson9()
        {
            List<List<int>> list0 = new List<List<int>>() { new List<int>() { 3, 4 }, new List<int>() { 1, 2 }, new List<int>() { 5, 6 } };
            List<int> listfinal = new List<int>();

            PrintTwoDimensional(list0);

            // формируем новый List
            for (int i = 0; i < list0.Count; i++)
            {
                for (int j = 0; j < list0[i].Count; j++)
                {
                    listfinal.Insert(SortVst(listfinal, list0[i][j]), list0[i][j]);
                }

            }

            Console.WriteLine();
            Console.WriteLine();

            PrintOneDimensional(listfinal);
            Console.ReadLine();
        }

        public static int SortVst(List<int> list, int value)
        {
            int ind = 0;
            if (list.Count == 0)
            {
                ind = list.Count;
            }
            else if (value >= list[list.Count - 1])
            {
                ind = list.Count;
            }
            else if (value <= list[0])
            {
                ind = 0;
            }
            else
            {
                for (int k = 0; k < list.Count; k++)
                {
                    if (list[k] <= value && list[k + 1] >= value)
                    {
                        ind = k + 1;
                    }

                }
            }
            return ind;
        }

        public static void PrintTwoDimensional(List<List<int>> list)
        {
            Console.Write("{");

            for (int i = 0; i < list.Count; i++)
            {
                PrintOneDimensional(list[i]);
                if (i + 1 < list.Count)
                {
                    Console.Write(",");
                }
            }
            Console.Write("}");
        }

        public static void PrintOneDimensional(List<int> list, string separator = ",")
        {
            string result = "{" + string.Join(separator, list) + "}";
            Console.Write(result);
        }
    }

    public class Lesson10
    {
        public Lesson10()
        {
            List<List<int>> listfinal = new List<List<int>>();

            for (int i = 0; i < 3; i++)
            {
                listfinal.Add(new List<int>());

                for (int j = 0; j < 3; j++)
                {
                    listfinal[i].Add(listfinal.Count + i + i + j);
                }
            }

            PrintTwoDimensional(listfinal);
            Console.WriteLine();
            Console.WriteLine();
            ChangeDiagonal2(listfinal);
            PrintTwoDimensional(listfinal);
            Console.ReadLine();
        }

        //сдвиг диагонали вниз вправо
        public static void ChangeDiagonal1(List<List<int>> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (i == j)
                    {
                        int k = list[i][j];
                        list[i][j] = list[list.Count - 1][list.Count - 1];
                        list[list.Count - 1][list.Count - 1] = k;
                    }
                }
            }
        }

        //сдвиг диагонали вверх влево
        public static void ChangeDiagonal2(List<List<int>> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                for (int j = list.Count - 1; j >= 0; j--)
                {
                    if (i == j)
                    {
                        int k = list[i][j];
                        list[i][j] = list[list.Count - 1][list.Count - 1];
                        list[list.Count - 1][list.Count - 1] = k;
                    }
                }
            }
        }

        public static void PrintTwoDimensional(List<List<int>> list)
        {
            Console.Write("{");

            for (int i = 0; i < list.Count; i++)
            {
                PrintOneDimensional(list[i]);

                if (i + 1 < list.Count)
                {
                    Console.Write(",");
                }
            }
            Console.Write("}");
        }

        public static void PrintOneDimensional(List<int> list, string separator = ",")
        {
            string result = "{" + string.Join(separator, list) + "}";
            Console.Write(result);
        }
    }
    
    public class Lesson11
    {
        public enum Side
        {
            Left,
            Right,
            Middle
        }
        public Lesson11()
        {
            List<List<int>> listfinal = new List<List<int>>();

            for (int i = 0; i < 4; i++)
            {
                listfinal.Add(new List<int>());

                for (int j = 0; j < 4; j++)
                {
                    listfinal[i].Add(listfinal.Count + i + i + j);
                }
            }

            PrintTwoDimensional(listfinal);
            Console.WriteLine();
            Console.WriteLine();
            ChangeDiagonalExtended(listfinal, Side.Left, 3);
            PrintTwoDimensional(listfinal);
            Console.ReadLine();

        }

        //3 параметра входных
        public static void ChangeDiagonalExtended(List<List<int>> list, Side S = Side.Middle, int numd = 0)
        {
            if (numd != list.Count - 1)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (i == j + numd && i < list.Count - 1 && S == Side.Left || j == i + numd && j < list.Count - 1 && S == Side.Right || i == j && i < list.Count - 1 && S == Side.Middle)
                        {
                            int k = list[i][j];
                            list[i][j] = list[i + 1][j + 1];
                            list[i + 1][j + 1] = k;
                        }
                    }
                }
            }
        }

        public static void PrintTwoDimensional(List<List<int>> list)
        {
            Console.Write("{");

            for (int i = 0; i < list.Count; i++)
            {
                PrintOneDimensional(list[i]);

                if (i + 1 < list.Count)
                {
                    Console.Write(",");
                }
            }
            Console.Write("}");
        }

        public static void PrintOneDimensional(List<int> list, string separator = ",")
        {
            string result = "{" + string.Join(separator, list) + "}";
            Console.Write(result);
        }
    }
}
