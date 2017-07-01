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
            List<int> list1 = new List<int>() {};
            
            for (int i = 1; i <= 100; i++)
            {   
                list1.Add(i);
            }

            list1.Reverse(0, 50);

            foreach (int j in list1)
            { 
                Console.WriteLine(j);
            }

            Console.ReadLine();


        }
    }
}
