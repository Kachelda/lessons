using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_class.lessons
{
    class Lesson2
    {
        public Lesson2()
        {
            int x = 0;
            int y = 0;
            int z = 0;
            while (true)
            {
                if (x < 10)
                {
                    x++;
                }

                if (y < 15)
                {
                    y++;
                }

                if (z < 20)
                {
                    z++;
                }

                if (x == 10 && y == 15 && z == 20)
                {
                    break;
                }
            }
            Console.WriteLine("число x = {0}", x);
            Console.WriteLine("число y = {0}", y);
            Console.WriteLine("число z = {0}", z);
            Console.ReadLine();

        }
    }
}
