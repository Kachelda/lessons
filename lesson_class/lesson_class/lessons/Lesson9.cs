using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_class.lessons
{
    class Lesson9
    {
        public Lesson9()
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
}
