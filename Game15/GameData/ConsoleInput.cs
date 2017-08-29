using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game15.GameData
{
    class ConsoleInput:IInput
    {
        public int Dimension { get; set; }

        public int GetDimension()
        {
            while (true)
            {
                int s;
                Console.WriteLine("Введите размерность игрового поля:");

                if (Int32.TryParse(Console.ReadLine(), out s) && s > 1)
                {
                    Dimension = s;
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка! Повторите ввод!");
                }
            }
            return Dimension;
        }
    }
}
