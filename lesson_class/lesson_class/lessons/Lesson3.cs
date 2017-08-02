using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_class.lessons
{
    public class Lesson3
    {
        public Lesson3()
        {
            int x = 7;
            int y = 9;
            int help;

            help = x;
            x = y;
            y = help;

            Console.WriteLine("step1: x = {0}, y = {1}", x, y);

            int a = 100;
            int b = 24;

            a = a - b;
            b = a + b;
            a = b - a;

            Console.WriteLine("step1: a = {0}, b = {1}", a, b);
            Console.ReadLine();
        }
    }
}
