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
                       
            for (int i = 50; i > -50; i--)
            {
                if (i > 0)
                {
                    list1.Add(i);
                }
                else
                {
                    list1.Add(-i + 51);
                }
                       
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
