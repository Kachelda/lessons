﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> list1 = new List <int> () { };
                       
            for (int i = 1; i <= 100; i++)
            {
                if (i <= 50)
                {
                    list1.Insert(i-1, 51-i);
                }
                else
                {
                    list1.Insert(i - 1, i);
                }
                       
            }

            foreach (int n in list1)
            { 
                Console.WriteLine(n);
            }
            Console.WriteLine("Количество элементов = {0}", list1.Count);
            Console.ReadLine();


        }
    }
}
