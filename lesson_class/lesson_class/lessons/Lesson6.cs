using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lesson_class.UtilsForLessons;

namespace lesson_class.lessons
{
    public class Lesson6
    {
        public Lesson6()
        {
            List<int> list1 = new List<int>() { 0, 0, 0, 5, 5, 5, 9, 9, 9, 0, 5, 9 };

            //обработка списка

            for (int i = 0; i < list1.Count; i++)
            {
                if (i % 2 == 0)
                {
                    list1.Insert(i + 1, list1[i] + 1);
                }
            }

            // вывод списка

            Utils.Print(list1);

            //удаление лишних элементов

            List<int> list2 = new List<int>();

            list2.Add(list1[0]);
            for (int i = 1; i < list1.Count; i++)
            {
                if (Utils.CountContains(list2, list1[i]) < 2)
                {
                    list2.Add(list1[i]);
                }
            }

            //вывод нового списка

            Utils.Print(list2);
        }
    }
}
