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
            List<int> list0 = new List<int>() { 1, 1, 5, 5, 6, 6 };
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            List<int> list3 = new List<int>();
            List<List<int>> listfinal = new List<List<int>>();

            //разбиваем лист на 3 листа 
            for (int i = 0; i < list0.Count; i++)
            {
                //list1 = new List<int>();
                //list2 = new List<int>();
                //list3 = new List<int>();
                if (CountContains(list1, list0[i]) > 0)
                {
                    list1.Add(list0[i]);
                }
                else if (list1.Count == 0)
                {
                    list1.Add(list0[i]);
                }
                else if (CountContains(list2, list0[i]) > 0)
                {
                    list2.Add(list0[i]);
                }
                else if (list2.Count == 0)
                {
                    list2.Add(list0[i]);
                }
                else if (CountContains(list3, list0[i]) > 0)
                {
                    list3.Add(list0[i]);
                }
                else if (list3.Count == 0)
                {
                    list3.Add(list0[i]);
                }

               
            }


            listfinal.Add(list1);
            listfinal.Add(list2);
            listfinal.Add(list3);

            Print(list1);
            Print(list2);
            Print(list3);
            
            for (int i = 0; i < listfinal.Count; i++)
            {
                for (int j = 0; j < 2; j++)
                Console.WriteLine(listfinal[i][j] + " ");
                Console.WriteLine();
            }
            Console.ReadLine();

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

      
            
        
    }
}
