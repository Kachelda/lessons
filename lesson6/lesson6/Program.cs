using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 0, 0, 0, 5, 5, 5, 9, 9, 9, 0, 5, 9 };

            //обработка списка

            for (int i = 0; i<list1.Count; i++)
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

            //сортировка списка

            int sort;
            for (int x = 0; x < list1.Count - 1; x++)
            {
                for (int y = x + 1; y < list1.Count; y++)
                {
                    if (list1[x] > list1[y])
                    {
                        sort = list1[x];
                        list1[x] = list1[y];
                        list1[y] = sort;
                    }
                }
            }

            //вывод отсортированного списка

            foreach (int n in list1)
            {
                Console.Write(" " + n);
            }

            Console.ReadLine();

            //удаление повторяющихся элементов больше чем 2 раза

            for (int j = 0; j < list1.Count; j++)
            {
                for (int k = j + 1; k < list1.Count; k++ )
                {
                    if (list1[j] == list1[k])
                    {
                        list1.RemoveAt(j);
                    }
                }
                
                
                
            }
            // вывод списка

            foreach (int n in list1)
            {
                Console.Write(" " + n);
            }

            Console.ReadLine();



        }
    }
}
