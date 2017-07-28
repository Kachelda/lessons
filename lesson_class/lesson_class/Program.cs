using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLessons;

namespace lesson_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер урока:");
            int num = Int32.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    new Lesson1();
                    break;
                case 2:
                    new Lesson2();
                    break;
                case 3:
                    new Lesson3();
                    break;
                case 4:
                    new Lesson4();
                    break;
                case 5:
                    new Lesson5();
                    break;
                case 6:
                    new Lesson6();
                    break;
                case 7:
                    new Lesson7();
                    break;
                case 8:
                    new Lesson8();
                    break;
                case 9:
                    new Lesson9();
                    break;
                case 10:
                    new Lesson10();
                    break;
                case 11:
                    new Lesson11();
                    break;
                default:
                    Console.WriteLine("Урока с таким номером не существует!");
                    Console.ReadLine();
                    break;
            }
        }
    }
}