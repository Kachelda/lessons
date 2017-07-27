using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_class.lessons
{
    enum Side
    {
        Left,
        Right,
        Middle
    }

    class Lesson10
    {
        public Lesson10()
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
