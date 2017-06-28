using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int z = 0;
            do
            {
                if (x != 10)
                {
                    x++;
                }
                if (y != 15)
                {
                    y++;
                }
                if (z != 20)
                {
                    z++;
                }
                
            }
            while (x  < 10|y < 15|z < 20);
            Console.WriteLine("Число x = {0}", x);
            Console.WriteLine("Число y = {0}", y);
            Console.WriteLine("Число z = {0}", z);
            Console.ReadLine();

        }
    }
}
