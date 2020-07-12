// [Скоморохов Максим]
// С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел.Сами числа и сумму вывести на экран, используя tryParse.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_SumOddPositiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;
            do
            {
                Console.Write("Введите целое число (0 - конец):");
                string numberString = Console.ReadLine();

                if (int.TryParse(numberString, out number) && number > 0 && number % 2 == 1)
                {
                    Console.WriteLine($"{number} - нечётное положительное");
                    sum += number;
                }
                    
            } while (number != 0);

            // Выводим результат
            Console.WriteLine($"Сумма всех нечетных положительных чисел = {sum}");
            Console.ReadLine();
        }
    }
}
