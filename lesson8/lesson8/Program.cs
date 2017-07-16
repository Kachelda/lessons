﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> list0 = new List<List<int>>() { new List<int>() { 3, 4, 1, 2 }, new List<int>() { 1, 2 }, new List<int>() { 5, 6, 3, 4, 5 } };
            List<int> listfinal = new List<int>();

            PrintTwoDimensional(list0);

            // формируем новый List
            for (int i = 0; i < list0.Count; i++)
            {
                for (int j = 0; j < list0[i].Count; j++)
                {
                    int help = SortVst(listfinal, list0[i][j]);
                    listfinal.Insert(help, list0[i][j]);
                }

            }

            Console.WriteLine();
            Console.WriteLine();
            
            PrintOneDimensional(listfinal);
            Console.ReadLine();

        }

        public static int SortVst(List<int> list, int value)
        {
            int ind = 0;
            if (list.Count == 0)
            {
                ind = list.Count;
            }
            else if (value >= list[list.Count - 1])
            {
                ind = list.Count;
            }
            else if (value <= list[0])
            {
                ind = 0;
            }
            else
            {
                for (int k = list.Count - 1; k >= 0; k--)
                {
                    if (list[k] >= value && list[k - 1] <= value)
                    {
                        ind = k;
                    }

                }
            }
            return ind;
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
                }
            }
            Console.Write("}");
        }

        public static void PrintOneDimensional(List<int> list, string separator = ",")
        {
            string result = "{" + string.Join(separator, list) + "}";
            Console.Write(result);
        }

        
    }
}



           
  


                  