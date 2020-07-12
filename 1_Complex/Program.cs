// [Скоморохов Максим]
// б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
// в) Добавить диалог с использованием switch демонстрирующий работу класса.

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Complex
{

    class Program
    {
        static void Main(string[] args)
        {
            int userChoice = 0;

            while (GetUserChoice(ref userChoice))
            {
                // вывод диалогового окна для ввода значений
                Console.WriteLine("1ое комплексное число: a + bi");
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("b = ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("2ое комплексное число: c + di");
                Console.Write("c = ");
                double c = Convert.ToDouble(Console.ReadLine());

                Console.Write("d = ");
                double d = Convert.ToDouble(Console.ReadLine());


                Complex z1 = new Complex(a, b);
                Complex z2 = new Complex(c, d);

                switch (userChoice)
                {
                    case 1: // сложение
                        Complex result = z1 + z2;
                        Console.WriteLine($"Сложение: {result}");
                        break;
                    case 2: // вычитание
                        result = z1 - z2;
                        Console.WriteLine($"Вычитание: {result}");
                        break;
                    case 3: // Умножение
                        result = z1 * z2;
                        Console.WriteLine($"Умножение: {result}");
                        break;

                    default:
                        Console.WriteLine("Неверное число! Введите число от 0 до 3");
                        break;
                }
                Console.WriteLine("--------------------------------");
            }
 
        }

        //---------------------------------------------------------------------
        // вывод диалогового окна для выбора
        static bool GetUserChoice(ref int userChoice)
        {
            Console.WriteLine("Введите номера варианта операции с комплексными числами");
            Console.WriteLine("1 - сложение\n2 - вычитание\n3 - умножение\nлюбое другое число - выход");
            userChoice = Convert.ToInt32(Console.ReadLine());

            return (userChoice > 0 && userChoice <= 3) ? true : false;
        }
    }
}
