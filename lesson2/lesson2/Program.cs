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
            while ((x != 10) || (y != 15) || (z != 20))
            {
                for (int i = 0; i < 100; i++)
                {
                    if (i == 10)
                    {
                        x = i;
                        break;
                    }

                }
                for (int k = 0; k < 100; k++)
                {
                    if (k == 15)
                    {
                        y = k;
                        break;
                    }
                }
                for (int m = 0; m < 100; m++)
                {
                    if (m == 20)
                    {
                        z = m;
                        break;
                    }


                }
                Console.WriteLine("Число x = {0}", x);
                Console.WriteLine("Число y = {0}", y);
                Console.WriteLine("Число z = {0}", z);
                Console.ReadLine();

            }
        }
    }
}
