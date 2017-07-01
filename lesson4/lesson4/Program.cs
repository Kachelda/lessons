using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
                for (int i = 1; i<101; i++)
                {
                    array.Add(i);
                    Console.WriteLine(array.Count);
                            
                }
            Console.Read();
        }   
    }
}
