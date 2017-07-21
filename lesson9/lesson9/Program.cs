using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9
{
    enum Side
    {
        Left,
        Right
    }

    class Program
    {
        static void Main(string[] args)
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
            ChangeDiagonalExtended(listfinal, Side.Right, 0);
            PrintTwoDimensional(listfinal);
            Console.WriteLine();
            Console.ReadLine();
            
        }

        //общий метод по диагоналям
        public static void ChangeDiagonalExtended(List<List<int>> list, Side S, int numd)
        {
            if (numd >= 0 && numd < list.Count )
            {
                switch (S)
                {
                    case Side.Left:
                        ChangeDiagonalLeft(list, numd);
                        break;
                    case Side.Right:
                        ChangeDiagonalRight(list, numd);
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод параметра <S>!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод параметра <numd>!");
            }
        }
        
        // диагональ слева numd = i
        public static void ChangeDiagonalLeft(List<List<int>> list, int numd)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (i == j + numd)
                    {
                        int k = list[i][j];
                        list[i][j] = list[i + 1][ j + 1];
                        list[i + 1][j + 1] = k;
                    }
                }
            }
        }

        //диагональ справа numd = j
        public static void ChangeDiagonalRight(List<List<int>> list, int numd)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (j == i + numd)
                    {
                        int k = list[i][j];
                        list[i][j] = list[i + 1][j + 1];
                        list[i + 1][j + 1] = k;
                    }
                }
            }
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
