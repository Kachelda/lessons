using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game15.GameData
{
    class ConsoleInput:IInput
    {
        public int GetDimension()
        {
            int dimension = 0;
            while (true)
            {
                int s;
                Console.WriteLine("Введите размерность игрового поля:");

                if (Int32.TryParse(Console.ReadLine(), out s) && s > 1)
                {
                    dimension = s;
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка! Повторите ввод!");
                }
            }
            return dimension;
        }
    }
}
