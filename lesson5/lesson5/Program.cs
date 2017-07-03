using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> list1 = new List <int> () { };
                       
            for (int i = 0; i < 100; i++)
            {
                if (i < 50)
                {
                    list1.Add(50-i);
                }
                else
                {
                    list1.Add(i+1);
                }
                       
            }

            foreach (int n in list1)
            { 
                Console.WriteLine(n);
            }
            Console.WriteLine("Количество элементов = {0}", list1.Count);
            Console.ReadLine();
                       
            int help = 0;
            for (int j = 0; j < 50; j++)
            {
                help = list1[j];
                list1[j] = list1[j + 50];
                list1[j + 50] = help;
            }

            foreach (int n in list1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Количество элементов = {0}", list1.Count);
            Console.ReadLine();


        }
    }
}
