using System;
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
            int[] array = new int[100];                
                for (int i = 0; i<array.Length; i++)
            {
                array[i] = i + 1;
                Console.WriteLine(array[i]);
                
            }
            Console.Read();
        }   
    }
}
