using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9
{
    class Program
    {
        static void Main(string[] args)
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
            ChangeDiagonal(listfinal);
            PrintTwoDimensional(listfinal);
            Console.ReadLine();
        }

        public static void ChangeDiagonal(List<List<int>> list)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        int k = list[i][j];
                        list[i][j] = list[i + 1][j + 1];
                        list[i + 1][j + 1] = list[i + 2][j + 2];
                        list[i + 2][j + 2] = k;
                        break; 
                    }
                }
                break;
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
