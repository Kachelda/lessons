using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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

        public int GetFileDimension()
        {
            int dimension = 0;
            
            using (StreamReader sr = new StreamReader("Game15.txt"))
            {
                dimension = Convert.ToInt32(sr.ReadLine());
            }
            return dimension;
        }

        public List<int> GetFileList(List<int> list)
        {
            using (StreamReader sr = new StreamReader("Game15.txt"))
            {
                sr.ReadLine();
                string help = sr.ReadLine();
                string[] numbers = help.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string s in numbers)
                {
                    list.Add(Convert.ToInt32(s));
                }
            }
            return list;
        }
    }
}
