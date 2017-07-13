using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> list0 = new List<List<int>>() { new List<int>() { 3, 4 }, new List<int>() { 1, 2 }, new List<int>() { 5, 6 } };
            List<int> listfinal = new List<int>();

            PrintTwoDimensional(list0);

            // формируем новый List
            for (int i = 0; i < list0.Count; i++)
            {
                for (int j = 0; j < list0[i].Count; j++)
                {
                    listfinal.Add(list0[i][j]);
                    Sortirovka(listfinal);
                }

            }

            Console.WriteLine();
            Console.WriteLine();

            PrintOneDimensional(listfinal);
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

        public static void Sortirovka(List<int> list)
        {
            int help;
            for (int i = 0; i<list.Count; i++)
            {
                for (int j = 0; j<list.Count; j++)
                {
                    if (list[i] < list[j])
                    {
                        help = list[i];
                        list[i] = list[j];
                        list[j] = help;
                    }
                }
            }
        }
    }
}



           
  


                  