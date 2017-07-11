using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list0 = new List<int>() { 1, 1, 5, 5, 6, 6, 1 };
            List<List<int>> listfinal = new List<List<int>>();

            for (int i = 0; i < list0.Count; i++)
            {
                if (ListCountContains(listfinal, list0[i]) >= 0)
                {
                    listfinal[ListCountContains(listfinal, list0[i])].Add(list0[i]);
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
                if (CountContains(list[k], value)>0)
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
            foreach (List<int> list1 in list)
            {
                PrintOneDimensional(list1);
                Console.Write(",");
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
