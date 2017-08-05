using System;
using System.Collections.Generic;

namespace lesson_class.lessons
{
    public class ChangesLogic
    {
        public ChangesLogic()
        {

        }

        //передвижение строки влево
        public static void ChangeRowLeft(List<List<string>> list, int lineNumber)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (i == lineNumber)
                    {
                        string k = list[i][j].ToString();
                        list[i][j] = list[i][j + 1];
                        list[i][j + 1] = k;
                    }
                }
            }
        }

        //передвижение строки вправо
        public static void ChangeRowRight(List<List<string>> list, int lineNumber)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = list.Count - 1; j > 0; j--)
                {
                    if (i == lineNumber)
                    {
                        string k = list[i][j].ToString();
                        list[i][j] = list[i][j - 1];
                        list[i][j - 1] = k;
                    }
                }
            }
        }

        //передвижение столбца вверх
        public static void ChangeColUp(List<List<string>> list, int lineNumber)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (j == lineNumber)
                    {
                        string k = list[i][j].ToString();
                        list[i][j] = list[i + 1][j];
                        list[i + 1][j] = k;
                    }
                }
            }
        }

        //передвижение столбца вниз
        public static void ChangeColDown(List<List<string>> list, int lineNumber)
        {
            for (int i = list.Count - 1; i > 0; i--)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (j == lineNumber)
                    {
                        string k = list[i][j].ToString();
                        list[i][j] = list[i - 1][j];
                        list[i - 1][j] = k;
                    }
                }
            }
        }
    }
}