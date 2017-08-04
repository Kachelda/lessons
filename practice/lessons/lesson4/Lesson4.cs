using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_class.lessons
{
    public class Lesson4
    {
        public Lesson4()
        {
            List<int> array = new List<int> { };
            for (int i = 1; i <= 100; i++)
            {
                array.Add(i);
                Console.WriteLine(array.Count);
            }
            Console.Read();
        }
    }
}
