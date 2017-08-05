using lesson_class.lessons;
using lesson_class.lessons.lesson12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_class
{
    class Program
    {
        const string keyword = "exit"; //ключевое слово для выхода

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите номер урока или наберите 'exit' для выхода:");
                int n;
                string num = Console.ReadLine();
                               
                if (keyword == num)
                {
                    Environment.Exit(0);
                }
                else if (Int32.TryParse(num, out n))
                    {
                        switch (n)
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
                            case 12:
                                new Lesson12();
                                break;
                            default:
                                Console.WriteLine("Урока с таким номером не существует, введите число от 1 до 12");
                                break;
                        }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод, сделайте правильный выбор!");
                }
            }
        }
    }
}