using System;
using System.Text.RegularExpressions;

namespace Calсulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string prodoljenie;

            do
            {
                double a = 0; double b = 0;

                //заголовок
                Console.WriteLine("Консольный калькулятор\r");


                //первое число
                Console.WriteLine("Введите 1 число и нажмите Enter");
                a = Convert.ToDouble(Console.ReadLine());

                //второе число
                Console.WriteLine("Введите 2 число и нажмите Enter");
                b = Convert.ToDouble(Console.ReadLine());

                //выбор операции
                Console.WriteLine("Выберите операцию, которую хотите произвести:");
                Console.WriteLine("\t1 - Сложение");
                Console.WriteLine("\t2 - Вычитание");
                Console.WriteLine("\t3 - Умножение");
                Console.WriteLine("\t4 - Деление");

                //математические расчеты
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine($"Результат: {a} + {b} = " + (a + b));
                        break;
                    case "2":
                        Console.WriteLine($"Результат: {a} - {b} = " + (a - b));
                        break;
                    case "3":
                        Console.WriteLine($"Результат: {a} * {b} = " + (a * b));
                        break;
                    case "4":
                        Console.WriteLine($"Результат: {a} / {b} = " + (a / b));
                        break;
                }

                Console.WriteLine("Если хотите продолжить работу, введите 'да' и нажмите Enter, иначе нажмите Enter");
                prodoljenie =   Convert.ToString(Console.ReadLine());

            } while  (prodoljenie == "да");
        }
    }
}