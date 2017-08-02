using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_class.lessons
{
    public class Lesson7
    {
        public Lesson7()
        {
            List<int> list1 = new List<int>() { 1, 1, 3, 4, 4, 4, 5, 6, 6, 6, 6, 3, 3, 3, 3, 3, 3, 3, 3 };

            for (int i = 0; i < list1.Count; i++)
            {
                int p = 1;
                for (int j = i + 1; j < list1.Count; j++)
                {
                    if (list1[i] == list1[j])
                    {
                        list1.RemoveAt(j);
                        j--;
                        p++;
                    }
                }
                Console.WriteLine("Элемент {0} встречается в списке {1} раз", list1[i], p);
            }
            Console.ReadLine();
        }
    }
}
