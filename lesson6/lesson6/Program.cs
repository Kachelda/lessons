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
            List<int> list1 = new List<int>() { 0, 0, 0, 5, 5, 5, 9, 9, 9, 0, 5, 9};
            
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

            //удаление лишних элементов

            List<int> list2 = new List<int>();
            
            for (int i = 0; i <list1.Count-1; i++)
            {
                list2.Add(list1[i]);
                int p = 1;
                for (int j = i + 1; j < list1.Count; j++)
                {
                    if (list1[i] == list1[j] && p < 2)
                    {
                        list2.Add(list1[j]);
                        list1.RemoveAt(j);
                        p++;
                        j--;
                    }
                    else if (list1[i] == list1[j])
                    {
                        list1.RemoveAt(j);
                        j--;
                    }
                }
            }

            //вывод нового списка

            foreach (int n in list2)
            {
                Console.Write(" " + n);
            }

            Console.ReadLine();

        }
    }
}
