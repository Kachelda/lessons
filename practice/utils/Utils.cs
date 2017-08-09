using System;
using System.Collections.Generic;

namespace lesson_class.UtilsForLessons
{
    public class Utils
    {
        public Utils()
        {

        }

        public static int CountContains(List<int> list, int value)
        {
            int p = 0;
            for (int k = 0; k < list.Count; k++)
            {
                if (value == list[k])
                {
                    p++;
                }
            }
            return p;
        }

        public static int CountContains(List<string> list, string value)
        {
            int p = 0;
            for (int k = 0; k < list.Count; k++)
            {
                if (value == list[k])
                {
                    p++;
                }
            }
            return p;
        }

        public static int ListCountContains(List<List<int>> list, int value)
        {
            int p = -1;
            for (int k = 0; k < list.Count; k++)
            {
                if (CountContains(list[k], value) > 0)
                {
                   p = k;
                }
            }
            return p;
        }

        public static void Print(List<int> list)
        {
            foreach (int i in list)
            {
                Console.Write(" " + i);
            }
            Console.ReadLine();
        }

        public static void PrintTwoDimensional(List<List<int>> list)
        {
            Console.Write("{");

            for (int i = 0; i < list.Count; i++)
            {
                PrintOneDimensional(list[i]);
                if (i + 1 < list.Count)
                {
                    Console.Write(",");
                    Console.Write("\n");
                }
            }
            Console.Write("\n");
            Console.Write("}");
            Console.WriteLine();
        }

        public static void PrintOneDimensional(List<int> list, string separator = "\t")
        {
            string result = "{" + string.Join(separator, list) + "}";
            Console.Write("\n");
            Console.Write(result);
        }

        public static void PrintTwoDimensional(List<List<string>> list)
        {
            Console.Write("{");

            for (int i = 0; i < list.Count; i++)
            {
                PrintOneDimensional(list[i]);
                if (i + 1 < list.Count)
                {
                    Console.Write(",");
                }
            }
            Console.Write("\n");
            Console.Write("}");
            Console.WriteLine();
        }

        public static void PrintOneDimensional(List<string> list, string separator = ",")
        {
            string result = "{" + string.Join(separator, list) + "}";
            Console.Write("\n");
            Console.Write(result);
        }
    }
}