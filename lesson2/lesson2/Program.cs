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
            while ((x != 10)||(y != 15)||(z != 20))
            {
                //x++;
                if (x != 10)
                {
                    x++;
                }
                else if (y!=15)
                {
                    y++;
                }
                else if (z!=20)
                {
                    z++;
                }
            }
            Console.WriteLine("число x = {0}", x);
            Console.WriteLine("число y = {0}", y);
            Console.WriteLine("число z = {0}", z);
            Console.ReadLine();

        }
    }
}
