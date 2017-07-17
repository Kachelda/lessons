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
            int value = 0; 

            for (int i = 0; i < 3; i++)
            {
                listfinal.Add(new List<int>());
                for (int j = 0; j < 3; j++)
                {
                    value++;
                    listfinal[i].Add(value);
                }
            }

            PrintTwoDimensional(listfinal);
            Console.WriteLine();
            Console.WriteLine(listfinal[2][2]);
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
}
