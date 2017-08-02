using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lesson_class.UtilsForLessons;

namespace lesson_class.lessons
{
    public class Lesson8
    {
        public Lesson8()
        {
            List<int> list0 = new List<int>() { 1, 1, 5, 5, 6, 6, 1 };
            List<List<int>> listfinal = new List<List<int>>();

            for (int i = 0; i < list0.Count; i++)
            {
                int help = Utils.ListCountContains(listfinal, list0[i]);
                if (help >= 0)
                {
                    listfinal[help].Add(list0[i]);
                }
                else
                {
                    listfinal.Add(new List<int>());
                    listfinal[listfinal.Count - 1].Add(list0[i]);
                }
            }
            //проверить что list0[i] есть ли уже среди listfinal
            //если да, тогда достаю list у котого хранится это значение чтобы добавить в него list0[i]
            //если нету, тогда добавляем пустой list и в него добавляем list0[i]
            //listfinal.Add(new List<int>() { list0[i] });


            //listfinal.Add(new List<int>());
            //listfinal[listfinal.Count - 1].Add(list0[i]); 

            Utils.PrintTwoDimensional(listfinal);
            Console.ReadLine();
        }
    }
}
