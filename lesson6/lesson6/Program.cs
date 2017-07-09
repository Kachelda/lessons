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

            for (int i = 0; i < list1.Count; i++)
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

            for (int i = 0; i < list1.Count; i++)
            {
                if (list2.Count == 0)
                {
                    list2.Add(list1[i]);
                }
                else
                {
                    int p = 0;
                    for (int k = 0; k < list2.Count; k++)
                    {
                        if (list1[i] == list2[k])
                        {
                            p++;
                        }
                    }
                    if (p < 2)
                    {
                        list2.Add(list1[i]);
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