using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_class.lessons
{
    public class Lesson1
    {
        public Lesson1()
        {
            int x = 10;
            int y = 11;
            int z = 9;
            int t = 20;

            if (x != 10)
            {
                Console.WriteLine("Верно!");
            }
            else if (x == y)
            {
                Console.WriteLine("Верно!");
            }
            else if (x <= (t - y))
            {
                Console.WriteLine("Верно!");
            }
            else if (x < z)
            {
                Console.WriteLine("Верно!");
            }
            else if (x >= t)
            {
                Console.WriteLine("Верно!");
            }
            else if (x > (y + z))
            {
                Console.WriteLine("Верно!");
            }
            else
            {
                Console.WriteLine("Ни одно из условий не верно!");
                Console.ReadLine();
            }
        }
    }
}
