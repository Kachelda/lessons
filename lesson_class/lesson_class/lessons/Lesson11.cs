using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lesson_class.UtilsForLessons;

namespace lesson_class.lessons
{
    public class Lesson11
    {
        public enum Side
        {
            Left,
            Right,
            Middle
        }
        public Lesson11()
        {
            List<List<int>> listfinal = new List<List<int>>();

            for (int i = 0; i < 4; i++)
            {
                listfinal.Add(new List<int>());

                for (int j = 0; j < 4; j++)
                {
                    listfinal[i].Add(listfinal.Count + i + i + j);
                }
            }
            
            Utils.PrintTwoDimensional(listfinal);
            Console.WriteLine();
            Console.WriteLine();
            ChangeDiagonalExtended(listfinal, Side.Left, 3);
            Utils.PrintTwoDimensional(listfinal);
            Console.ReadLine();
            
        }

        //3 параметра входных
        public static void ChangeDiagonalExtended(List<List<int>> list, Side S = Side.Middle, int numd = 0)
        {
            if (numd != list.Count - 1)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (i == j + numd && i < list.Count - 1 && S == Side.Left || 
                            j == i + numd && j < list.Count - 1 && S == Side.Right || 
                            i == j && i < list.Count - 1 && S == Side.Middle)
                        {
                            int k = list[i][j];
                            list[i][j] = list[i + 1][j + 1];
                            list[i + 1][j + 1] = k;
                        }
                    }
                }
            }
        }
    }
}
