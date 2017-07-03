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

            for (int i = 0; i<list1.Count; i++)
            {
               if (i % 2 == 0)
                {
                    list1.Insert(i + 1, list1[i] + 1); 
                }

            }

            foreach (int n in list1)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }
    }
}
